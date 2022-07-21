namespace OceanLibrary
{
    class Predator : Prey
    {
        #region Variables

        private uint _lastNumOfIteration;

        private int _neededTimeToFeed = Constant.defaultTimeToFeed;
        private int _timeToFeed = Constant.defaultTimeToFeed;

        public int TimeToFeed
        {
            get
            {
                return _timeToFeed;
            }
            set
            {
                _timeToFeed = value;
            }
        }
        #endregion

        #region Constructor

        public Predator(Coordinate anOffset, IOceanCells ocean, int timeToBreed, int timeToDeath) : base(anOffset, ocean, timeToBreed)
        {
            _neededTimeToFeed = timeToDeath;
            TimeToFeed = _neededTimeToFeed;

            Image = Constant.defaultPredatorImage;
        }
        #endregion

        #region OverrideMethods

        public override void Process(IOceanCells ocean)
        {
            if (wasProcessed == false)
            {

                if (_myOcean.NowIteration != _lastNumOfIteration)
                {
                    TimeToFeed--;

                    _lastNumOfIteration = _myOcean.NowIteration;
                }

                Coordinate toCoord;
                toCoord = _myOcean.GetNeighborCell(Constant.defaultPreyImage, Offset);

                if (TimeToFeed <= 0)
                {
                    _myOcean.AssignCellAt(Offset, new Cell(Offset, _myOcean));
                }

                else
                {

                    if (toCoord != Offset)
                    {
                        MoveFrom(Offset, toCoord);

                        TimeToFeed = _neededTimeToFeed;
                    }

                    else
                    {
                        base.Process(_myOcean);
                    }

                }

                wasProcessed = true;
            }
        }

        public override Cell Reproduce(Coordinate anOffset, IOceanCells ocean)
        {
            return new Predator(anOffset, _myOcean, _neededTimeToReproduce, _neededTimeToFeed);
        }
        #endregion

    }
}
