using System.Windows.Forms;

namespace OceanLibrary
{
    public interface IOceanDisplay
    {
        void Display(int iteration, Ocean displayOcean, DataGridView dataGridView, Label prey,
            Label predator, Label obstacle, Label allIteration, ProgressBar nowIteration);

        void CountInfo(Ocean displayOcean);
    }
}
