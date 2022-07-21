namespace OceanLibrary.OceanException
{
    public delegate void ShowException(string message);

    public class OutputException
    {
        ShowException showMessage;

        public void RegisterException(ShowException del)
        {
            showMessage = del;
        }

        public void ShowOnScreen(string message)
        {
            showMessage?.Invoke(message);
        }
    }
}
