using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qurre.API.Events;
using Qurre.API;  
namespace RPName
{
    public class EventHandlers
    {
     
        private readonly Plugin plugin;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;
        public void OnChangeRole(RoleChangeEvent ev)
        {
            Random rand = new Random();
            if (ev.NewRole.GetTeam() == Team.SCP && Plugin.config.classtitles.ContainsKey(ev.NewRole))
            {
                ev.Player.DisplayNickname = Plugin.config.classtitles[ev.NewRole];
            }
            if (ev.NewRole.GetTeam() != Team.SCP && Plugin.config.classtitles.ContainsKey(ev.NewRole))
            {
             
                int randomname = rand.Next(1, Plugin.config.names.Count - 1);
                ev.Player.DisplayNickname = Plugin.config.classtitles[ev.NewRole] + Plugin.config.names[(randomname)];
                if (ev.NewRole == RoleType.ClassD)
                {
                    int dclassnumb = rand.Next(1000, 9999);
                    ev.Player.DisplayNickname = Plugin.config.classtitles[ev.NewRole] + dclassnumb.ToString();
                }
                
            } 
            if(ev.NewRole.GetTeam() == Team.CHI && Plugin.config.classtitles.ContainsKey(ev.NewRole))
            {
                int chaosrandom = rand.Next(1, Plugin.config.chaosnames.Count - 1); 
                ev.Player.DisplayNickname = $"{Plugin.config.classtitles[ev.NewRole]} || {Plugin.config.chaosnames[chaosrandom]}"; 
            } 
            if(ev.NewRole.GetTeam() == Team.MTF && Plugin.config.classtitles.ContainsKey(ev.NewRole))
            {

                int mtfnamesrandom = rand.Next(1, Plugin.config.mtfnames.Count - 1);
                ev.Player.DisplayNickname = $"{Plugin.config.classtitles[ev.NewRole]} || {Plugin.config.mtfnames[(mtfnamesrandom)]}";
            } 
            if(ev.NewRole == RoleType.Tutorial || ev.NewRole ==  RoleType.Spectator)
            {
                if(Plugin.config.tutorialreset)
                {
                    ev.Player.DisplayNickname = null; 
                }
            }

        } 
        public void OnDeath(DeadEvent ev)
        {
            if (Plugin.config.resetondeath)
            {
                ev.Target.DisplayNickname = null;
            }
        }
    }
}
