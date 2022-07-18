namespace OceanLibrary
{
    class Prey : Cell
    {
        #region Variables

        private uint lastNumOfIteration;

        protected int neededTimeToReproduce = Constant.defaultTimeToReproduce;
        private int timeToReproduce = Constant.defaultTimeToReproduce;

        public int TimeToReproduce
        {
            get
            {
                return timeToReproduce;
            }
            protected set
            {
                timeToReproduce = value;
            }
        }
        #endregion

        #region Constructor

        public Prey(Coordinate anOffset, IOceanCells ocean, int timeToDivision) : base(anOffset, ocean)
        {
            Offset = anOffset;
            MyOcean = ocean;
            TimeToReproduce = timeToDivision;
            Image = Constant.defaultPreyImage;
        }
        #endregion

        #region OverrideMethods

        public override void Process(IOceanCells ocean)
        {
            if (WasProcessed == false)
            {
                MoveFrom(Offset, MyOcean.GetNeighborCell(Constant.defaultCellChar, Offset));
                WasProcessed = true;
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
            if (MyOcean.NowIteration != lastNumOfIteration)
            {
                TimeToReproduce--;

                lastNumOfIteration = MyOcean.NowIteration;
            }

            if (to != from)
            {
                Offset = to;
                MyOcean.AssignCellAt(to, this);

                if (TimeToReproduce <= 0)
                {
                    MyOcean.AssignCellAt(from, Reproduce(from, MyOcean));

                    TimeToReproduce = Constant.defaultTimeToReproduce;
                }

                else
                {
                    MyOcean.AssignCellAt(from, new Cell(from, MyOcean));
                }

            }
        }
        #endregion

    }
}
