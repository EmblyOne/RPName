using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qurre.API;
using Qurre.API.Addons;

namespace RPName
{
    public class Config : IConfig
    {
        public string Name { get; set; } = "RPName"; 

        [Description("is rpname enabled?")]
        public bool Enabled { get; set; } = true;

        [Description("The dictionary with titles of classes")]
        public Dictionary<RoleType, string> classtitles { get; set; } = new Dictionary<RoleType, string>
        {
            {
              RoleType.ClassD, "D-"
            },
            {
                RoleType.Scp049, "SCP-049"
            },
            {
                RoleType.Scp079, "SCP-079"
            },
            {
                RoleType.Scp173, "SCP-173"
            },
            {
                RoleType.Scp106, "SCP-106"
            },
            {
                RoleType.Scp93953, "SCP-939-53"
            },
            {
                RoleType.Scp93989, "SCP-939-89"
            },
            {
                RoleType.Scp096, "SCP-096"
            },
            {
                RoleType.Scp0492, "SCP-049-2"
            },
            {
                RoleType.Scientist, "Dr."
            },
            {
                RoleType.FacilityGuard, "Officer of Security \n"
            },
            {
                RoleType.NtfCaptain, "Captain of MTF \n"
            },
            {
                RoleType.NtfSergeant, "Lieutenant of MTF \n"
            },
            {
                RoleType.NtfPrivate, "Cadet of MTF \n"
            },
            {
                RoleType.NtfSpecialist, "Specialist of NTF \n"
            },
            {
                RoleType.ChaosConscript, "Chaos Agent \n"
            },
            {
                RoleType.ChaosRifleman, "Chaos Rifleman \n"
            },
            {
                RoleType.ChaosRepressor, "Chaos Repressor \n"
            },
            {
                RoleType.ChaosMarauder, "Chaos Marauder \n"
            },

       };
        [Description("On death the names will become default.(true - if you want to enable, false - if you want to disable)")]
        public bool resetondeath { get; set; } = false;
        [Description("The names of tutorial and spectator will become default (true - if you want to enable, false - if you want to disable)")]
        public bool tutorialreset { get; set; } = true; 
        [Description("Names of people that will show(you can clear it and write your names)")]
        public List<string> names { get; set; }  = new List<string>() { "Michael", "Billy", "Alex", "Hood", "Crisper", "Noland", "Stewen", "Richard", "Neil", "James", "Jason", "Kevin", "Edward", "Marco", "Robert", "Willie", "Charis", "Tonny", "Anderson", "Josue", "Brian", "Oliver", "Jackson", "Darwin", "Kelvin", "Seven", "Shepard", "Azrael", "Leroy", "Mordechai", "Cal", "Franco", "Trent", "Blaise", "Coen", "Dominik", "Marley", "Davion", "Jeremias", "Jones", "Will", "Damir", "Dangelo", "Canaan", "Dion", "Landry", "Kody", "Gordon", "Colter", "Dayton", "Jad", "Rene", "Vance", "Duncan", "Frankie", "Jaxen", "Kyle", "Turner" };
    }
}
