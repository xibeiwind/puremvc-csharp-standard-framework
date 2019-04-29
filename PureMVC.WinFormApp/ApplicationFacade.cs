using PureMVC.Patterns.Facade;

namespace PureMVC.WinFormApp
{
    public class ApplicationFacade : Facade
    {
        public void Startup()
        {
            SendNotification("Startup");
        }
    }
}