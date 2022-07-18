using OceanLibrary;

namespace OceanView
{
    public interface IOceanDisplay
    {
        void Display(int iteration, Ocean displayOcean);
        void CountInfo(Ocean displayOcean);
    }
}
