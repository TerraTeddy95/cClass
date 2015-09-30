using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using TShockAPI;
using TerrariaApi.Server;

namespace cClass.Events
{
    class OnJoin
    {
        public static void run(JoinEventArgs e)
        {
            if (!(Variables.playersData.ContainsKey(TShock.Players[e.Who].Name)))
            {
                Variables.playersData.Add(TShock.Players[e.Who].Name, new Variables.informations { ActualClass = Variables.startClass });
            }
        }
    }
}
