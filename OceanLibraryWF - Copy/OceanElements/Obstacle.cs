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

        public Obstacle(Coordinate anOffset, IOceanCells ocean, int timeToPunch) : base(anOffset, ocean)
        {
            Offset = anOffset;
            _myOcean = ocean;
            TimeToPunch = timeToPunch;

            Image = Constant.defaultObstacleImage;
        }
        #endregion

        #region Methods

        public override void Process(IOceanCells ocean)
        {
            if (wasProcessed == false)
            {
                PunchNeighbor();
                wasProcessed = true;
            }
        }

        private void PunchNeighbor()
        {
            Coordinate temp;
            char tempImage;
            if (_myOcean.NowIteration != _lastNumOfIteration)
            {
                TimeToPunch--;

                _lastNumOfIteration = _myOcean.NowIteration;
            }

            if (TimeToPunch == 0)
            {
                temp = directions.GetNorthCell(Offset, (Ocean)_myOcean).Offset;
                tempImage = directions.GetNorthCell(Offset, (Ocean)_myOcean).Image;
                if (tempImage != Constant.defaultDragonImage && tempImage != Constant.defaultObstacleImage && tempImage != Constant.defaultFireImage)
                {
                    _myOcean.AssignCellAt(temp, new Tentacle(temp, _myOcean, Constant.defaultTentacleLife));
                }
              
                temp = directions.GetSouthCell(Offset, (Ocean)_myOcean).Offset;
                tempImage = directions.GetSouthCell(Offset, (Ocean)_myOcean).Image;
                if (tempImage != Constant.defaultDragonImage && tempImage != Constant.defaultObstacleImage && tempImage != Constant.defaultFireImage)
                {
                    _myOcean.AssignCellAt(temp, new Tentacle(temp, _myOcean, Constant.defaultTentacleLife));
                }

                temp = directions.GetWestCell(Offset, (Ocean)_myOcean).Offset;
                tempImage = directions.GetWestCell(Offset, (Ocean)_myOcean).Image;
                if (tempImage != Constant.defaultDragonImage && tempImage != Constant.defaultObstacleImage && tempImage != Constant.defaultFireImage)
                {
                    _myOcean.AssignCellAt(temp, new Tentacle(temp, _myOcean, Constant.defaultTentacleLife));
                }

                temp = directions.GetEastCell(Offset, (Ocean)_myOcean).Offset;
                tempImage = directions.GetEastCell(Offset, (Ocean)_myOcean).Image;
                if (tempImage != Constant.defaultDragonImage && tempImage != Constant.defaultObstacleImage && tempImage != Constant.defaultFireImage)
                {
                    _myOcean.AssignCellAt(temp, new Tentacle(temp, _myOcean, Constant.defaultTentacleLife));
                }

                TimeToPunch = Constant.defaultTimeToPunch;
            }

        }
        #endregion

    }
}
