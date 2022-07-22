using OceanLibrary;
using System.Windows.Forms;

namespace OceanWF.OceanDemonstrate
{
    public class DisplayOcean : IOceanDisplay
    {
        #region Methods

        public void CountInfo(OceanLibrary.Ocean displayOcean)
        {
            int countOfObstacle = 0;
            int countOfPrey = 0;
            int countOfPredator = 0;
            int countOfRimuruFish = 0;

            for (int row = 0; row < displayOcean.NumRows; row++)
            {
                for (int column = 0; column < displayOcean.NumCols; column++)
                {
                    if (displayOcean.cells[row, column].Image == Constant.defaultObstacleImage)
                    {
                        countOfObstacle++;
                    }

                    if (displayOcean.cells[row, column].Image == Constant.defaultPreyImage)
                    {
                        countOfPrey++;
                    }

                    if (displayOcean.cells[row, column].Image == Constant.defaultPredatorImage)
                    {
                        countOfPredator++;
                    }

                    if (displayOcean.cells[row, column].Image == Constant.defaultRimuruImage)
                    {
                        countOfRimuruFish++;
                    }

                }
            }

            displayOcean.NumObstacle = (uint)countOfObstacle;
            displayOcean.NumPrey = (uint)countOfPrey;
            displayOcean.NumPredator = (uint)countOfPredator;
            displayOcean.NumRimuruFish = (uint)countOfRimuruFish;
        }

        public void Display(int iteration, OceanLibrary.Ocean displayOcean, DataGridView dataGridView, Label prey,
            Label predator, Label obstacle,Label rimuru, Label allIteration, ProgressBar nowIteration)
        {
            DisplayIterations(dataGridView, displayOcean);

            prey.Text = displayOcean.NumPrey.ToString();
            predator.Text = displayOcean.NumPredator.ToString();
            obstacle.Text = displayOcean.NumObstacle.ToString();
            rimuru.Text = displayOcean.NumRimuruFish.ToString();
            allIteration.Text = iteration.ToString();

            if (iteration <= nowIteration.Maximum)
            {
                nowIteration.Value = iteration;
            }

        }
        #endregion

        #region PrivateMethods

        private void DisplayIterations(DataGridView dataGridView, OceanLibrary.Ocean displayOcean)
        {
            for (int rows = 0; rows < Constant.maxRows; rows++)
            {
                for (int cols = 0; cols < Constant.maxCols; cols++)
                {

                    if (displayOcean.cells[rows, cols].Image == Constant.defaultCellImage)
                    {
                        dataGridView.Rows[rows].Cells[cols].Value = null;
                    }

                    else if (displayOcean.cells[rows, cols].Image == Constant.defaultPredatorImage)
                    {
                        dataGridView.Rows[rows].Cells[cols].Value = Ocean._predator;
                    }

                    else if (displayOcean.cells[rows, cols].Image == Constant.defaultPreyImage)
                    {
                        dataGridView.Rows[rows].Cells[cols].Value = Ocean._prey;
                    }

                    else if(displayOcean.cells[rows, cols].Image == Constant.defaultRimuruImage)
                    {
                        dataGridView.Rows[rows].Cells[cols].Value = Ocean._rimuru;
                    }

                    else if(displayOcean.cells[rows, cols].Image == Constant.defaultObstacleImage)
                    {
                        dataGridView.Rows[rows].Cells[cols].Value = Ocean._obstacle;
                    }

                    else if(displayOcean.cells[rows, cols].Image == Constant.defaultTentacleImage)
                    {
                        dataGridView.Rows[rows].Cells[cols].Value = Ocean._fire;
                    }

                }
            }
        }

        #endregion
    }
}