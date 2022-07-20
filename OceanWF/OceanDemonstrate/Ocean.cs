using System;
using System.Drawing;
using System.Windows.Forms;
using OceanLibrary;
using OceanLibrary.OceanException;

namespace OceanWF.OceanDemonstrate
{
    public partial class Ocean : Form
    {
  
        #region Variables

        readonly OceanLibrary.Ocean myOcean = new OceanLibrary.Ocean();
        readonly IOceanDisplay oceanDisplay = new DisplayOcean();

        private bool WasStarted = false;
        private bool IsEnded = false;

        int nowIteration = 0;

        #endregion

        #region Constructor
      
        public Ocean()
        {
            InitializeComponent();        
        }
        #endregion
        
        #region Events

        private void Ocean_Load(object sender, EventArgs e)
        {
            OceanDataInitialze();
            OceanModelInitialize();   
        }

        private void Ocean_FormClosing(object sender, FormClosingEventArgs e)
        {
            Reset();
        }

        private void iterationTimer_Tick(object sender, EventArgs e)
        {
            EventPerTick();
        }

        #endregion

        #region Methods

        private void OceanDataInitialze()
        {
            CorrectData();

            oceanDataGridView.DefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 192);

            oceanDataGridView.ColumnCount = Constant.maxCols;
            oceanDataGridView.RowCount = Constant.maxRows;

            preyShowLabel.Text = DataBank.NumPrey.ToString();
            predatorShowLabel.Text = DataBank.NumPredator.ToString();
            obstacleShowLabel.Text = DataBank.NumObstacle.ToString();
            iterationShowLabel.Text = 0.ToString();

            progressBar.Maximum = (int)DataBank.NumIteration;
            maxValueLabel.Text = DataBank.NumIteration.ToString();          
        }

        private void CorrectData()
        {
            try
            {
                if (DataBank.NumIteration == 0)
                {
                    DataBank.NumIteration = Constant.defaultNumIteration;
                }

                if (DataBank.NumPrey == 0)
                {
                    DataBank.NumPrey = Constant.defaultNumPrey;
                }

                if (DataBank.NumPredator == 0)
                {
                    DataBank.NumPredator = Constant.defaultNumPredator;
                }

                uint numberSumElements = DataBank.NumPrey + DataBank.NumPredator + DataBank.NumObstacle;
                uint fieldSize = Constant.maxCols * Constant.maxRows;

                if (numberSumElements > fieldSize)
                {
                    throw new InvalidValueElementsException();
                }
                if (DataBank.NumIteration > Constant.maxIteration)
                {
                    throw new InvalidIterationValueException();
                }

            }
            catch (InvalidValueElementsException sumException)
            {
                MessageBox.Show(sumException.Message);
                Close();
            }
            catch (InvalidIterationValueException iterationException)
            {
                MessageBox.Show(iterationException.Message);
                Close();
            }
        }

        private void OceanModelInitialize()
        {
            myOcean.Initialize(DataBank.NumObstacle, DataBank.NumPrey, DataBank.NumPredator, DataBank.NumIteration);

            for (int rows = 0; rows < Constant.maxRows; rows++)
            {
                for (int cols = 0; cols < Constant.maxCols; cols++)
                {
                    oceanDataGridView.Rows[rows].Cells[cols].Value = myOcean.cells[rows, cols].Image;
                }
            }

        }

        private void EventPerTick()
        {
            if (WasStarted == true)
            {
                nowIteration++;
                myOcean.Run();

                oceanDisplay.CountInfo(myOcean);
                  oceanDisplay.Display(nowIteration, myOcean, oceanDataGridView, preyShowLabel,
                   predatorShowLabel, obstacleShowLabel, iterationShowLabel, progressBar);

                if (nowIteration == myOcean.NumIteration || myOcean.NumPrey == 0 || myOcean.NumPredator == 0)
                {
                    iterationTimer.Stop();

                    changeButton.ForeColor = Color.FromArgb(255, 255, 192);
                    changeButton.Text = "End of Simulation";
                    IsEnded = true;
                }
            }

        }

        private void Reset()
        {
            DataBank.NumPrey = 0;
            DataBank.NumPredator = 0;
            DataBank.NumObstacle = 0;
            DataBank.NumIteration = 0;

            progressBar.Maximum = 0;
            progressBar.Value = 0;
        }
        #endregion

        #region Buttons

        private void changeButton_Click(object sender, EventArgs e)
        {
            WasStarted = true;

            if (changeButton.Text == "End of Simulation")
            {
                Close();
            }

            if (changeButton.Text == "Start" && IsEnded == false)
            {
                iterationTimer.Start();

                changeButton.Text = "Stop";
                changeButton.ForeColor = Color.Red;             
            }

            else
            {
                iterationTimer.Stop();
                
                changeButton.Text = "Start";
                changeButton.ForeColor = Color.FromArgb(255, 255, 192);             
            }       

        }
        #endregion

    }
}