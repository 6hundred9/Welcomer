using Exiled.Events.EventArgs.Player;
using PluginAPI.Events;

namespace Welcomer
{
    public class PlayerHandler
    {
        public static void PlayerJoined(JoinedEventArgs ev)
        {
            ev.Player.Broadcast(Plugin.instance.Config.Duration, Plugin.instance.Config.PlayerWelcome);
        }
    }
}