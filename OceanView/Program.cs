using OceanLibrary;
using System;
using System.Threading;

namespace OceanView
{
    class Program
    {
        static void Main(string[] args)
        {
            IOceanDisplay elementsDisplay = new DisplayOcean();
            IOceanUI elementsUI = new DisplayOcean();

            Ocean myOcean = new Ocean();

            elementsUI.SetValue();
            myOcean.Initialize(elementsUI.UserNumObstacles, elementsUI.UserNumPrey,
                    elementsUI.UserNumPredator, elementsUI.UserNumRimuruFish, elementsUI.UserNumIteration);

            Console.CursorVisible = false;

            for (int i = 0; i < elementsUI.UserNumIteration; i++)
            {
                if (myOcean.NumPrey != 0 && myOcean.NumPredator != 0)
                {
                    myOcean.Run();
                    elementsDisplay.CountInfo(myOcean);
                    elementsDisplay.Display(i+1, myOcean);
                    Thread.Sleep(Constant.interval);
                }
                elementsUI.EndModeling(i+1, myOcean);
            }
             
        }
    }
}

