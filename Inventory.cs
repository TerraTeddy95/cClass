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
    class Inventory
    {
        public static bool clearEquipment(TSPlayer Player)
        {
            Player.TPlayer.armor[0].netDefaults(0);
            Player.TPlayer.armor[1].netDefaults(0);
            Player.TPlayer.armor[2].netDefaults(0);
            Player.TPlayer.armor[3].netDefaults(0);
            Player.TPlayer.armor[4].netDefaults(0);
            Player.TPlayer.armor[5].netDefaults(0);
            Player.TPlayer.armor[6].netDefaults(0);
            Player.TPlayer.armor[7].netDefaults(0);
            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", Player.Index, (float)59);
            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", Player.Index, (float)60);
            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", Player.Index, (float)61);
            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", Player.Index, (float)62);
            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", Player.Index, (float)63);
            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", Player.Index, (float)64);
            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", Player.Index, (float)65);
            NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", Player.Index, (float)66);
            return true;
        }
        public static bool clearBar(TSPlayer Player)
        {
            Player.TPlayer.inventory[0].SetDefaults(0);
            Player.TPlayer.inventory[1].SetDefaults(0);
            Player.TPlayer.inventory[2].SetDefaults(0);
            Player.TPlayer.inventory[3].SetDefaults(0);
            Player.TPlayer.inventory[4].SetDefaults(0);
            Player.TPlayer.inventory[5].SetDefaults(0);
            Player.TPlayer.inventory[6].SetDefaults(0);
            Player.TPlayer.inventory[7].SetDefaults(0);
            Player.TPlayer.inventory[8].SetDefaults(0);
            NetMessage.SendData(5, -1, -1, "", Player.Index, (float)0);
            NetMessage.SendData(5, -1, -1, "", Player.Index, (float)1);
            NetMessage.SendData(5, -1, -1, "", Player.Index, (float)2);
            NetMessage.SendData(5, -1, -1, "", Player.Index, (float)3);
            NetMessage.SendData(5, -1, -1, "", Player.Index, (float)4);
            NetMessage.SendData(5, -1, -1, "", Player.Index, (float)5);
            NetMessage.SendData(5, -1, -1, "", Player.Index, (float)6);
            NetMessage.SendData(5, -1, -1, "", Player.Index, (float)7);
            NetMessage.SendData(5, -1, -1, "", Player.Index, (float)8);
            return true;
        }
        public static bool loadEquipment(TSPlayer Player, string classe)
        {
            int currentLoop = 0;
            if (classe == "warrior")
            {
                if (Variables.playersData[Player.Name].Warrior.itemsArmorNetID.Count > 0)
                {
                    foreach (int i in Variables.playersData[Player.Name].Warrior.itemsArmorNetID)
                    {
                        Player.TPlayer.armor[currentLoop].netDefaults(i);
                        NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", Player.Index, (float)currentLoop + 59, (float)Variables.playersData[Player.Name].Warrior.itemsArmorPrefix[currentLoop], 0f, 0);
                        currentLoop++;
                    }
                    return true;
                }
                else
                {
                    clearEquipment(Player);
                }
            }
            if (classe == "paladin")
            {
                if (Variables.playersData[Player.Name].Paladin.itemsArmorNetID.Count > 0)
                {
                    foreach (int i in Variables.playersData[Player.Name].Paladin.itemsArmorNetID)
                    {
                        Player.TPlayer.armor[currentLoop].netDefaults(i);
                        NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", Player.Index, (float)currentLoop + 59, (float)Variables.playersData[Player.Name].Paladin.itemsArmorPrefix[currentLoop], 0f, 0);
                        currentLoop++;
                    }
                    return true;
                }
                else
                {
                    clearEquipment(Player);
                }
            }
            if (classe == "wizard")
            {
                if (Variables.playersData[Player.Name].Wizard.itemsArmorNetID.Count > 0)
                {
                    foreach (int i in Variables.playersData[Player.Name].Wizard.itemsArmorNetID)
                    {
                        Player.TPlayer.armor[currentLoop].netDefaults(i);
                        NetMessage.SendData((int)PacketTypes.PlayerSlot, -1, -1, "", Player.Index, (float)currentLoop + 59, (float)Variables.playersData[Player.Name].Wizard.itemsArmorPrefix[currentLoop], 0f, 0);
                        currentLoop++;
                    }
                    return true;
                }
                else
                {
                    clearEquipment(Player);
                }
            }
            return false;
        }
        public static bool loadBar(TSPlayer Player, string classe)
        {
            int currentLoop = 0;
            if (classe == "warrior")
            {
                if (Variables.playersData[Player.Name].Warrior.itemsBarNetID.Count > 0)
                {
                    foreach (int i in Variables.playersData[Player.Name].Warrior.itemsBarNetID)
                    {
                        Player.TPlayer.inventory[currentLoop].SetDefaults(i);
                        Player.TPlayer.inventory[currentLoop].stack = Variables.playersData[Player.Name].Warrior.itemsBarStack[currentLoop];
                        NetMessage.SendData(5, -1, -1, "", Player.Index, (float)currentLoop, (float)Variables.playersData[Player.Name].Warrior.itemsBarStack[currentLoop], 0f, 0);
                        currentLoop++;
                    }
                    return true;
                }
                else
                {
                    clearBar(Player);
                    return true;
                }
            }
            if (classe == "paladin")
            {
                if (Variables.playersData[Player.Name].Paladin.itemsBarNetID.Count > 0)
                {
                    foreach (int i in Variables.playersData[Player.Name].Paladin.itemsBarNetID)
                    {
                        Player.TPlayer.inventory[currentLoop].SetDefaults(i);
                        Player.TPlayer.inventory[currentLoop].stack = Variables.playersData[Player.Name].Paladin.itemsBarStack[currentLoop];
                        NetMessage.SendData(5, -1, -1, "", Player.Index, (float)currentLoop, (float)Variables.playersData[Player.Name].Paladin.itemsBarStack[currentLoop], 0f, 0);
                        currentLoop++;
                    }
                    return true;
                }
                else
                {
                    clearBar(Player);
                    return true;
                }
            }
            if (classe == "wizard")
            {
                if (Variables.playersData[Player.Name].Wizard.itemsBarNetID.Count > 0)
                {
                    foreach (int i in Variables.playersData[Player.Name].Wizard.itemsBarNetID)
                    {
                        Player.TPlayer.inventory[currentLoop].SetDefaults(i);
                        Player.TPlayer.inventory[currentLoop].stack = Variables.playersData[Player.Name].Wizard.itemsBarStack[currentLoop];
                        NetMessage.SendData(5, -1, -1, "", Player.Index, (float)currentLoop, (float)Variables.playersData[Player.Name].Wizard.itemsBarStack[currentLoop], 0f, 0);
                        currentLoop++;
                    }
                    return true;
                }
                else
                {
                    clearBar(Player);
                    return true;
                }
            }
            return false;
        }
        public static bool saveBar(TSPlayer Player, string classe)
        {
            int currentLoop = 0;
            if (classe == "warrior")
            {
                Variables.playersData[Player.Name].Warrior.itemsBarNetID.Clear();
                Variables.playersData[Player.Name].Warrior.itemsBarPrefix.Clear();
                Variables.playersData[Player.Name].Warrior.itemsBarStack.Clear();
                foreach (Item i in Player.TPlayer.inventory)
                {
                    currentLoop++;
                    Variables.playersData[Player.Name].Warrior.itemsBarNetID.Add(i.netID);
                    Variables.playersData[Player.Name].Warrior.itemsBarPrefix.Add(i.prefix);
                    Variables.playersData[Player.Name].Warrior.itemsBarStack.Add(i.stack);
                    if (currentLoop == 10)
                    {
                        return true;
                    }
                }
            }
            if (classe == "paladin")
            {
                Variables.playersData[Player.Name].Paladin.itemsBarNetID.Clear();
                Variables.playersData[Player.Name].Paladin.itemsBarPrefix.Clear();
                Variables.playersData[Player.Name].Paladin.itemsBarStack.Clear();
                foreach (Item i in Player.TPlayer.inventory)
                {
                    currentLoop++;
                    Variables.playersData[Player.Name].Paladin.itemsBarNetID.Add(i.netID);
                    Variables.playersData[Player.Name].Paladin.itemsBarPrefix.Add(i.prefix);
                    Variables.playersData[Player.Name].Paladin.itemsBarStack.Add(i.stack);
                    if (currentLoop == 10)
                    {
                        return true;
                    }
                }
            }
            if (classe == "wizard")
            {
                Variables.playersData[Player.Name].Wizard.itemsBarNetID.Clear();
                Variables.playersData[Player.Name].Wizard.itemsBarPrefix.Clear();
                Variables.playersData[Player.Name].Wizard.itemsBarStack.Clear();
                foreach (Item i in Player.TPlayer.inventory)
                {
                    currentLoop++;
                    Variables.playersData[Player.Name].Wizard.itemsBarNetID.Add(i.netID);
                    Variables.playersData[Player.Name].Wizard.itemsBarPrefix.Add(i.prefix);
                    Variables.playersData[Player.Name].Wizard.itemsBarStack.Add(i.stack);
                    if (currentLoop == 10)
                    {
                        return true;
                    }
                }
            }
            
            return false;
        }
        public static bool saveEquipment(TSPlayer Player, string classe)
        {
            int currentLoop = 0;
            if (classe == "warrior")
            {
                Variables.playersData[Player.Name].Warrior.itemsArmorNetID.Clear();
                Variables.playersData[Player.Name].Warrior.itemsArmorPrefix.Clear();
                foreach (Item i in Player.TPlayer.armor)
                {
                    currentLoop++;
                    Variables.playersData[Player.Name].Warrior.itemsArmorNetID.Add(i.netID);
                    Variables.playersData[Player.Name].Warrior.itemsArmorPrefix.Add(i.prefix);
                    if (currentLoop == 8)
                    {
                        return true;
                    }
                }
            }
            if (classe == "paladin")
            {
                Variables.playersData[Player.Name].Paladin.itemsArmorNetID.Clear();
                Variables.playersData[Player.Name].Paladin.itemsArmorPrefix.Clear();
                foreach (Item i in Player.TPlayer.armor)
                {
                    currentLoop++;
                    Variables.playersData[Player.Name].Paladin.itemsArmorNetID.Add(i.netID);
                    Variables.playersData[Player.Name].Paladin.itemsArmorPrefix.Add(i.prefix);
                    if (currentLoop == 8)
                    {
                        return true;
                    }
                }
            }
            if (classe == "wizard")
            {
                Variables.playersData[Player.Name].Wizard.itemsArmorNetID.Clear();
                Variables.playersData[Player.Name].Wizard.itemsArmorPrefix.Clear();
                foreach (Item i in Player.TPlayer.armor)
                {
                    currentLoop++;
                    Variables.playersData[Player.Name].Wizard.itemsArmorNetID.Add(i.netID);
                    Variables.playersData[Player.Name].Wizard.itemsArmorPrefix.Add(i.prefix);
                    if (currentLoop == 8)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
