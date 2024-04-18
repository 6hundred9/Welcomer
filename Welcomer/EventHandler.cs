using Exiled.Events.EventArgs.Player;
using Exiled.Events.Handlers;

namespace Welcomer
{
    public class EventHandler
    {
        public EventHandler() { Player.Joined += PlayerJoined; }
        ~EventHandler() { Player.Joined -= PlayerJoined; }

        public void PlayerJoined(JoinedEventArgs ev)
        {
            Config config = Plugin.Instance.Config;

            string welcomeMessage = config.WelcomeMessage;
            ushort welcomeDuration = config.WelcomeDuration;

            welcomeMessage = welcomeMessage.Replace("{player}", ev.Player.Nickname);

            ev.Player.Broadcast(welcomeDuration, welcomeMessage);
        }
    }
}