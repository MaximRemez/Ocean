using OceanLibrary;
using OceanLibrary.OceanException;
using System;
using System.Windows.Forms;

namespace OceanWF.OceanSettings
{
    public partial class Settings : Form
    {
        #region Variables

        OutputException outputMessage = new OutputException();

        private uint _numberSumElements = 0;
        private uint _numberIteration = 0;
        private readonly uint _fieldSize = Constant.maxCols * Constant.maxRows;
        #endregion

        #region Constructor

        public Settings()
        {
            InitializeComponent();

            outputMessage.RegisterException(ShowExceptionMessage);

            preySettingsTextBox.KeyPress += new KeyPressEventHandler(InputInTextBox);
            predatorSettingsTextBox.KeyPress += new KeyPressEventHandler(InputInTextBox);
            obstacleSettingsTextBox.KeyPress += new KeyPressEventHandler(InputInTextBox);
            rimuruFishSettingsTextBox.KeyPress += new KeyPressEventHandler(InputInTextBox);
            iterationSettingsTextBox.KeyPress += new KeyPressEventHandler(InputInTextBox);

            preySettingsTextBox.KeyDown += new KeyEventHandler(NextTextBox);
            predatorSettingsTextBox.KeyDown += new KeyEventHandler(NextTextBox);
            obstacleSettingsTextBox.KeyDown += new KeyEventHandler(NextTextBox);
            rimuruFishSettingsTextBox.KeyDown += new KeyEventHandler(NextTextBox);
            iterationSettingsTextBox.KeyDown += new KeyEventHandler(NextTextBox);
        }
        #endregion

        #region EventMethods

        private void InputInTextBox(object sender, KeyPressEventArgs e)
        {
            int BackspaceID = 8;

            preySettingsTextBox.MaxLength = 3;
            predatorSettingsTextBox.MaxLength = 3;
            obstacleSettingsTextBox.MaxLength = 3;
            iterationSettingsTextBox.MaxLength = 4;
            rimuruFishSettingsTextBox.MaxLength = 3;

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != BackspaceID)
            {
                e.Handled = true;
            }

        }

        private void NextTextBox(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (preySettingsTextBox.Focused == true)
                {
                    predatorSettingsTextBox.Focus();
                }

                else if (predatorSettingsTextBox.Focused == true)
                {
                    obstacleSettingsTextBox.Focus();
                }

                else if (obstacleSettingsTextBox.Focused == true)
                {
                    rimuruFishSettingsTextBox.Focus();
                }

                else if(rimuruFishSettingsTextBox.Focused == true)
                {
                    iterationSettingsTextBox.Focus();
                }

                else if (iterationSettingsTextBox.Focused == true)
                {
                    DataRecording();
                    okSettingsButton.Focus();
                }

            }
        }
        #endregion

        #region Methods

        private void ShowExceptionMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void ClearSettings()
        {
            preySettingsTextBox.Text = null;
            predatorSettingsTextBox.Text = null;
            obstacleSettingsTextBox.Text = null;
            rimuruFishSettingsTextBox.Text = null;
            iterationSettingsTextBox.Text = null;

            DataBank.NumPrey = 0;
            DataBank.NumPredator = 0;
            DataBank.NumObstacle = 0;
            DataBank.NumRimuruFish = 0;
            DataBank.NumIteration = 0;
        }

        private void DataRecording()
        {
            try
            {
                if (preySettingsTextBox.Text.Length != 0)
                {
                    DataBank.NumPrey = UInt32.Parse(preySettingsTextBox.Text);
                }

                if (predatorSettingsTextBox.Text.Length != 0)
                {
                    DataBank.NumPredator = UInt32.Parse(predatorSettingsTextBox.Text);
                }

                if (obstacleSettingsTextBox.Text.Length != 0)
                {
                    DataBank.NumObstacle = UInt32.Parse(obstacleSettingsTextBox.Text);
                }

                if (rimuruFishSettingsTextBox.Text.Length != 0)
                {
                    DataBank.NumRimuruFish = UInt32.Parse(rimuruFishSettingsTextBox.Text);
                }

                if (iterationSettingsTextBox.Text.Length != 0)
                {
                    DataBank.NumIteration = UInt32.Parse(iterationSettingsTextBox.Text);
                }

                _numberSumElements = DataBank.NumPrey + DataBank.NumPredator + DataBank.NumObstacle + DataBank.NumRimuruFish;
                _numberIteration = DataBank.NumIteration;

                if (_numberSumElements > _fieldSize)
                {
                    ClearSettings();
                    throw new InvalidSumElementsException();
                }
                if (DataBank.NumIteration > Constant.maxIteration)
                {
                    ClearSettings();
                    throw new InvalidIterationValueException();
                }
            }
            catch (InvalidSumElementsException sumException)
            {
                outputMessage.ShowOnScreen(sumException.Message);
            }
            catch (InvalidIterationValueException iterationException)
            {
                outputMessage.ShowOnScreen(iterationException.Message);
            }
            catch (Exception defaultException)
            {
                outputMessage.ShowOnScreen(defaultException.Message);
            }
        }
        #endregion

        #region Buttons

        private void okSettingsButton_Click(object sender, EventArgs e)
        {
            DataRecording();

            if (_numberSumElements <= _fieldSize && _numberIteration <= Constant.maxIteration)
            {
                Close();
            }
        }

        private void exitSettingsButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

    }
}