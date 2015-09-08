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
    class inventory
    {
        public static void clearInventory(TSPlayer p)
        {
            int currentLoop = 0;
            while (currentLoop < 59)
            {
                p.TPlayer.inventory[currentLoop].SetDefaults(0);
                NetMessage.SendData(5, -1, -1, "", p.Index, (float)currentLoop, 0f, 0f, 0);
                currentLoop++;
            }
        }

        public static bool saveEquipment(int index, string classe)
        {

            string pName = vars.warrior[index].player;

            foreach (TSPlayer n in TShock.Players)
            {
                if (n.Name == pName)
                {

                    if (classe == "warrior")
                    {
                        TSPlayer p = n;
                        if (vars.warrior[index].itemsArmorNetID.Count > 0)
                        {
                            vars.warrior[index].itemsArmorNetID.Clear();
                            vars.warrior[index].itemsArmorPrefix.Clear();
                            vars.warrior[index].itemsArmorStack.Clear();
                            vars.warrior[index].itemsBarName.Clear();
                        }

                        int currentLoop = 0;
                        foreach (Item i in p.TPlayer.armor)
                        {
                            vars.warrior[index].itemsArmorName.Add(i.name);
                            vars.warrior[index].itemsArmorNetID.Add(i.netID);
                            vars.warrior[index].itemsArmorPrefix.Add(i.prefix);
                            vars.warrior[index].itemsArmorStack.Add(i.stack);
                            currentLoop++;
                            if (currentLoop == 9)
                            {
                                return true;
                            }
                        }
                    }
                    if (classe == "paladin")
                    {
                        TSPlayer p = n;
                        if (vars.paladin[index].itemsArmorNetID.Count > 0)
                        {
                            vars.paladin[index].itemsArmorNetID.Clear();
                            vars.paladin[index].itemsArmorPrefix.Clear();
                            vars.paladin[index].itemsArmorStack.Clear();
                            vars.paladin[index].itemsBarName.Clear();
                        }

                        int currentLoop = 0;
                        foreach (Item i in p.TPlayer.armor)
                        {
                            vars.paladin[index].itemsArmorName.Add(i.name);
                            vars.paladin[index].itemsArmorNetID.Add(i.netID);
                            vars.paladin[index].itemsArmorPrefix.Add(i.prefix);
                            vars.paladin[index].itemsArmorStack.Add(i.stack);
                            currentLoop++;
                            if (currentLoop == 9)
                            {
                                return true;
                            }
                        }
                    }
                    if (classe == "wizard")
                    {
                        TSPlayer p = n;
                        if (vars.wizard[index].itemsArmorNetID.Count > 0)
                        {
                            vars.wizard[index].itemsArmorNetID.Clear();
                            vars.wizard[index].itemsArmorPrefix.Clear();
                            vars.wizard[index].itemsArmorStack.Clear();
                            vars.wizard[index].itemsBarName.Clear();
                        }

                        int currentLoop = 0;
                        foreach (Item i in p.TPlayer.armor)
                        {
                            vars.wizard[index].itemsArmorName.Add(i.name);
                            vars.wizard[index].itemsArmorNetID.Add(i.netID);
                            vars.wizard[index].itemsArmorPrefix.Add(i.prefix);
                            vars.wizard[index].itemsArmorStack.Add(i.stack);
                            currentLoop++;
                            if (currentLoop == 9)
                            {
                                return true;
                            }
                        }
                    }
                    return false;

                }
            }
            return false;
            
            
            







            return false;
        }
        public static bool saveBar(int index, string classe)
        {
            string pName = vars.warrior[index].player;

            foreach (TSPlayer n in TShock.Players)
            {
                if (n.Name == pName)
                {
                    TSPlayer p = n;
                    if (classe == "warrior")
                    {
                        int currentLoop = 0;
                        if (vars.warrior[index].itemsBarNetID.Count > 0)
                        {
                            vars.warrior[index].itemsBarNetID.Clear();
                            vars.warrior[index].itemsBarPrefix.Clear();
                            vars.warrior[index].itemsBarStack.Clear();
                            vars.warrior[index].itemsBarName.Clear();
                        }
                        foreach (Item i in p.TPlayer.inventory)
                        {

                            vars.warrior[index].itemsBarNetID.Add(i.netID);
                            vars.warrior[index].itemsBarPrefix.Add(i.prefix);
                            vars.warrior[index].itemsBarStack.Add(i.stack);
                            vars.warrior[index].itemsBarName.Add(i.name);

                            currentLoop++;
                            if (currentLoop == 10)
                            {
                                return true;
                            }
                        }
                    }
                    if (classe == "paladin")
                    {
                        int currentLoop = 0;
                        if (vars.paladin[index].itemsBarNetID.Count > 0)
                        {
                            vars.paladin[index].itemsBarNetID.Clear();
                            vars.paladin[index].itemsBarPrefix.Clear();
                            vars.paladin[index].itemsBarStack.Clear();
                            vars.paladin[index].itemsBarName.Clear();
                        }
                        foreach (Item i in p.TPlayer.inventory)
                        {

                            vars.paladin[index].itemsBarNetID.Add(i.netID);
                            vars.paladin[index].itemsBarPrefix.Add(i.prefix);
                            vars.paladin[index].itemsBarStack.Add(i.stack);
                            vars.paladin[index].itemsBarName.Add(i.name);

                            currentLoop++;
                            if (currentLoop == 10)
                            {
                                return true;
                            }
                        }
                    }
                    if (classe == "wizard")
                    {
                        int currentLoop = 0;
                        if (vars.wizard[index].itemsBarNetID.Count > 0)
                        {
                            vars.wizard[index].itemsBarNetID.Clear();
                            vars.wizard[index].itemsBarPrefix.Clear();
                            vars.wizard[index].itemsBarStack.Clear();
                            vars.wizard[index].itemsBarName.Clear();
                        }
                        foreach (Item i in p.TPlayer.inventory)
                        {

                            vars.wizard[index].itemsBarNetID.Add(i.netID);
                            vars.wizard[index].itemsBarPrefix.Add(i.prefix);
                            vars.wizard[index].itemsBarStack.Add(i.stack);
                            vars.wizard[index].itemsBarName.Add(i.name);

                            currentLoop++;
                            if (currentLoop == 10)
                            {
                                return true;
                            }
                        }
                    }
                    return false;
                }
            }

            return false;
        }

        public static bool loadBar(int index, string classe)
        {
            string pName = vars.warrior[index].player;

            foreach (TSPlayer n in TShock.Players)
            {
                if (n.Name == pName)
                {
                    TSPlayer p = n;
                    if (classe == "warrior")
                    {
                        int currentLoop = 0;
                        if (vars.warrior[index].itemsBarNetID.Count > 0)
                        {
                            foreach (int i in vars.warrior[index].itemsBarNetID)
                            {
                                p.TPlayer.inventory[currentLoop].SetDefaults(i);
                                p.TPlayer.inventory[currentLoop].stack = vars.warrior[index].itemsBarStack[currentLoop];
                                p.TPlayer.inventory[currentLoop].name = vars.warrior[index].itemsBarName[currentLoop];
                                NetMessage.SendData(5, -1, -1, "", p.Index, (float)currentLoop, (float)vars.warrior[index].itemsBarPrefix[currentLoop], 0f, 0);
                                currentLoop++;
                            }
                            return true;
                        }
                        else
                        {
                            p.TPlayer.inventory[0].SetDefaults(0);
                            p.TPlayer.inventory[1].SetDefaults(0);
                            p.TPlayer.inventory[2].SetDefaults(0);
                            p.TPlayer.inventory[3].SetDefaults(0);
                            p.TPlayer.inventory[4].SetDefaults(0);
                            p.TPlayer.inventory[5].SetDefaults(0);
                            p.TPlayer.inventory[6].SetDefaults(0);
                            p.TPlayer.inventory[7].SetDefaults(0);
                            p.TPlayer.inventory[8].SetDefaults(0);
                            NetMessage.SendData(5, -1, -1, "", p.Index, (float)0);
                            NetMessage.SendData(5, -1, -1, "", p.Index, (float)1);
                            NetMessage.SendData(5, -1, -1, "", p.Index, (float)2);
                            NetMessage.SendData(5, -1, -1, "", p.Index, (float)3);
                            NetMessage.SendData(5, -1, -1, "", p.Index, (float)4);
                            NetMessage.SendData(5, -1, -1, "", p.Index, (float)5);
                            NetMessage.SendData(5, -1, -1, "", p.Index, (float)6);
                            NetMessage.SendData(5, -1, -1, "", p.Index, (float)7);
                            NetMessage.SendData(5, -1, -1, "", p.Index, (float)8);
                            return true;

                        }
                    }
                    if (classe == "paladin")
                    {
                        int currentLoop = 0;
                        if (vars.paladin[index].itemsBarNetID.Count > 0)
                        {
                            foreach (int i in vars.paladin[index].itemsBarNetID)
                            {
                                p.TPlayer.inventory[currentLoop].SetDefaults(i);
                                p.TPlayer.inventory[currentLoop].stack = vars.paladin[index].itemsBarStack[currentLoop];
                                p.TPlayer.inventory[currentLoop].name = vars.paladin[index].itemsBarName[currentLoop];
                                NetMessage.SendData(5, -1, -1, "", p.Index, (float)currentLoop, (float)vars.paladin[index].itemsBarPrefix[currentLoop], 0f, 0);
                                currentLoop++;
                            }
                            return true;
                        }
                        else
                        {
                            p.TPlayer.inventory[0].SetDefaults(0);
                            p.TPlayer.inventory[1].SetDefaults(0);
                            p.TPlayer.inventory[2].SetDefaults(0);
                            p.TPlayer.inventory[3].SetDefaults(0);
                            p.TPlayer.inventory[4].SetDefaults(0);
                            p.TPlayer.inventory[5].SetDefaults(0);
                            p.TPlayer.inventory[6].SetDefaults(0);
                            p.TPlayer.inventory[7].SetDefaults(0);
                            p.TPlayer.inventory[8].SetDefaults(0);
                            NetMessage.SendData(5, -1, -1, "", p.Index, (float)0);
                            NetMessage.SendData(5, -1, -1, "", p.Index, (float)1);
                            NetMessage.SendData(5, -1, -1, "", p.Index, (float)2);
                            NetMessage.SendData(5, -1, -1, "", p.Index, (float)3);
                            NetMessage.SendData(5, -1, -1, "", p.Index, (float)4);
                            NetMessage.SendData(5, -1, -1, "", p.Index, (float)5);
                            NetMessage.SendData(5, -1, -1, "", p.Index, (float)6);
                            NetMessage.SendData(5, -1, -1, "", p.Index, (float)7);
                            NetMessage.SendData(5, -1, -1, "", p.Index, (float)8);
                            return true;

                        }
                    }
                    if (classe == "wizard")
                    {
                        int currentLoop = 0;
                        if (vars.wizard[index].itemsBarNetID.Count > 0)
                        {
                            foreach (int i in vars.wizard[index].itemsBarNetID)
                            {
                                p.TPlayer.inventory[currentLoop].SetDefaults(i);
                                p.TPlayer.inventory[currentLoop].stack = vars.wizard[index].itemsBarStack[currentLoop];
                                p.TPlayer.inventory[currentLoop].name = vars.wizard[index].itemsBarName[currentLoop];
                                NetMessage.SendData(5, -1, -1, "", p.Index, (float)currentLoop, (float)vars.wizard[index].itemsBarPrefix[currentLoop], 0f, 0);
                                currentLoop++;
                            }
                            return true;
                        }
                        else
                        {
                            p.TPlayer.inventory[0].SetDefaults(0);
                            p.TPlayer.inventory[1].SetDefaults(0);
                            p.TPlayer.inventory[2].SetDefaults(0);
                            p.TPlayer.inventory[3].SetDefaults(0);
                            p.TPlayer.inventory[4].SetDefaults(0);
                            p.TPlayer.inventory[5].SetDefaults(0);
                            p.TPlayer.inventory[6].SetDefaults(0);
                            p.TPlayer.inventory[7].SetDefaults(0);
                            p.TPlayer.inventory[8].SetDefaults(0);
                            NetMessage.SendData(5, -1, -1, "", p.Index, (float)0);
                            NetMessage.SendData(5, -1, -1, "", p.Index, (float)1);
                            NetMessage.SendData(5, -1, -1, "", p.Index, (float)2);
                            NetMessage.SendData(5, -1, -1, "", p.Index, (float)3);
                            NetMessage.SendData(5, -1, -1, "", p.Index, (float)4);
                            NetMessage.SendData(5, -1, -1, "", p.Index, (float)5);
                            NetMessage.SendData(5, -1, -1, "", p.Index, (float)6);
                            NetMessage.SendData(5, -1, -1, "", p.Index, (float)7);
                            NetMessage.SendData(5, -1, -1, "", p.Index, (float)8);
                            return true;

                        }
                    }
                    return false;
                }
            }
            return false;
        }

        public static bool loadEquipment(int index, string classe)
        {
            string pName = vars.warrior[index].player;

            foreach (TSPlayer n in TShock.Players)
            {
                if (n.Name == pName)
                {
                    TSPlayer p = n;
                    if (classe == "warrior")
                    {
                        int currentLoop = 0;
                        if (vars.warrior[index].itemsArmorNetID.Count > 0)
                        {
                            foreach (int i in vars.warrior[index].itemsArmorNetID)
                            {
                                p.TPlayer.armor[currentLoop].netDefaults(0);
                                NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", p.Index, (float)currentLoop + 59);
                                p.TPlayer.armor[currentLoop].netDefaults(i);
                                p.TPlayer.armor[currentLoop].stack = vars.warrior[index].itemsArmorStack[currentLoop];
                                p.TPlayer.armor[currentLoop].name = vars.warrior[index].itemsArmorName[currentLoop];
                                NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", p.Index, (float)currentLoop + 59, (float)vars.warrior[index].itemsArmorPrefix[currentLoop], 0f, 0);
                                currentLoop++;
                            }
                            return true;
                        }
                        else
                        {
                            p.TPlayer.armor[0].netDefaults(0);
                            p.TPlayer.armor[1].netDefaults(0);
                            p.TPlayer.armor[2].netDefaults(0);
                            p.TPlayer.armor[3].netDefaults(0);
                            p.TPlayer.armor[4].netDefaults(0);
                            p.TPlayer.armor[5].netDefaults(0);
                            p.TPlayer.armor[6].netDefaults(0);
                            p.TPlayer.armor[7].netDefaults(0);
                            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", p.Index, (float)59);
                            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", p.Index, (float)60);
                            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", p.Index, (float)61);
                            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", p.Index, (float)62);
                            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", p.Index, (float)63);
                            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", p.Index, (float)64);
                            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", p.Index, (float)65);
                            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", p.Index, (float)66);
                        }
                    }
                    if (classe == "paladin")
                    {
                        int currentLoop = 0;
                        if (vars.paladin[index].itemsArmorNetID.Count > 0)
                        {
                            foreach (int i in vars.paladin[index].itemsArmorNetID)
                            {
                                p.TPlayer.armor[currentLoop].netDefaults(0);
                                NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", p.Index, (float)currentLoop + 59);
                                p.TPlayer.armor[currentLoop].netDefaults(i);
                                p.TPlayer.armor[currentLoop].stack = vars.paladin[index].itemsArmorStack[currentLoop];
                                p.TPlayer.armor[currentLoop].name = vars.paladin[index].itemsArmorName[currentLoop];
                                NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", p.Index, (float)currentLoop + 59, (float)vars.paladin[index].itemsArmorPrefix[currentLoop], 0f, 0);
                                currentLoop++;
                            }
                        }
                        else
                        {
                            p.TPlayer.armor[0].netDefaults(0);
                            p.TPlayer.armor[1].netDefaults(0);
                            p.TPlayer.armor[2].netDefaults(0);
                            p.TPlayer.armor[3].netDefaults(0);
                            p.TPlayer.armor[4].netDefaults(0);
                            p.TPlayer.armor[5].netDefaults(0);
                            p.TPlayer.armor[6].netDefaults(0);
                            p.TPlayer.armor[7].netDefaults(0);
                            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", p.Index, (float)59);
                            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", p.Index, (float)60);
                            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", p.Index, (float)61);
                            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", p.Index, (float)62);
                            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", p.Index, (float)63);
                            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", p.Index, (float)64);
                            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", p.Index, (float)65);
                            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", p.Index, (float)66);
                        }
                        return true;
                    }
                    if (classe == "wizard")
                    {
                        int currentLoop = 0;
                        if (vars.wizard[index].itemsArmorNetID.Count > 0)
                        {
                            foreach (int i in vars.wizard[index].itemsArmorNetID)
                            {
                                p.TPlayer.armor[currentLoop].netDefaults(0);
                                NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", p.Index, (float)currentLoop + 59);
                                p.TPlayer.armor[currentLoop].netDefaults(i);
                                p.TPlayer.armor[currentLoop].stack = vars.wizard[index].itemsArmorStack[currentLoop];
                                p.TPlayer.armor[currentLoop].name = vars.wizard[index].itemsArmorName[currentLoop];
                                NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", p.Index, (float)currentLoop + 59, (float)vars.wizard[index].itemsArmorPrefix[currentLoop], 0f, 0);
                                currentLoop++;
                            }
                        }
                        else
                        {
                            p.TPlayer.armor[0].netDefaults(0);
                            p.TPlayer.armor[1].netDefaults(0);
                            p.TPlayer.armor[2].netDefaults(0);
                            p.TPlayer.armor[3].netDefaults(0);
                            p.TPlayer.armor[4].netDefaults(0);
                            p.TPlayer.armor[5].netDefaults(0);
                            p.TPlayer.armor[6].netDefaults(0);
                            p.TPlayer.armor[7].netDefaults(0);
                            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", p.Index, (float)59);
                            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", p.Index, (float)60);
                            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", p.Index, (float)61);
                            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", p.Index, (float)62);
                            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", p.Index, (float)63);
                            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", p.Index, (float)64);
                            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", p.Index, (float)65);
                            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", p.Index, (float)66);
                        }
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
