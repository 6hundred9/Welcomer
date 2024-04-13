using Exiled.API.Interfaces;

namespace Welcomer
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        public string PlayerWelcome { get; set; } = "Welcome to the server";
        public ushort Duration { get; set; } = 5;
    }
}