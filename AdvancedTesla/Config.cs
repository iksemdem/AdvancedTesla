using Exiled.API.Interfaces;
using System.ComponentModel;

namespace AdvancedTesla
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        [Description("Indicates wheter cassie should inform about Class D dying on tesla gate.")]
        public bool IsClassDCassieEnabled { get; set; } = true;
        [Description("The content of the cassie message after Class D dies on tesla gate. (Use {TeamMembersAlive} to get the number of reamining team members of the dying player)")]
        public string ClassDCassieContent { get; set; } = "classd personnel successfully terminated by automatic security system . awaitingrecontainment {TeamMembersAlive} class d personnel";
        [Description("The content of the text message after Class D dies on tesla gate.")]
        public string ClassDCassieText { get; set; } = "Class D personnel successfully terminated by Automatic Serucity System. Awaiting recontainment of {TeamMembersAlive} class d personnel";
        [Description("Indicates wheter cassie should inform about Class D dying on tesla gate.")]

        public bool IsChaosInsurgencyCassieEnabled { get; set; } = true;
        [Description("The content of the cassie message after Chaos Insurgency dies on tesla gate.")]
        public string ChaosInsurgencyCassieContent { get; set; } = "chaosinsurgency agent successfully terminated by automatic security system . awaitingrecontainment {TeamMembersAlive} chaosinsurgency agents";
        [Description("The content of the text message after Chaos Insurgency dies on tesla gate.")]
        public string ChaosInsurgencyCassieText { get; set; } = "Chaos Insurgency agent successfully terminated by Automatic Security System. Awaiting recontainment of {TeamMembersAlive} Chaos Insurgency agents";
    }
}
