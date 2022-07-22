namespace OceanLibrary
{
    class Obstacle : Cell
    {
        #region Variables

        CardinalDirections directions = new CardinalDirections();
      
        private uint _lastNumOfIteration;
        private int _timeToPunch = Constant.defaultTimeToPunch;

        public int TimeToPunch
        {
            get
            {
                return _timeToPunch;
            }
            protected set
            {
                _timeToPunch = value;
            }
        }
        #endregion

        #region Constructor

        public Obstacle(Coordinate anOffset, IOceanCells ocean, int timeToFire) : base(anOffset, ocean)
        {
            Offset = anOffset;
            _myOcean = ocean;
            TimeToPunch = timeToFire;

            Image = Constant.defaultObstacleImage;
        }
        #endregion

        #region Methods

        public override void Process(IOceanCells ocean)
        {
            if (wasProcessed == false)
            {
                FireNeighbor();
                wasProcessed = true;
            }
        }

        private void FireNeighbor()
        {
            Coordinate temp;
            if (_myOcean.NowIteration != _lastNumOfIteration)
            {
                TimeToPunch--;

                _lastNumOfIteration = _myOcean.NowIteration;
            }

            if (TimeToPunch == 0)
            {
                temp = directions.GetNorthCell(Offset, (Ocean)_myOcean).Offset;
                _myOcean.AssignCellAt(temp, new Tentacle(temp, _myOcean, Constant.defaultTentacleLife));

                temp = directions.GetSouthCell(Offset, (Ocean)_myOcean).Offset;
                _myOcean.AssignCellAt(temp, new Tentacle(temp, _myOcean, Constant.defaultTentacleLife));

                temp = directions.GetWestCell(Offset, (Ocean)_myOcean).Offset;
                _myOcean.AssignCellAt(temp, new Tentacle(temp, _myOcean, Constant.defaultTentacleLife));

                temp = directions.GetEastCell(Offset, (Ocean)_myOcean).Offset;
                _myOcean.AssignCellAt(temp, new Tentacle(temp, _myOcean, Constant.defaultTentacleLife));

                TimeToPunch = Constant.defaultTimeToPunch;
            }

        }
        #endregion

    }
}
