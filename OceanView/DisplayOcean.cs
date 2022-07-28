using OceanLibrary;
using OceanLibrary.OceanException;
using System;

namespace OceanView
{
    class DisplayOcean : IOceanDisplay, IOceanUI
    {
        #region Variables
        readonly OutputException outputMessage = new OutputException();

        private readonly uint _iterationRows = Constant.maxRows + 3;
        private readonly uint _iterationCols = Constant.maxCols + 4;

        private char[,] _lastOceanImage;
        private char[,] _newOceanImage;
        private string _oceanStats;

        private uint _userNumObstacles;
        private uint _userNumPrey;
        private uint _userNumPredator;
        private uint _userNumRimuruFish;
        private uint _userNumIteration;

        private bool _isConverted;
        #endregion

        #region Properties

        public uint UserNumObstacles
        {
            get { return _userNumObstacles; }
            set { _userNumObstacles = value; }
        }

        public uint UserNumPrey
        {
            get { return _userNumPrey; }
            set { _userNumPrey = value; }
        }

        public uint UserNumPredator
        {
            get { return _userNumPredator; }
            set { _userNumPredator = value; }
        }

        public uint UserNumRimuruFish
        {
            get { return _userNumRimuruFish; }
            set { _userNumRimuruFish = value; }
        }

        public uint UserNumIteration
        {
            get { return _userNumIteration; }
            set { _userNumIteration = value; }
        }
        #endregion

        #region Constructor

        public DisplayOcean()
        {
            outputMessage.RegisterException(ShowExceptionMessage);
        }
        #endregion

        #region DisplayMethods

        public void CountInfo(Ocean displayOcean)
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

        public void Display(int iteration, Ocean displayOcean)
        {
            _lastOceanImage = new char[_iterationRows, _iterationCols];
            _newOceanImage = new char[_iterationRows, _iterationCols];

            _oceanStats = String.Format("Iteration: {0}/{1}  Obstacle: {2}  Prey: {3}  Predator: {4}  Rimuru: {5}", iteration,
                displayOcean.NumIteration, displayOcean.NumObstacle, displayOcean.NumPrey, displayOcean.NumPredator, displayOcean.NumRimuruFish);

            _newOceanImage = GetIterationImage(_newOceanImage, _oceanStats, displayOcean);

            for (int i = 0; i < _iterationRows; i++)
            {
                for (int j = 0; j < _iterationCols; j++)
                {

                    if (_newOceanImage[i, j] != _lastOceanImage[i, j])
                    {
                        Console.SetCursorPosition(j, i);
                        Console.Write(_newOceanImage[i, j]);
                    }

                }
            }

            _lastOceanImage = GetIterationImage(_lastOceanImage, _oceanStats, displayOcean);
        }

        private char[,] GetIterationImage(char[,] iterationImage, string stats, Ocean displayOcean)
        {
            for (int i = 0; i < _iterationRows; i++)
            {
                for (int j = 0; j < _iterationCols; j++)
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

                    else if (i == 1 || i == _iterationRows - 1)
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

        #region UIMethods

        public void SetValue()
        {
            try
            {
                Console.Write("Enter the number of obstacles (default is 75): ");
                _isConverted = UInt32.TryParse(Console.ReadLine(), out _userNumObstacles);
                while (!_isConverted)
                {
                    Console.Write("Enter the correct number of obstacles: ");
                    _isConverted = UInt32.TryParse(Console.ReadLine(), out _userNumObstacles);
                }

                Console.Write("Enter the number of prey (default is 150): ");
                _isConverted = UInt32.TryParse(Console.ReadLine(), out _userNumPrey);
                while (!_isConverted)
                {
                    Console.Write("Enter the correct number of prey: ");
                    _isConverted = UInt32.TryParse(Console.ReadLine(), out _userNumPrey);
                }

                Console.Write("Enter the number of predator (default is 20): ");
                _isConverted = UInt32.TryParse(Console.ReadLine(), out _userNumPredator);
                while (!_isConverted)
                {
                    Console.Write("Enter the correct number of predator: ");
                    _isConverted = UInt32.TryParse(Console.ReadLine(), out _userNumPredator);
                }

                Console.Write("Enter the number of Rimurufish (default is 8): ");
                _isConverted = UInt32.TryParse(Console.ReadLine(), out _userNumRimuruFish);
                while (!_isConverted)
                {
                    Console.Write("Enter the correct number of Rimurufish: ");
                    _isConverted = UInt32.TryParse(Console.ReadLine(), out _userNumRimuruFish);
                }

                Console.Write("Enter the number of iteration(defaul is 100): ");
                _isConverted = UInt32.TryParse(Console.ReadLine(), out _userNumIteration);
                while (!_isConverted)
                {
                    Console.Write("Enter the correct number of iteration: ");
                    _isConverted = UInt32.TryParse(Console.ReadLine(), out _userNumIteration);
                }

                uint numberSumElements = _userNumPredator + _userNumPrey + _userNumObstacles + _userNumRimuruFish;
                uint fieldSize = (Constant.maxCols-1) * Constant.maxRows;

                if (numberSumElements > fieldSize)
                {
                    throw new InvalidSumElementsException();
                }
                if (_userNumIteration > Constant.maxIteration)
                {
                    throw new InvalidIterationValueException();
                }

            }
            catch (InvalidSumElementsException sumException)
            {
                outputMessage.ShowOnScreen(sumException.Message);
                SetValue();
            }
            catch (InvalidIterationValueException iterationException)
            {
                outputMessage.ShowOnScreen(iterationException.Message);
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

        private void ShowExceptionMessage(string message)
        {
            Console.WriteLine(message);
        }
        #endregion

    }
}
