using Exiled.API.Features;
using System;

namespace Welcomer
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "Welcomer";
        public override string Prefix => "welcomer";
        public override string Author => "6hundred9, gooseo";
        public override Version RequiredExiledVersion => new Version(8, 8, 0);
        public override Version Version => new Version(1,1,0);
        public override bool IgnoreRequiredVersionCheck => true;

        public static Plugin Instance;

        private protected EventHandler eventHandler;

        public override void OnEnabled()
        {
            Instance = this;
            eventHandler = new EventHandler();
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            eventHandler = null;
            Instance = null;
            base.OnDisabled();
        }
    }
}