namespace OceanLibrary
{
    public class Ocean : IOceanCells
    {
        #region Variables      

        readonly AddElements addElements = new AddElements();
        readonly CardinalDirections cardinalDirections = new CardinalDirections();
        readonly Randomizer randomizer = new Randomizer();

        private uint _numIteration;
        private uint _numObstacle = Constant.defaultNumObstacle;
        private uint _numPrey = Constant.defaultNumPrey;
        private uint _numPredator = Constant.defaultNumPredator;
        private int _numRows = Constant.maxRows;
        private int _numCols = Constant.maxCols;
        private uint _nowIteration = 0;

        public Cell[,] cells;
        #endregion

        #region Properties

        public uint NumIteration
        {
            get { return _numIteration; }
            set { _numIteration = value; }
        }
        public uint NumObstacle
        {
            get { return _numObstacle; }
            set { _numObstacle = value; }
        }
        public uint NumPrey
        {
            get { return _numPrey; }
            set { _numPrey = value; }
        }
        public uint NumPredator
        {
            get { return _numPredator; }
            set { _numPredator = value; }
        }
        public int NumRows
        {
            get { return _numRows; }
            set { _numRows = value; }
        }
        public int NumCols
        {
            get { return _numCols; }
            set { _numCols = value; }
        }
        public uint NowIteration
        {
            get { return _nowIteration; }
            set { _nowIteration = value; }
        }

        #endregion

        #region MainMethods

        public void Initialize(uint userObstacle, uint userPrey, uint userPredator, uint userIteration)
        {
            _numRows = Constant.maxRows;
            _numCols = Constant.maxCols;
            cells = new Cell[NumRows, NumCols];

            InitCells(userObstacle, userPrey, userPredator, userIteration);
        }

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

        private void InitCells(uint userObstacle, uint userPrey, uint userPredator, uint userIteration)
        {
            NumObstacle = userObstacle;
            NumPrey = userPrey;
            NumPredator = userPredator;
            NumIteration = userIteration;

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
