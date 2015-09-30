using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using TShockAPI;
using TerrariaApi.Server;

namespace cClass.Events
{
    class OnDamage
    {
        public static void run(NpcStrikeEventArgs e)
        {
            if (e.Handled == true)
            {
                return;
            }
            if (e.Player == null)
            {
                return;
            }
            if (!(Variables.playersData.ContainsKey(e.Player.name)))
            {
                return;
            }
            if (Variables.BlockedNPCs.Contains(e.Npc.netID))
            {
                return;
            }
            Color c = new Color(255, 120, 0);

            if (Variables.playersData[e.Player.name].ActualClass == "warrior")
            {
                int neededExpForLevelUp = Variables.playersData[e.Player.name].Warrior.level * (896 + (896 * 43 / 100));
                int addedExp = ((e.Damage * 147 / 100) / 2);
                Variables.playersData[e.Player.name].Warrior.exprience +=  ((e.Damage * 147 / 100) / 2);
                if (Variables.playersData[e.Player.name].Warrior.exprience >= neededExpForLevelUp)
                {
                    Variables.playersData[e.Player.name].Warrior.level++;
                    Variables.playersData[e.Player.name].Warrior.exprience = 0;
                    Variables.playersData[e.Player.name].Warrior.statsPoints++;
                    string levelUp = Variables.levelUp.Replace("%level%", Variables.playersData[e.Player.name].Warrior.level + "");
                    NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, levelUp, (int)c.PackedValue, TShock.Players[e.Player.whoAmI].X, TShock.Players[e.Player.whoAmI].Y, 0, 0, 0, 0);
                }
                else
                {
                    int change = new Random().Next(0, 100);
                    if (change <= Variables.Chance)
                    {
                        NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, "[" + Variables.playersData[e.Player.name].Warrior.level + "LVL] " + Variables.playersData[e.Player.name].Warrior.exprience + "|" + neededExpForLevelUp + "] " + ((Variables.playersData[e.Player.name].Warrior.exprience * 100) / neededExpForLevelUp) + "%    +[" + addedExp + "xp]", (int)c.PackedValue, TShock.Players[e.Player.whoAmI].X, TShock.Players[e.Player.whoAmI].Y, 0, 0, 0, 0);
                    }
                }
            }
            if (Variables.playersData[e.Player.name].ActualClass == "paladin")
            {
                int neededExpForLevelUp = Variables.playersData[e.Player.name].Paladin.level * (896 + (896 * 43 / 100));
                int addedExp = ((e.Damage * 147 / 100) / 2);
                Variables.playersData[e.Player.name].Paladin.exprience += ((e.Damage * 147 / 100) / 2);
                if (Variables.playersData[e.Player.name].Paladin.exprience >= neededExpForLevelUp)
                {
                    Variables.playersData[e.Player.name].Paladin.level++;
                    Variables.playersData[e.Player.name].Paladin.exprience = 0;
                    Variables.playersData[e.Player.name].Paladin.statsPoints++;
                    string levelUp = Variables.levelUp.Replace("%level%", Variables.playersData[e.Player.name].Warrior.level + "");
                    NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, levelUp, (int)c.PackedValue, TShock.Players[e.Player.whoAmI].X, TShock.Players[e.Player.whoAmI].Y, 0, 0, 0, 0);
                }
                else
                {
                    int change = new Random().Next(0, 100);
                    if (change <= Variables.Chance)
                    {
                        NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, "[" + Variables.playersData[e.Player.name].Paladin.level + "LVL] " + Variables.playersData[e.Player.name].Paladin.exprience + "|" + neededExpForLevelUp + "] " + ((Variables.playersData[e.Player.name].Paladin.exprience * 100) / neededExpForLevelUp) + "%    +[" + addedExp + "xp]", (int)c.PackedValue, TShock.Players[e.Player.whoAmI].X, TShock.Players[e.Player.whoAmI].Y, 0, 0, 0, 0);
                    }
                }
            }
            if (Variables.playersData[e.Player.name].ActualClass == "wizard")
            {
                int neededExpForLevelUp = Variables.playersData[e.Player.name].Wizard.level * (896 + (896 * 43 / 100));
                int addedExp = ((e.Damage * 147 / 100) / 2);
                Variables.playersData[e.Player.name].Wizard.exprience += ((e.Damage * 147 / 100) / 2);
                if (Variables.playersData[e.Player.name].Wizard.exprience >= neededExpForLevelUp)
                {
                    Variables.playersData[e.Player.name].Wizard.level++;
                    Variables.playersData[e.Player.name].Wizard.exprience = 0;
                    Variables.playersData[e.Player.name].Wizard.statsPoints++;
                    string levelUp = Variables.levelUp.Replace("%level%", Variables.playersData[e.Player.name].Warrior.level + "");
                    NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, levelUp, (int)c.PackedValue, TShock.Players[e.Player.whoAmI].X, TShock.Players[e.Player.whoAmI].Y, 0, 0, 0, 0);
                }
                else
                {
                    int change = new Random().Next(0, 100);
                    if (change <= Variables.Chance)
                    {
                        NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, "[" + Variables.playersData[e.Player.name].Wizard.level + "LVL] " + Variables.playersData[e.Player.name].Wizard.exprience + "|" + neededExpForLevelUp + "] " + ((Variables.playersData[e.Player.name].Wizard.exprience * 100) / neededExpForLevelUp) + "%    +[" + addedExp + "xp]", (int)c.PackedValue, TShock.Players[e.Player.whoAmI].X, TShock.Players[e.Player.whoAmI].Y, 0, 0, 0, 0);
                    }
                }
            }
            if (TShock.Players[e.Player.whoAmI].SelectedItem.melee)
            {
                if (Variables.playersData[e.Player.name].ActualClass == "warrior")
                {
                    if (e.Damage >= e.Npc.life)
                    {
                        return;
                    }
                    int Damage = (Variables.playersData[e.Player.name].Warrior.statMeleeDamage * 3);
                    if (Damage > 0)
                    {
                        NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, "+" + Damage, (int)c.PackedValue, e.Npc.position.X, e.Npc.position.Y, 0, 0, 0, 0);
                    }
                    e.Damage = e.Damage + Damage;
                    return;
                }
                if (Variables.playersData[e.Player.name].ActualClass == "paladin")
                {
                    if (e.Damage >= e.Npc.life)
                    {
                        return;
                    }
                    int Damage = (Variables.playersData[e.Player.name].Paladin.statMeleeDamage);
                    if (Damage > 0)
                    {
                        NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, "+" + Damage, (int)c.PackedValue, e.Npc.position.X, e.Npc.position.Y, 0, 0, 0, 0);
                    }
                    e.Damage = e.Damage + Damage;
                    return;
                }
                if (Variables.playersData[e.Player.name].ActualClass == "wizard")
                {
                    if (e.Damage >= e.Npc.life)
                    {
                        return;
                    }
                    int Damage = (Variables.playersData[e.Player.name].Wizard.statMeleeDamage);
                    if (Damage > 0)
                    {
                        NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, "+" + Damage, (int)c.PackedValue, e.Npc.position.X, e.Npc.position.Y, 0, 0, 0, 0);
                    }
                    e.Damage = e.Damage + Damage;
                    return;
                }
            }
            if (TShock.Players[e.Player.whoAmI].SelectedItem.ranged)
            {
                if (Variables.playersData[e.Player.name].ActualClass == "warrior")
                {
                    if (e.Damage >= e.Npc.life)
                    {
                        return;
                    }
                    int Damage = (Variables.playersData[e.Player.name].Warrior.statMeleeDamage);
                    if (Damage > 0)
                    {
                        NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, "+" + Damage, (int)c.PackedValue, e.Npc.position.X, e.Npc.position.Y, 0, 0, 0, 0);
                    }
                    e.Damage = e.Damage + Damage;
                    return;
                }
                if (Variables.playersData[e.Player.name].ActualClass == "paladin")
                {
                    if (e.Damage >= e.Npc.life)
                    {
                        return;
                    }
                    int Damage = (Variables.playersData[e.Player.name].Paladin.statMeleeDamage * 3);
                    if (Damage > 0)
                    {
                        NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, "+" + Damage, (int)c.PackedValue, e.Npc.position.X, e.Npc.position.Y, 0, 0, 0, 0);
                    }
                    e.Damage = e.Damage + Damage;
                    return;
                }
                if (Variables.playersData[e.Player.name].ActualClass == "wizard")
                {
                    if (e.Damage >= e.Npc.life)
                    {
                        return;
                    }
                    int Damage = (Variables.playersData[e.Player.name].Wizard.statMeleeDamage);
                    if (Damage > 0)
                    {
                        NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, "+" + Damage, (int)c.PackedValue, e.Npc.position.X, e.Npc.position.Y, 0, 0, 0, 0);
                    }
                    e.Damage = e.Damage + Damage;
                    return;
                }
            }
            if (TShock.Players[e.Player.whoAmI].SelectedItem.magic)
            {
                if (Variables.playersData[e.Player.name].ActualClass == "warrior")
                {
                    if (e.Damage >= e.Npc.life)
                    {
                        return;
                    }
                    int Damage = (Variables.playersData[e.Player.name].Warrior.statMeleeDamage);
                    if (Damage > 0)
                    {
                        NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, "+" + Damage, (int)c.PackedValue, e.Npc.position.X, e.Npc.position.Y, 0, 0, 0, 0);
                    }
                    e.Damage = e.Damage + Damage;
                    return;
                }
                if (Variables.playersData[e.Player.name].ActualClass == "paladin")
                {
                    if (e.Damage >= e.Npc.life)
                    {
                        return;
                    }
                    int Damage = (Variables.playersData[e.Player.name].Paladin.statMeleeDamage);
                    if (Damage > 0)
                    {
                        NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, "+" + Damage, (int)c.PackedValue, e.Npc.position.X, e.Npc.position.Y, 0, 0, 0, 0);
                    }
                    e.Damage = e.Damage + Damage;
                    return;
                }
                if (Variables.playersData[e.Player.name].ActualClass == "wizard")
                {
                    if (e.Damage >= e.Npc.life)
                    {
                        return;
                    }
                    int Damage = (Variables.playersData[e.Player.name].Wizard.statMeleeDamage * 3);
                    if (Damage > 0)
                    {
                        NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, "+" + Damage, (int)c.PackedValue, e.Npc.position.X, e.Npc.position.Y, 0, 0, 0, 0);
                    }
                    e.Damage = e.Damage + Damage;
                    return;
                }
            }

        }

    }
}
