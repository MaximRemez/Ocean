namespace OceanLibrary
{
    class Predator : Prey
    {
        #region Variables

        private uint lastNumOfIteration;

        private int neededTimeToFeed = Constant.defaultTimeToFeed;
        private int timeToFeed = Constant.defaultTimeToFeed;

        public int TimeToFeed
        {
            get
            {
                return timeToFeed;
            }
            set
            {
                timeToFeed = value;
            }
        }
        #endregion

        #region Constructor

        public Predator(Coordinate anOffset, IOceanCells ocean, int timeToBreed, int timeToDeath) : base(anOffset, ocean, timeToBreed)
        {
            neededTimeToFeed = timeToDeath;
            TimeToFeed = neededTimeToFeed;

            Image = Constant.defaultPredatorImage;
        }
        #endregion

        #region OverrideMethods

        public override void Process(IOceanCells ocean)
        {
            if (WasProcessed == false)
            {

                if (MyOcean.NowIteration != lastNumOfIteration)
                {
                    TimeToFeed--;

                    lastNumOfIteration = MyOcean.NowIteration;
                }

                Coordinate toCoord;
                toCoord = MyOcean.GetNeighborCell(Constant.defaultPreyImage, Offset);

                if (TimeToFeed <= 0)
                {
                    MyOcean.AssignCellAt(Offset, new Cell(Offset, MyOcean));
                }

                else
                {

                    if (toCoord != Offset)
                    {
                        MoveFrom(Offset, toCoord);

                        TimeToFeed = neededTimeToFeed;
                    }

                    else
                    {
                        base.Process(MyOcean);
                    }

                }

                WasProcessed = true;
            }
        }

        public override Cell Reproduce(Coordinate anOffset, IOceanCells ocean)
        {
            return new Predator(anOffset, MyOcean, neededTimeToReproduce, neededTimeToFeed);
        }
        #endregion

    }
}
