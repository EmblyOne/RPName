using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPName
{
    public class Plugin : Qurre.Plugin
    {
        public EventHandlers EventHandlers; 
        public override int Priority { get; } = -9999999;
        public override string Developer { get; } = "G-Man";
        public override string Name { get; } = "RPName";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version NeededQurreVersion { get; } = new Version(1, 11, 1);
        public static Config config = new RPName.Config(); 


        public override void Enable()
        {
            CustomConfigs.Add(config);
            EventHandlers = new EventHandlers(this);
            Qurre.Events.Player.RoleChange += EventHandlers.OnChangeRole;
            Qurre.Events.Player.Dead += EventHandlers.OnDeath;
        }
        public override void Disable()
        {
            Qurre.Events.Player.RoleChange -= EventHandlers.OnChangeRole;
            Qurre.Events.Player.Dead -= EventHandlers.OnDeath;
            EventHandlers = null; 
        }
        
    }
}
