namespace OceanLibrary
{
    public class Cell
    {
        #region Variables

        protected IOceanCells _myOcean;

        public Coordinate Offset { get; protected set; }

        public bool wasProcessed = false;

        private char _image = Constant.defaultCellChar;
        public char Image
        {
            get { return _image; }
            set { _image = value; }
        }

        #endregion

        #region Constructor

        public Cell(Coordinate anOffset, IOceanCells ocean)
        {
            Offset = anOffset;
            _myOcean = ocean;
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
