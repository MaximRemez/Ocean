namespace OceanLibrary
{
    public class Cell
    {
        #region Variables

        protected IOceanCells MyOcean;

        public Coordinate Offset { get; protected set; }

        public bool WasProcessed = false;

        private char image = Constant.defaultCellChar;
        public char Image
        {
            get { return image; }
            set { image = value; }
        }

        #endregion

        #region Constructor

        public Cell(Coordinate anOffset, IOceanCells ocean)
        {
            Offset = anOffset;
            MyOcean = ocean;
        }
        #endregion

        #region Methods

        public virtual void Process(IOceanCells ocean)
        {

        }

        public virtual Cell Reproduce(Coordinate anOffset, IOceanCells ocean)
        {
            return this;
        }
        #endregion
    }
}
