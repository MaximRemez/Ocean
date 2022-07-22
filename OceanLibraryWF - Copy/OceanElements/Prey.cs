namespace OceanLibrary
{
    class Prey : Cell
    {
        #region Variables

        private uint _lastNumOfIteration;

        protected int _neededTimeToReproduce = Constant.defaultTimeToReproduce;
        private int _timeToReproduce = Constant.defaultTimeToReproduce;

        public int TimeToReproduce
        {
            get
            {
                return _timeToReproduce;
            }
            protected set
            {
                _timeToReproduce = value;
            }
        }
        #endregion

        #region Constructor

        public Prey(Coordinate anOffset, IOceanCells ocean, int timeToDivision) : base(anOffset, ocean)
        {
            Offset = anOffset;
            _myOcean = ocean;
            TimeToReproduce = timeToDivision;
            Image = Constant.defaultPreyImage;
        }
        #endregion

        #region OverrideMethods

        public override void Process(IOceanCells ocean)
        {
            if (wasProcessed == false)
            {
                MoveFrom(Offset, _myOcean.GetNeighborCell(Constant.defaultCellImage, Offset));
                wasProcessed = true;
            }
        }

        public override Cell Reproduce(Coordinate anOffset, IOceanCells ocean)
        {
            return new Prey(anOffset, ocean, Constant.defaultTimeToReproduce);
        }
        #endregion

        #region Methods

        protected virtual void MoveFrom(Coordinate from, Coordinate to)
        {
            if (_myOcean.NowIteration != _lastNumOfIteration)
            {
                TimeToReproduce--;

                _lastNumOfIteration = _myOcean.NowIteration;
            }

            if (to != from)
            {
                Offset = to;
                _myOcean.AssignCellAt(to, this);

                if (TimeToReproduce <= 0)
                {
                    _myOcean.AssignCellAt(from, Reproduce(from, _myOcean));

                    TimeToReproduce = Constant.defaultTimeToReproduce;
                }

                else
                {
                    _myOcean.AssignCellAt(from, new Cell(from, _myOcean));
                }

            }
        }
        #endregion

    }
}
