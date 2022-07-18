using OceanLibrary;
using OceanLibrary.OceanException;
using System;

namespace OceanView
{
    class DisplayOcean : IOceanDisplay, IOceanUI
    {
        #region Variables

        private uint iterationRows = Constant.maxRows + 3;
        private uint iterationCols = Constant.maxCols + 4;

        private char[,] lastOceanImage;
        private char[,] newOceanImage;
        private string oceanStats;
        #endregion

        #region Methods

        public void CountInfo(Ocean displayOcean)
        {
            int countOfObstacle = 0;
            int countOfPrey = 0;
            int countOfPredator = 0;

            for (int row = 0; row < displayOcean.NumRows; row++)
            {
                for (int column = 0; column < displayOcean.NumCols; column++)
                {
                    if (displayOcean.cells[row, column].Image == '#')
                    {
                        countOfObstacle++;
                    }

                    if (displayOcean.cells[row, column].Image == 'f')
                    {
                        countOfPrey++;
                    }

                    if (displayOcean.cells[row, column].Image == 'S')
                    {
                        countOfPredator++;
                    }

                }
            }

            displayOcean.NumObstacle = (uint)countOfObstacle;
            displayOcean.NumPrey = (uint)countOfPrey;
            displayOcean.NumPredator = (uint)countOfPredator;
        }

        public void Display(int iteration, Ocean displayOcean)
        {
            lastOceanImage = new char[iterationRows, iterationCols];
            newOceanImage = new char[iterationRows, iterationCols];

            oceanStats = String.Format("Iteration: {0}/{1}     Obstacle: {2}     Prey: {3}      Predator: {4}",
                iteration, displayOcean.NumIteration, displayOcean.NumObstacle, displayOcean.NumPrey, displayOcean.NumPredator);

            newOceanImage = GetIterationImage(newOceanImage, oceanStats, displayOcean);

            for (int i = 0; i < iterationRows; i++)
            {
                for (int j = 0; j < iterationCols; j++)
                {

                    if (newOceanImage[i, j] != lastOceanImage[i, j])
                    {
                        Console.SetCursorPosition(j, i);
                        Console.Write(newOceanImage[i, j]);
                    }

                }
            }

            lastOceanImage = GetIterationImage(lastOceanImage, oceanStats, displayOcean);
        }

        private char[,] GetIterationImage(char[,] iterationImage, string stats, Ocean displayOcean)
        {
            for (int i = 0; i < iterationRows; i++)
            {
                for (int j = 0; j < iterationCols; j++)
                {

                    if (i == 0)
                    {
                        if (j < stats.Length)
                        {
                            iterationImage[i, j] = stats[j];
                        }
                        else
                        {
                            iterationImage[i, j] = ' ';
                        }
                    }

                    else if (i == 1 || i == iterationRows - 1)
                    {
                        if (j < Constant.maxCols)
                        {
                            iterationImage[i, j] = '*';
                        }
                        else
                        {
                            iterationImage[i, j] = ' ';
                        }
                    }

                    else
                    {
                        if (j < Constant.maxCols)
                        {
                            iterationImage[i, j] = displayOcean.cells[i - 2, j].Image;
                        }
                        else
                        {
                            iterationImage[i, j] = ' ';
                        }
                    }

                }
            }

            return iterationImage;
        }
        #endregion

        #region Variables

        private uint userNumObstacles;
        private uint userNumPrey;
        private uint userNumPredator;
        private uint userNumIteration;
        public int countOfOcean;

        private bool IsConverted;
        #endregion

        #region Properties

        public uint UserNumObstacles
        {
            get { return userNumObstacles; }
            set { userNumObstacles = value; }
        }

        public uint UserNumPrey
        {
            get { return userNumPrey; }
            set { userNumPrey = value; }
        }

        public uint UserNumPredator
        {
            get { return userNumPredator; }
            set { userNumPredator = value; }
        }

        public uint UserNumIteration
        {
            get { return userNumIteration; }
            set { userNumIteration = value; }
        }
        #endregion

        #region Methods

        public void SetValue()
        {
            try
            {
                Console.Write("Enter the number of obstacles (default is 75): ");
                IsConverted = UInt32.TryParse(Console.ReadLine(), out userNumObstacles);
                while (!IsConverted)
                {
                    Console.Write("Enter the correct number of obstacles: ");
                    IsConverted = UInt32.TryParse(Console.ReadLine(), out userNumObstacles);
                }

                Console.Write("Enter the number of prey (default is 150): ");
                IsConverted = UInt32.TryParse(Console.ReadLine(), out userNumPrey);
                while (!IsConverted)
                {
                    Console.Write("Enter the correct number of prey: ");
                    IsConverted = UInt32.TryParse(Console.ReadLine(), out userNumPrey);
                }

                Console.Write("Enter the number of predator (default is 20): ");
                IsConverted = UInt32.TryParse(Console.ReadLine(), out userNumPredator);
                while (!IsConverted)
                {
                    Console.Write("Enter the correct number of predator: ");
                    IsConverted = UInt32.TryParse(Console.ReadLine(), out userNumPredator);
                }

                Console.Write("Enter the number of iteration(defaul is 100): ");
                IsConverted = UInt32.TryParse(Console.ReadLine(), out userNumIteration);
                while (!IsConverted)
                {
                    Console.Write("Enter the correct number of iteration: ");
                    IsConverted = UInt32.TryParse(Console.ReadLine(), out userNumIteration);
                }

                uint numberSumElements = userNumPredator + userNumPrey + userNumObstacles;
                uint fieldSize = Constant.maxCols * Constant.maxRows;

                if (numberSumElements > fieldSize)
                {
                    throw new InvalidValueElementsException();
                }
                if (userNumIteration > Constant.maxIteration)
                {
                    throw new InvalidIterationValueException();
                }

            }
            catch (InvalidValueElementsException sumException)
            {
                Console.WriteLine("Error: {0}", sumException.Message);
                SetValue();
            }
            catch (InvalidIterationValueException iterationException)
            {
                Console.WriteLine("Error: {0}", iterationException.Message);
                SetValue();
            }

        }

        public void EndModeling(int iteration, Ocean endOcean)
        {
            if (iteration == endOcean.NumIteration)
            {
                Console.SetCursorPosition(Constant.indentMidOcean, Constant.downIndent);
                Console.WriteLine("|^-^| End of model run |^-^|");
                Console.ReadKey();
            }
        }

        public int EnterCountOcean()
        {
            Console.Write("Enter the number of ocean(1/2): ");
            IsConverted = Int32.TryParse(Console.ReadLine(), out countOfOcean);
            while (!IsConverted)
            {
                Console.Write("Enter the correct number of ocean: ");
                IsConverted = Int32.TryParse(Console.ReadLine(), out countOfOcean);
            }
            if (countOfOcean > Constant.maxCountOcean)
            {
                countOfOcean = Constant.maxCountOcean;
            }

            if (countOfOcean <= 0)
            {
                countOfOcean = Constant.minCountOcean;
            }

            return countOfOcean;
        }
        #endregion

    }
}
