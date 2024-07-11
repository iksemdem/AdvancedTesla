using Exiled.Events.EventArgs.Player;
using Exiled.API.Features;
using PlayerRoles;
using System.Linq;

namespace AdvancedTesla
{
    internal class EventHandlers
    {
        internal void OnDead(DiedEventArgs ev)
        {
            Log.Debug("Player died");
            if (ev.DamageHandler.Type is Exiled.API.Enums.DamageType.Tesla)
            {
                Log.Debug("Player died on tesla");
                if (ev.TargetOldRole is RoleTypeId.ClassD)
                {
                    var messageClassD = ReplacePlaceholders(Plugin.Instance.Config.ClassDCassieContent, "ClassD");
                    var textClassD = ReplacePlaceholders(Plugin.Instance.Config.ClassDCassieText, "ClassD");

                    Cassie.MessageTranslated($"{messageClassD}", $"{textClassD}.", false, false, true);
                    Log.Debug("Class D died on tesla");
                }
                else if (ev.TargetOldRole.GetTeam() is Team.ChaosInsurgency)
                {
                    var messageChaosInsurgency = ReplacePlaceholders(Plugin.Instance.Config.ChaosInsurgencyCassieContent, "ChaosInsurgency");
                    var textChaosInsurgency = ReplacePlaceholders(Plugin.Instance.Config.ChaosInsurgencyCassieText, "ChaosInsurgency");

                    Cassie.MessageTranslated($"{messageChaosInsurgency}", $"{textChaosInsurgency}", false, false, true);
                    Log.Debug("CI died on tesla");
                }
            }
        }

        internal void TriggeringTesla(TriggeringTeslaEventArgs ev) 
        {
            if (ev.Player.Role.Side is Exiled.API.Enums.Side.Mtf)
            {
                ev.IsAllowed = false;
            }
        }

        private string ReplacePlaceholders(string template, string team)
        {
            if(team is "ClassD")
            {
                string teamMembersAlive = Player.Get(RoleTypeId.ClassD).Count().ToString();
                Log.Info("classD died");
                return template.Replace("{TeamMembersAlive}", teamMembersAlive);
            } else if (team is "ChaosInsurgency")
            {
                string teamMembersAlive = Player.Get(Team.ChaosInsurgency).Count().ToString();
                Log.Info("chaos died");
                return template.Replace("{TeamMembersAlive}", teamMembersAlive);
            }
            Log.Info("someone else died");
            return template.Replace("{TeamMembersAlive}", "Unknown team");
        }
    }
}
