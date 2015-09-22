using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using TShockAPI;
using TerrariaApi.Server;
using Newtonsoft.Json;
using System.IO;
using System.Timers;

namespace cClass 
{
    class damage
    {
        public static void onDamage(NpcStrikeEventArgs e)
        {
            if (e.Player == null)
            {
                return;
            }
            if (e.Npc.netID == 488 || e.Npc.netID == 49 || e.Npc.netID == 74 || e.Npc.netID == 46 || e.Npc.netID == 85 || e.Npc.netID == 67 || e.Npc.netID == 55 || e.Npc.netID == 230 || e.Npc.netID == 63 || e.Npc.netID == 64 || e.Npc.netID == 101 || e.Npc.netID == 242 || e.Npc.netID == 256 || e.Npc.netID == 58 || e.Npc.netID == 65 || e.Npc.netID == 21 || e.Npc.netID == 1)
            {
                return;
            }
            if (e.Player.whoAmI == -1)
            {
                return;
            }
            TSPlayer sender = TShock.Players[e.Player.whoAmI];

            int index = vars.warrior.FindIndex(w => w.player == sender.Name);
            if (index == -1)
            {
                return;
            }
            if (e.Handled == true)
            {
                return;
            }

            Color c = new Color(255, 120, 0);
            if (vars.informations[index].actualClass == "warrior")
            {
                int neededExpForLevelUp = vars.warrior[index].level * (896 + (896 * 43 / 100));
                int addedExp = ((e.Damage * 147 / 100) / 2);
                vars.warrior[index].exprience = vars.warrior[index].exprience + ((e.Damage * 147 / 100) / 2);
                if (vars.warrior[index].exprience >= neededExpForLevelUp)
                {
                    vars.warrior[index].level++;
                    vars.warrior[index].exprience = 0;
                    NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, "[" + vars.warrior[index].level + "] Level UP!", (int)c.PackedValue, sender.X, sender.Y, 0, 0, 0, 0);
                    vars.warrior[index].statsPoints++;
                }
                else
                {

                    int exp = vars.warrior[index].exprience;
                    int percent = exp * 100 / neededExpForLevelUp;
                    int level = vars.warrior[index].level;
                    int change = new Random().Next(0, 100);
                    if (change <= 7)
                    {
                        NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, "[" + level + "LVL] " + exp + "|" + neededExpForLevelUp + "] " + percent + "%    +[" + addedExp + "xp]", (int)c.PackedValue, sender.X, sender.Y, 0, 0, 0, 0);
                    }
                }


            }

            if (vars.informations[index].actualClass == "paladin")
            {
                int neededExpForLevelUp = vars.paladin[index].level * (896 + (896 * 43 / 100));
                int addedExp = ((e.Damage * 147 / 100) / 2);
                vars.paladin[index].exprience = vars.paladin[index].exprience + ((e.Damage * 147 / 100) / 2);
                if (vars.paladin[index].exprience >= neededExpForLevelUp)
                {
                    vars.paladin[index].level++;
                    vars.paladin[index].exprience = 0;
                    NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, "[" + vars.paladin[index].level + "] Level UP!", (int)c.PackedValue, sender.X, sender.Y, 0, 0, 0, 0);
                    vars.paladin[index].statsPoints++;
                }
                else
                {

                    int exp = vars.paladin[index].exprience;
                    int percent = exp * 100 / neededExpForLevelUp;
                    int level = vars.paladin[index].level;
                    int change = new Random().Next(0, 100);
                    if (change <= 10)
                    {
                        NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, "[" + level + "LVL] " + exp + "|" + neededExpForLevelUp + "] " + percent + "%    +[" + addedExp + "xp]", (int)c.PackedValue, sender.X, sender.Y, 0, 0, 0, 0);
                    }
                }


            }

            if (vars.informations[index].actualClass == "wizard")
            {
                int neededExpForLevelUp = vars.wizard[index].level * (896 + (896 * 43 / 100));
                int addedExp = ((e.Damage * 147 / 100) / 2);
                vars.wizard[index].exprience = vars.wizard[index].exprience + ((e.Damage * 147 / 100) / 2);
                if (vars.wizard[index].exprience >= neededExpForLevelUp)
                {
                    vars.wizard[index].level++;
                    vars.wizard[index].exprience = 0;
                    NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, "[" + vars.wizard[index].level + "] Level UP!", (int)c.PackedValue, sender.X, sender.Y, 0, 0, 0, 0);
                    vars.wizard[index].statsPoints++;
                }
                else
                {

                    int exp = vars.wizard[index].exprience;
                    int percent = exp * 100 / neededExpForLevelUp;
                    int level = vars.wizard[index].level;
                    int change = new Random().Next(0, 100);
                    if (change <= 10)
                    {
                        NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, "[" + level + "LVL] " + exp + "|" + neededExpForLevelUp + "] " + percent + "%    +[" + addedExp + "xp]", (int)c.PackedValue, sender.X, sender.Y, 0, 0, 0, 0);
                    }
                }


            }










            if (sender.SelectedItem.melee)
            {

                if (vars.informations[index].actualClass == "warrior")
                {
                    int damage = (vars.warrior[index].statMeeleDamage * 3);
                    
                    if (damage > 0)
                    {
                        NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, "+" + damage, (int)c.PackedValue, e.Npc.position.X, e.Npc.position.Y, 0, 0, 0, 0);
                    }
                    e.Damage = e.Damage + damage;
                    return;
                }
                if (vars.informations[index].actualClass == "paladin")
                {
                    int damage = (vars.paladin[index].statMeeleDamage);
                    
                    if (damage > 0)
                    {
                        NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, "+" + damage, (int)c.PackedValue, e.Npc.position.X, e.Npc.position.Y, 0, 0, 0, 0);
                    }
                    e.Damage = e.Damage + damage;
                    return;
                }
                if (vars.informations[index].actualClass == "wizard")
                {
                    int damage = (vars.wizard[index].statMeeleDamage);
                    
                    if (damage > 0)
                    {
                        NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, "+" + damage, (int)c.PackedValue, e.Npc.position.X, e.Npc.position.Y, 0, 0, 0, 0);
                    }
                    e.Damage = e.Damage + damage;
                    return;
                }

                if (sender.SelectedItem.ranged)
                {

                    if (vars.informations[index].actualClass == "warrior")
                    {
                        int damage = (vars.warrior[index].statRangedDamage);
                        if (damage > 0)
                        {
                            NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, "+" + damage, (int)c.PackedValue, e.Npc.position.X, e.Npc.position.Y, 0, 0, 0, 0);
                        }
                        e.Damage = e.Damage + damage;
                        return;
                    }
                    if (vars.informations[index].actualClass == "paladin")
                    {
                        int damage = (vars.paladin[index].statRangedDamage * 3);
                        if (damage > 0)
                        {
                            NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, "+" + damage, (int)c.PackedValue, e.Npc.position.X, e.Npc.position.Y, 0, 0, 0, 0);
                        }
                        e.Damage = e.Damage + damage;
                        return;
                    }
                    if (vars.informations[index].actualClass == "wizard")
                    {
                        int damage = (vars.wizard[index].statRangedDamage);
                        if (damage > 0)
                        {
                            NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, "+" + damage, (int)c.PackedValue, e.Npc.position.X, e.Npc.position.Y, 0, 0, 0, 0);
                        }
                        e.Damage = e.Damage + damage;
                        return;
                    }

                }
                if (sender.SelectedItem.magic)
                {

                    if (vars.informations[index].actualClass == "warrior")
                    {
                        int damage = (vars.warrior[index].statMagicDamage);
                        if (damage > 0)
                        {
                            NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, "+" + damage, (int)c.PackedValue, e.Npc.position.X, e.Npc.position.Y, 0, 0, 0, 0);
                        }
                        e.Damage = e.Damage + damage;
                        return;
                    }
                    if (vars.informations[index].actualClass == "paladin")
                    {
                        int damage = (vars.paladin[index].statMagicDamage);
                        if (damage > 0)
                        {
                            NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, "+" + damage, (int)c.PackedValue, e.Npc.position.X, e.Npc.position.Y, 0, 0, 0, 0);
                        }
                        e.Damage = e.Damage + damage;
                        return;
                    }
                    if (vars.informations[index].actualClass == "wizard")
                    {
                        int damage = (vars.wizard[index].statMagicDamage * 3);
                        if (damage > 0)
                        {
                            NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, "+" + damage, (int)c.PackedValue, e.Npc.position.X, e.Npc.position.Y, 0, 0, 0, 0);
                        }
                        e.Damage = e.Damage + damage;
                        return;
                    }



                }
            }


        }
    }
}
