using System;
using Exiled.API.Features;

namespace AdvancedTesla
{
    internal class Plugin : Plugin<Config>
    {
        private EventHandlers eventHandlers;

        public override string Author => "iksemdem";
        public override string Name => "AdvancedTesla";
        public override string Prefix => "advanced_tesla";
        public override Version Version => new Version(1, 2, 0);
        public static Plugin Instance { get; private set; }

        public override void OnEnabled()
        {
            Instance = this;
            eventHandlers = new EventHandlers();
            RegisterEvents();

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Instance = null;
            UnRegisterEvents();

            base.OnDisabled();
        }

        private void RegisterEvents()
        {
            Exiled.Events.Handlers.Player.Died += eventHandlers.OnDead;
            Exiled.Events.Handlers.Player.TriggeringTesla += eventHandlers.TriggeringTesla;
        }

        private void UnRegisterEvents()
        {
            Exiled.Events.Handlers.Player.Died -= eventHandlers.OnDead;
            Exiled.Events.Handlers.Player.TriggeringTesla -= eventHandlers.TriggeringTesla;
        }
    }
}
