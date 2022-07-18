using System;
using System.Windows.Forms;

namespace OceanWF.OceanSettings
{
    public partial class Settings : Form
    {
        #region Constructor

        public Settings()
        {           
            InitializeComponent();

            preySettingsTextBox.KeyPress += new KeyPressEventHandler(InputInTextBox);
            predatorSettingsTextBox.KeyPress += new KeyPressEventHandler(InputInTextBox);
            obstacleSettingsTextBox.KeyPress += new KeyPressEventHandler(InputInTextBox);
            iterationSettingsTextBox.KeyPress += new KeyPressEventHandler(InputInTextBox);
        }
        #endregion

        #region Methods

        private void InputInTextBox(object sender, KeyPressEventArgs e)
        {
            int BackspaceID = 8;

            preySettingsTextBox.MaxLength = 3;
            predatorSettingsTextBox.MaxLength = 3;
            obstacleSettingsTextBox.MaxLength = 3;
            iterationSettingsTextBox.MaxLength = 4;

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != BackspaceID)
            {
                e.Handled = true;
            }

        }

        private void DataRecording()
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

            if (iterationSettingsTextBox.Text.Length != 0)
            {
                DataBank.NumIteration = UInt32.Parse(iterationSettingsTextBox.Text);
            }

        }
        #endregion

        #region Buttons

        private void okSettingsButton_Click(object sender, EventArgs e)
        {
            DataRecording();

            Close();
        }

        private void exitSettingsButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

    }
}
