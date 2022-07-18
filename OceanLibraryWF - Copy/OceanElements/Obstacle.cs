namespace OceanLibrary
{
    class Obstacle : Cell
    {
        #region Constructor

        public Obstacle(Coordinate anOffset, IOceanCells ocean) : base(anOffset, ocean)
        {
            Offset = anOffset;
            MyOcean = ocean;

            Image = Constant.defaultObstacleImage;
        }
        #endregion

    }
}
