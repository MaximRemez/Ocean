namespace OceanLibrary
{
    public class Tentacle : Cell
    {
        #region Variables

        private uint _lastNumOfIteration;
        private int _timeToLife = Constant.defaultTentacleLife;
        #endregion

        #region Properties

        public int TimeToLife
        {
            get
            {
                return _timeToLife;
            }
            protected set
            {
                _timeToLife = value;
            }
        }
        #endregion

        #region Constructor

        public Tentacle(Coordinate anOffset, IOceanCells ocean, int timeToLife) : base(anOffset, ocean)
        {
            Offset = anOffset;
            _myOcean = ocean;
            _timeToLife = timeToLife;
            wasProcessed = true;

            Image = Constant.defaultTentacleImage;
        }
        #endregion

        #region OverrideMethod
       
        public override void Process(IOceanCells ocean)
        {
            if (wasProcessed == false)
            {
                if (_myOcean.NowIteration != _lastNumOfIteration)
                {
                    _timeToLife--;

                    _lastNumOfIteration = _myOcean.NowIteration;
                }

                if (_timeToLife == 0)
                { 
                    _myOcean.AssignCellAt(Offset, new Cell(Offset, _myOcean)); 
                }
               
                wasProcessed = true;
            }
    
        }
        #endregion

    }
}
