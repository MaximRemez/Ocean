namespace OceanLibrary.OceanElements
{
    class Dragon : Cell
    {
        #region Variables

        readonly Randomizer randomizer= new Randomizer();

        private uint _lastNumOfIteration;
        private int _timeToFire = Constant.defaultTimeToFire;

        public int TimeToFire
        {
            get
            {
                return _timeToFire;
            }
            protected set
            {
                _timeToFire = value;
            }
        }
        #endregion

        #region Constructor

        public Dragon(Coordinate anOffset, IOceanCells ocean, int timeToFire) : base(anOffset, ocean)
        {
            Offset = anOffset;
            _myOcean = ocean;
            TimeToFire = timeToFire;

            Image = Constant.defaultDragonImage;
        }
        #endregion

        #region Methods

        public override void Process(IOceanCells ocean)
        {
            if (wasProcessed == false)
            {
                FireLine();
                wasProcessed = true;
            }
        }

        private void FireLine()
        {
            if (_myOcean.NowIteration != _lastNumOfIteration)
            {
                TimeToFire--;

                _lastNumOfIteration = _myOcean.NowIteration;
            }

            if (TimeToFire == 0)
            {
                Coordinate temp;

                int rows;
                rows = randomizer.RandNum(_myOcean.NumRows);

                for (int cols = 1; cols < _myOcean.NumCols; cols++)
                {
                    temp = new Coordinate(cols, rows);
                    _myOcean.AssignCellAt(temp, new DragonFire(temp, _myOcean, Constant.defaultFireLife));
                }
            
                TimeToFire = Constant.defaultTimeToFire;
            }

        }
        #endregion
    }
}
