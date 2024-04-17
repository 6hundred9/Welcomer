using Exiled.API.Interfaces;

namespace Welcomer
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        public string WelcomeMessage { get; set; } = "Welcome to the server, {player}, enjoy!";
        public ushort WelcomeDuration { get; set; } = 5;
    }
}