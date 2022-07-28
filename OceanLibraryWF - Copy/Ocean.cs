using OceanLibrary.OceanException;
using System;
using System.Windows.Forms;

namespace OceanLibrary
{
    public class Ocean : IOceanCells
    {
        #region Variables      

        readonly AddElements addElements = new AddElements();
        readonly CardinalDirections cardinalDirections = new CardinalDirections();
        readonly Randomizer randomizer = new Randomizer();
        readonly OutputException outputMessage = new OutputException();

        private uint _numIteration;
        private uint _numObstacle = Constant.defaultNumObstacle;
        private uint _numPrey = Constant.defaultNumPrey;
        private uint _numPredator = Constant.defaultNumPredator;
        private uint _numRimuruFish = Constant.defaultNumRimuru;
        private uint _numDragon = Constant.maxRows;

        private int _numRows = Constant.maxRows;
        private int _numCols = Constant.maxCols;
        private uint _nowIteration = 0;

        private int _size = Constant.maxCols * Constant.maxRows;

        public Cell[,] cells;
        #endregion

        #region Properties

        public uint NumIteration
        {
            get { return _numIteration; }
            set 
            {
                try
                {
                    if (value > Constant.maxIteration || value < 0)
                    {
                        throw new InvalidIterationValueException();
                    }
                    else
                    {
                        _numIteration = value;
                    }
                }
                catch (InvalidIterationValueException iterationException)
                {
                    outputMessage.ShowOnScreen(iterationException.Message);
                    Environment.Exit(0);
                }
    
            }
        }

        public uint NumObstacle
        {
            get { return _numObstacle; }
            set
            {
                try
                {
                    if (value > _size || value < 0)
                    {
                        throw new InvalidNumberElementException();
                    }
                    else
                    {
                        _numObstacle = value;
                    }
                }
                catch (InvalidNumberElementException numException)
                {
                    outputMessage.ShowOnScreen(numException.Message);
                    Environment.Exit(0);
                }
     
            }
        }

        public uint NumPrey
        {
            get { return _numPrey; }
            set
            {
                try
                {
                    if (value > _size || value < 0)
                    {
                        throw new InvalidNumberElementException();
                    }
                    else
                    {
                        _numPrey = value;
                    }
                }
                catch (InvalidNumberElementException numException)
                {
                    outputMessage.ShowOnScreen(numException.Message);
                    Environment.Exit(0);
                }

            }
        }

        public uint NumPredator
        {
            get { return _numPredator; }
            set
            {
                try
                {
                    if (value > _size || value < 0)
                    {
                        throw new InvalidNumberElementException();
                    }
                    else
                    {
                        _numPredator = value;
                    }
                }
                catch(InvalidNumberElementException numException)
                {
                    outputMessage.ShowOnScreen(numException.Message);
                    Environment.Exit(0);
                }
            }
        }

        public uint NumRimuruFish
        {
            get { return _numRimuruFish; }
            set
            {
                try
                {
                    if (value > _size || value < 0)
                    {
                        throw new InvalidNumberElementException();
                    }
                    else
                    {
                        _numRimuruFish = value;
                    }
                }
                catch (InvalidNumberElementException numException)
                {
                    outputMessage.ShowOnScreen(numException.Message);
                    Environment.Exit(0);
                }
            }
        }

        public uint NumDragon
        {
            get { return _numDragon; }
            set
            {
                try
                {
                    if (value > _size || value < 0)
                    {
                        throw new InvalidNumberElementException();
                    }
                    else
                    {
                        _numDragon = value;
                    }
                }
                catch (InvalidNumberElementException numException)
                {
                    outputMessage.ShowOnScreen(numException.Message);
                    Environment.Exit(0);
                }
            }
        }

        public int NumRows
        {
            get { return _numRows; }
            set
            {
                try
                {
                    if (value > Constant.maxRows || value < 0)
                    {
                        throw new InvalidSizeException();
                    }
                    else
                    {
                        _numRows = value;
                    }
                }
                catch (InvalidSizeException sizeException)
                {
                    outputMessage.ShowOnScreen(sizeException.Message);
                    Environment.Exit(0);
                }

            }
        }

        public int NumCols
        {
            get { return _numCols; }
            set
            {
                try
                {
                    if (value > Constant.maxCols || value < 0)
                    {
                        throw new InvalidSizeException();
                    }
                    else
                    {
                        _numCols = value;
                    }
                }
                catch (InvalidSizeException sizeException)
                {
                    outputMessage.ShowOnScreen(sizeException.Message);
                    Environment.Exit(0);
                }

            }
        }

        public uint NowIteration
        {
            get { return _nowIteration; }
            set
            {
                try
                {
                    if (value > Constant.maxIteration || value < 0)
                    {
                        throw new InvalidIterationValueException();
                    }
                    else
                    {
                        _nowIteration = value;
                    }
                }
                catch (InvalidIterationValueException iterationException)
                {
                    outputMessage.ShowOnScreen(iterationException.Message);
                    Environment.Exit(0);
                }

            }
        }

        #endregion

        #region Constructor

        public Ocean()
        {
            outputMessage.RegisterException(ShowExceptionMessage);
        }
        #endregion

        #region MainMethods

        /// <summary>
        /// Method that generates an ocean with user-specified values
        /// </summary>
        /// <param name="userObstacle">The number of obstacles that will be generated in the ocean</param>
        /// <param name="userPrey">The number of preys that will be generated in the ocean</param>
        /// <param name="userPredator">The number of predators that will be generated in the ocean</param>
        /// <param name="userNumRimuru">The number of rimurufish that will be generated in the ocean</param>
        /// <param name="userIteration">The number of iterations the ocean will have</param>
        public void Initialize(uint userObstacle, uint userPrey, uint userPredator, uint userNumRimuru, uint userIteration)
        {
            NumRows = _numRows;
            NumCols = _numCols;
            NumPrey = _numPrey;
            NumPredator = _numPredator;
            NumObstacle = _numObstacle;
            NumRimuruFish = _numRimuruFish;

            cells = new Cell[NumRows, NumCols];

            InitCells(userObstacle, userPrey, userPredator, userNumRimuru, userIteration);
        }

        /// <summary>
        /// Method that starts a process in the ocean
        /// </summary>
        public void Run()
        {
            _nowIteration++;

            for (int row = 0; row < NumRows; row++)
            {
                for (int column = 0; column < NumCols; column++)
                {
                    cells[row, column].Process(this);
                }
            }

            for (int row = 0; row < NumRows; row++)
            {
                for (int column = 0; column < NumCols; column++)
                {
                    cells[row, column].wasProcessed = false;
                }
            }

        }
        #endregion

        #region Methods

        private void ShowExceptionMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void InitCells(uint userObstacle, uint userPrey, uint userPredator, uint userNumRimuru, uint userIteration)
        {
            NumObstacle = userObstacle;
            NumPrey = userPrey;
            NumPredator = userPredator;
            NumRimuruFish = userNumRimuru;
            NumIteration = userIteration;

            NumDragon = (uint)NumRows;

            addElements.AddOceanElements(this);
        }

        public Cell GetCellAt(Coordinate aCoord)
        {
            return cells[aCoord.Y, aCoord.X];
        }

        public void AssignCellAt(Coordinate aCoord, Cell cell)
        {
            cells[aCoord.Y, aCoord.X] = cell;
        }
        #endregion

        #region SerchNeighborsImage

        public Coordinate GetNeighborCell(char anImage, Coordinate anOffset)
        {
            int numNeighbors = 4;
            Cell[] neighbors = new Cell[numNeighbors];

            int i = 0;

            if (cardinalDirections.GetNorthCell(anOffset, this).Image == anImage)
            {
                neighbors[i] = cardinalDirections.GetNorthCell(anOffset, this);
                i++;
            }

            if (cardinalDirections.GetSouthCell(anOffset, this).Image == anImage)
            {
                neighbors[i] = cardinalDirections.GetSouthCell(anOffset, this);
                i++;
            }

            if (cardinalDirections.GetWestCell(anOffset, this).Image == anImage)
            {
                neighbors[i] = cardinalDirections.GetWestCell(anOffset, this);
                i++;
            }

            if (cardinalDirections.GetEastCell(anOffset, this).Image == anImage)
            {
                neighbors[i] = cardinalDirections.GetEastCell(anOffset, this);
                i++;
            }

            if (i == 0)
            {
                return anOffset;
            }
            else return neighbors[randomizer.RandNum(i)].Offset;
        }
        #endregion

    }
}
