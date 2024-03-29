﻿namespace OceanLibrary
{
    public interface IOceanUI
    {
        void SetValue();
        void EndModeling(int iteration, Ocean endOcean);

        uint UserNumObstacles { get; set; }
        uint UserNumPrey { get; set; }
        uint UserNumPredator { get; set; }
        uint UserNumIteration { get; set; }
        uint UserNumRimuruFish { get; set; }
    }
}
