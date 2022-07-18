namespace OceanLibrary
{
    public interface IOceanUI
    {
        void SetValue();
        void EndModeling(int iteration, Ocean endOcean);
        int EnterCountOcean();

        uint UserNumObstacles { get; set; }
        uint UserNumPrey { get; set; }
        uint UserNumPredator { get; set; }
        uint UserNumIteration { get; set; }
    }
}
