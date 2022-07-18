namespace OceanLibrary
{
    public interface IOceanCells
    {
        uint NumIteration { get; set; }
        uint NumObstacle { get; set; }
        uint NumPrey { get; set; }
        uint NumPredator { get; set; }
        int NumRows { get; set; }
        int NumCols { get; set; }
        uint NowIteration { get; set; }

        Cell GetCellAt(Coordinate aCoord);
        void AssignCellAt(Coordinate aCoord, Cell cell);
        Coordinate GetNeighborCell(char anImage, Coordinate anOffset);      
    }
}
