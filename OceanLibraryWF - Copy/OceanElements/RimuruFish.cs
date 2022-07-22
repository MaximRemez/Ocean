namespace OceanLibrary
{
    public class RimuruFish : Cell
    {

        #region Constructor

        public RimuruFish(Coordinate anOffset, IOceanCells ocean) : base(anOffset, ocean)
        {
            Offset = anOffset;
            _myOcean = ocean;
            Image = Constant.defaultRimuruImage;
        }
        #endregion

        #region OverrideMethods

        public override void Process(IOceanCells ocean)
        {
            if (wasProcessed == false)
            {
                if (Offset != _myOcean.GetNeighborCell(Constant.defaultObstacleImage, Offset))
                {
                    MoveFrom(Offset, _myOcean.GetNeighborCell(Constant.defaultObstacleImage, Offset));
                }

                else if (Offset != _myOcean.GetNeighborCell(Constant.defaultPredatorImage, Offset))
                {
                    MoveFrom(Offset, _myOcean.GetNeighborCell(Constant.defaultPredatorImage, Offset));
                }

                else if (Offset != _myOcean.GetNeighborCell(Constant.defaultPreyImage, Offset))
                {
                    MoveFrom(Offset, _myOcean.GetNeighborCell(Constant.defaultPreyImage, Offset));
                }

                else
                {
                    MoveFrom(Offset, _myOcean.GetNeighborCell(Constant.defaultCellImage, Offset));
                }

                wasProcessed = true;
            }
        }

        #endregion

        #region Methods

        protected virtual void MoveFrom(Coordinate from, Coordinate to)
        {

            if (to != from)
            {
                Offset = to;
                _myOcean.AssignCellAt(to, this);
                _myOcean.AssignCellAt(from, new Cell(from, _myOcean));
            }
        }
        #endregion


    }
}
