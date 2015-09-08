using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using TShockAPI;
using TerrariaApi.Server;
using Newtonsoft.Json;
using System.IO;

namespace cClass
{
    public class onJoin
    {
        public static void start(JoinEventArgs e)
        {

            TSPlayer p = TShock.Players[e.Who];
            int index = vars.warrior.FindIndex(w => w.player == p.Name);
            if (index == -1)
            {
                vars.warrior.Add(new vars.Warrior { player = p.Name });
                vars.paladin.Add(new vars.Paladin { player = p.Name });
                vars.wizard.Add(new vars.Wizard { player = p.Name });
                vars.informations.Add(new vars.playerInformation { actualClass = "warrior" });
            }
            return;
        }
    }
}
