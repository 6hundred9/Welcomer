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

            string welcomeMessage = config.WelcomeMessage.Replace("{player}", ev.Player.DisplayNickname);
            ushort welcomeDuration = config.WelcomeDuration;

            ev.Player.Broadcast(welcomeDuration, welcomeMessage);
        }
    }
}