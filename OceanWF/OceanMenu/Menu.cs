using OceanLibrary;
using OceanWF.OceanSettings;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OceanWF.OceanMenu
{
    public partial class Menu : Form
    {
        #region Variables

        Settings formSettings;
        OceanDemonstrate.Ocean formOcean;
        #endregion

        #region Constructor
   
        public Menu()
        {       
            InitializeComponent();
          
            ImageAnimator.Animate(BackgroundImage, OnFrameChanged);
        }
        #endregion

        #region Methods

        private void OnFrameChanged(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke((Action)(() => OnFrameChanged(sender, e)));
                return;
            }
            ImageAnimator.UpdateFrames();
            Invalidate(false);
        }

        private void SetDefaultSettings()
        {
            DataBank.NumPrey = Constant.defaultNumPrey;
            DataBank.NumPredator = Constant.defaultNumPredator;
            DataBank.NumObstacle = Constant.defaultNumObstacle;
            DataBank.NumIteration = Constant.defaultNumIteration;
        }
        #endregion

        #region Buttons

        private void startMenuButton_Click(object sender, EventArgs e)
        {        
            formOcean = new OceanDemonstrate.Ocean();
           
            formOcean.Show();
        }

        private void defaultSettingsButton_Click(object sender, EventArgs e)
        {
            SetDefaultSettings();
        }

        private void settingsMenuButton_Click(object sender, EventArgs e)
        {
            formSettings = new Settings();

            formSettings.ShowDialog();
        }

        private void exitMenuButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
