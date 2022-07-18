namespace OceanLibrary
{
    public class Ocean : IOceanCells
    {
        #region Variables      

        readonly AddElements addElements = new AddElements();
        readonly CardinalDirections cardinalDirections = new CardinalDirections();
        readonly Randomizer randomizer = new Randomizer();

        private uint numIteration;
        private uint numObstacle = Constant.defaultNumObstacle;
        private uint numPrey = Constant.defaultNumPrey;
        private uint numPredator = Constant.defaultNumPredator;
        private int numRows = Constant.maxRows;
        private int numCols = Constant.maxCols;
        private uint nowIteration = 0;

        public Cell[,] cells;
        #endregion

        #region Properties

        public uint NumIteration
        {
            get { return numIteration; }
            set { numIteration = value; }
        }
        public uint NumObstacle
        {
            get { return numObstacle; }
            set { numObstacle = value; }
        }
        public uint NumPrey
        {
            get { return numPrey; }
            set { numPrey = value; }
        }
        public uint NumPredator
        {
            get { return numPredator; }
            set { numPredator = value; }
        }
        public int NumRows
        {
            get { return numRows; }
            set { numRows = value; }
        }
        public int NumCols
        {
            get { return numCols; }
            set { numCols = value; }
        }
        public uint NowIteration
        {
            get { return nowIteration; }
            set { nowIteration = value; }
        }

        #endregion

        #region MainMethods

        public void Initialize(uint userObstacle, uint userPrey, uint userPredator, uint userIteration)
        {
            numRows = Constant.maxRows;
            numCols = Constant.maxCols;
            cells = new Cell[NumRows, NumCols];

            InitCells(userObstacle, userPrey, userPredator, userIteration);
        }

        public void Run()
        {
            nowIteration++;

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
                    cells[row, column].WasProcessed = false;
                }
            }

        }
        #endregion

        #region Methods

        private void InitCells(uint userObstacle, uint userPrey, uint userPredator, uint userIteration)
        {

            numObstacle = userObstacle;
            numPrey = userPrey;
            numPredator = userPredator;
            numIteration = userIteration;

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
