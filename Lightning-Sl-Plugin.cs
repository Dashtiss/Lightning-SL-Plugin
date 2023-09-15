using Exiled.API;
using Exiled.API.Features;
using Exiled.Events.Handlers;
namespace Lightning_SL_Plugin
{
    public class Plugin : Plugin<Config>
    {
        private bool Experimental = true;
        public override string Name => "Lightning-SL-Plugin";
        public override string Author => "Dashtiss, Lightning-MC";
        public override Version Version => new Version(1, 0, 0);
        public override void OnEnabled()
        {
            Log.Warn("Lightning-sl-Plugin is empty");
            if (Experimental)
            {
                Log.Warn("This is an experimental Version of Lightning-Sl Plugin");
            }
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            base.OnDisabled();
        }

    }
}