using Exiled.API.Features;

namespace Welcomer
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin instance;
        public override void OnEnabled()
        {
            instance = this;
            Exiled.Events.Handlers.Player.Joined += PlayerHandler.PlayerJoined;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Joined -= PlayerHandler.PlayerJoined;
            base.OnDisabled();
        }
    }
}