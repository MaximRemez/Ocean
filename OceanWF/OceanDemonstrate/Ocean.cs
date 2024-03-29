﻿using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using OceanLibrary;

namespace OceanWF.OceanDemonstrate
{
    public partial class Ocean : Form
    {
        #region Variables
        public static Bitmap predator = new Bitmap(Properties.Resources.pixelPredator);
        public static Bitmap prey = new Bitmap(Properties.Resources.pixelPrey);
        public static Bitmap obstacle = new Bitmap(Properties.Resources.pixelObstacle);
        public static Bitmap rimuru = new Bitmap(Properties.Resources.pixelRimuru);
        public static Bitmap tentacle = new Bitmap(Properties.Resources.pixelTentacle);
        public static Bitmap dragon = new Bitmap(Properties.Resources.pixelDragon);
        public static Bitmap fire = new Bitmap(Properties.Resources.pixelFire);

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
            DoubleBuffered();
        }

        private new void DoubleBuffered()
        {
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
            | BindingFlags.Instance | BindingFlags.NonPublic, null,
            oceanDataGridView, new object[] { true });
        }
        #endregion

        #region Events

        private void Ocean_Load(object sender, EventArgs e)
        {
            OceanDataInitialze();
            GenerateModel();
            OceanModelInitialize();
        }

        private void Ocean_FormClosing(object sender, FormClosingEventArgs e)
        {
            Reset();
        }

        private void intervalTrackBar_Scroll(object sender, EventArgs e)
        {
            IntervalScroll();
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

            intervalTrackBar.Value = Constant.interval;
            interavalShowLabel.Text = Constant.interval.ToString();
            iterationTimer.Interval = Constant.interval;

            preyShowLabel.Text = DataBank.NumPrey.ToString();
            predatorShowLabel.Text = DataBank.NumPredator.ToString();
            obstacleShowLabel.Text = DataBank.NumObstacle.ToString();
            rimuruShowLabel.Text = DataBank.NumRimuruFish.ToString();
            iterationShowLabel.Text = 0.ToString();

            progressBar.Maximum = (int)DataBank.NumIteration;
            maxValueLabel.Text = DataBank.NumIteration.ToString();
        }

        private void CorrectData()
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
        }

        private void GenerateModel()
        {
            for (int cols = 0; cols < Constant.maxCols; cols++)
            {
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                imageCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                imageCol.DefaultCellStyle.NullValue = null;

                oceanDataGridView.Columns.Add(imageCol);
                oceanDataGridView.Columns[cols].Width = 17;
            }

            for (int rows = 0; rows < Constant.maxRows; rows++)
            {
                oceanDataGridView.Rows.Add();
                oceanDataGridView.Rows[rows].Height = 17;
            }
        }

        private void OceanModelInitialize()
        {
            myOcean.Initialize(DataBank.NumObstacle, DataBank.NumPrey, DataBank.NumPredator,DataBank.NumRimuruFish, DataBank.NumIteration);

            for (int rows = 0; rows < Constant.maxRows; rows++)
            {
                for (int cols = 0; cols < Constant.maxCols; cols++)
                {
                    if (myOcean.cells[rows, cols].Image == Constant.defaultCellImage)
                    {
                        oceanDataGridView.Rows[rows].Cells[cols].Value = null;
                    }

                    else if (myOcean.cells[rows, cols].Image == Constant.defaultPreyImage)
                    {
                        oceanDataGridView.Rows[rows].Cells[cols].Value = prey;
                    }

                    else if (myOcean.cells[rows, cols].Image == Constant.defaultPredatorImage)
                    {
                        oceanDataGridView.Rows[rows].Cells[cols].Value = predator;
                    }

                    else if (myOcean.cells[rows, cols].Image == Constant.defaultObstacleImage)
                    {
                        oceanDataGridView.Rows[rows].Cells[cols].Value = obstacle;
                    }

                    else if (myOcean.cells[rows, cols].Image == Constant.defaultRimuruImage)
                    {
                        oceanDataGridView.Rows[rows].Cells[cols].Value = rimuru;
                    }

                    else
                    {
                        oceanDataGridView.Rows[rows].Cells[cols].Value = dragon;
                    }

                }
            }

        }

        private void IntervalScroll()
        {
            interavalShowLabel.Text = intervalTrackBar.Value.ToString();
        }

        private void EventPerTick()
        {
            if (WasStarted == true)
            {
                nowIteration++;
                myOcean.Run();

                iterationTimer.Interval = intervalTrackBar.Value;

                oceanDisplay.CountInfo(myOcean);
                oceanDisplay.Display(nowIteration, myOcean, oceanDataGridView, preyShowLabel,
                 predatorShowLabel, obstacleShowLabel, rimuruShowLabel, iterationShowLabel, progressBar);

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
            DataBank.NumRimuruFish = 0;
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