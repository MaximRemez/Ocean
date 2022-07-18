using System;

namespace OceanLibrary
{
    public class Randomizer
    {
        readonly Random random = new Random((int)DateTime.Now.Ticks);
        public int randNum;

        public int RandNum(int maxValue)
        {
            randNum = random.Next(0, maxValue);

            return randNum;
        }
    }
}
