namespace Topshelf.Specs.Configuration
{
    public interface IHost
    {
        void Start();
        void Stop();
        void Pause();
        void Continue();

        void StartService(string name);
        void StopService(string name);
        void PauseService(string name);
        void ContinueService(string name);

        //void Install();
        //void Uninstall();
    }
}