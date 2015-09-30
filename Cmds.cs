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
    class Cmds
    {
        public static void bestWarriorsCmd(CommandArgs e)
        {
            if (e.Player.IsLoggedIn == false)
            {
                e.Player.SendMessage("[cClass] Please login and try again!", Color.Silver);
                return;
            }
            if (!(Variables.playersData.ContainsKey(e.Player.Name)))
            {
                e.Player.SendMessage("[cClass] You don't have settings class! Please try reconnect!", Color.Silver);
                return;
            }
            var levels = Variables.playersData.Select(c => c.Value.Warrior.level).ToList();
            var players = Variables.playersData.Select(c => c.Key).ToList();

            int index;
            int loopTime;
            if (players.Count > 5)
            {
                loopTime = 5;
            }
            else
            {
                loopTime = players.Count;
            }
            for (int i = 1; i <= loopTime; i++)
            {
                index = levels.IndexOf(levels.Max());
                string playerName = players[index];
                int levelPlayer = levels[index];
                levels.RemoveAt(index);
                players.RemoveAt(index);
                if (i == 1)
                {
                    e.Player.SendMessage(i + ". " + playerName + " [" + levelPlayer + "]", Color.Red);
                }
                else
                {
                    e.Player.SendMessage(i + ". " + playerName + " [" + levelPlayer + "]", Color.Silver);
                }
            }
            return;

        }
        public static void bestPaladinsCmd(CommandArgs e)
        {
            if (e.Player.IsLoggedIn == false)
            {
                e.Player.SendMessage("[cClass] Please login and try again!", Color.Silver);
                return;
            }
            if (!(Variables.playersData.ContainsKey(e.Player.Name)))
            {
                e.Player.SendMessage("[cClass] You don't have settings class! Please try reconnect!", Color.Silver);
                return;
            }
            var levels = Variables.playersData.Select(c => c.Value.Paladin.level).ToList();
            var players = Variables.playersData.Select(c => c.Key).ToList();

            int index;
            int loopTime;
            if (players.Count > 5)
            {
                loopTime = 5;
            }
            else
            {
                loopTime = players.Count;
            }
            for (int i = 1; i <= loopTime; i++)
            {
                index = levels.IndexOf(levels.Max());
                string playerName = players[index];
                int levelPlayer = levels[index];
                levels.RemoveAt(index);
                players.RemoveAt(index);
                if (i == 1)
                {
                    e.Player.SendMessage(i + ". " + playerName + " [" + levelPlayer + "]", Color.Red);
                }
                else
                {
                    e.Player.SendMessage(i + ". " + playerName + " [" + levelPlayer + "]", Color.Silver);
                }
            }
            return;

        }
        public static void bestWizardsCmd(CommandArgs e)
        {
            if (e.Player.IsLoggedIn == false)
            {
                e.Player.SendMessage("[cClass] Please login and try again!", Color.Silver);
                return;
            }
            if (!(Variables.playersData.ContainsKey(e.Player.Name)))
            {
                e.Player.SendMessage("[cClass] You don't have settings class! Please try reconnect!", Color.Silver);
                return;
            }
            var levels = Variables.playersData.Select(c => c.Value.Wizard.level).ToList();
            var players = Variables.playersData.Select(c => c.Key).ToList();

            int index;
            int loopTime;
            if (players.Count > 5)
            {
                loopTime = 5;
            }
            else
            {
                loopTime = players.Count;
            }
            for (int i = 1; i <= loopTime; i++)
            {
                index = levels.IndexOf(levels.Max());
                string playerName = players[index];
                int levelPlayer = levels[index];
                levels.RemoveAt(index);
                players.RemoveAt(index);
                if (i == 1)
                {
                    e.Player.SendMessage(i + ". " + playerName + " [" + levelPlayer + "]", Color.Red);
                }
                else
                {
                    e.Player.SendMessage(i + ". " + playerName + " [" + levelPlayer + "]", Color.Silver);
                }
            }
            return;

        }
        public static void statCmd(CommandArgs e)
        {
            if (e.Player.IsLoggedIn == false)
            {
                e.Player.SendMessage("[cClass] Please login and try again!", Color.Silver);
                return;
            }
            if (!(Variables.playersData.ContainsKey(e.Player.Name)))
            {
                e.Player.SendMessage("[cClass] You don't have settings class! Please try reconnect!", Color.Silver);
                return;
            }
            if (e.Parameters.Count == 0)
            {
                e.Player.SendMessage("[cClass] /statsadd [hp/meleedmg/rangeddmg/magicdmg]", Color.Silver);
                return;
            }
            if (e.Parameters[0] == "hp" || e.Parameters[0] == "meleedmg" || e.Parameters[0] == "rangeddmg" || e.Parameters[0] == "magicdmg")
            {
                if (e.Parameters[0] == "hp")
                {
                    if (Variables.playersData[e.Player.Name].ActualClass == "warrior")
                    {
                        if (Variables.playersData[e.Player.Name].Warrior.statsPoints > 0)
                        {
                            if (e.Player.TPlayer.statLifeMax < 700)
                            {
                                Variables.playersData[e.Player.Name].Warrior.statsPoints--;
                                e.Player.TPlayer.statLifeMax = e.Player.TPlayer.statLifeMax + 3;
                                NetMessage.SendData(16, -1, -1, "", e.Player.Index, 0f, 0f, 0f, 0);
                                e.Player.SendMessage(Variables.Message1, Color.Silver);
                                return;
                            }
                            else
                            {
                                e.Player.SendMessage(Variables.Message2, Color.Silver);
                                return;
                            }
                        }
                        else
                        {
                            e.Player.SendMessage(Variables.Message3, Color.Silver);
                            return;
                        }
                    }
                    if (Variables.playersData[e.Player.Name].ActualClass == "paladin")
                    {
                        if (Variables.playersData[e.Player.Name].Paladin.statsPoints > 0)
                        {
                            if (e.Player.TPlayer.statLifeMax < 700)
                            {
                                Variables.playersData[e.Player.Name].Paladin.statsPoints--;
                                e.Player.TPlayer.statLifeMax = e.Player.TPlayer.statLifeMax + 3;
                                NetMessage.SendData(16, -1, -1, "", e.Player.Index, 0f, 0f, 0f, 0);
                                e.Player.SendMessage(Variables.Message1, Color.Silver);
                                return;
                            }
                            else
                            {
                                e.Player.SendMessage(Variables.Message2, Color.Silver);
                                return;
                            }
                        }
                        else
                        {
                            e.Player.SendMessage(Variables.Message3, Color.Silver);
                            return;
                        }
                    }
                    if (Variables.playersData[e.Player.Name].ActualClass == "wizard")
                    {
                        if (Variables.playersData[e.Player.Name].Wizard.statsPoints > 0)
                        {
                            if (e.Player.TPlayer.statLifeMax < 700)
                            {
                                Variables.playersData[e.Player.Name].Wizard.statsPoints--;
                                e.Player.TPlayer.statLifeMax = e.Player.TPlayer.statLifeMax + 3;
                                NetMessage.SendData(16, -1, -1, "", e.Player.Index, 0f, 0f, 0f, 0);
                                e.Player.SendMessage(Variables.Message1, Color.Silver);
                                return;
                            }
                            else
                            {
                                e.Player.SendMessage(Variables.Message2, Color.Silver);
                                return;
                            }
                        }
                        else
                        {
                            e.Player.SendMessage(Variables.Message3, Color.Silver);
                            return;
                        }
                    }
                }
                if (e.Parameters[0] == "meleedmg")
                {
                    if (Variables.playersData[e.Player.Name].ActualClass == "warrior")
                    {
                        if (Variables.playersData[e.Player.Name].Warrior.statsPoints > 0)
                        {
                            if (Variables.playersData[e.Player.Name].Warrior.statMeleeDamage < 50)
                            {
                                Variables.playersData[e.Player.Name].Warrior.statsPoints--;
                                Variables.playersData[e.Player.Name].Warrior.statMeleeDamage++;
                                e.Player.SendMessage(Variables.Message1, Color.Silver);
                                return;
                            }
                            else
                            {
                                e.Player.SendMessage(Variables.Message2, Color.Silver);
                                return;
                            }
                        }
                        else
                        {
                            e.Player.SendMessage(Variables.Message3, Color.Silver);
                            return;
                        }
                    }
                    if (Variables.playersData[e.Player.Name].ActualClass == "paladin")
                    {
                        if (Variables.playersData[e.Player.Name].Paladin.statsPoints > 0)
                        {
                            if (Variables.playersData[e.Player.Name].Paladin.statMeleeDamage < 50)
                            {
                                Variables.playersData[e.Player.Name].Paladin.statsPoints--;
                                Variables.playersData[e.Player.Name].Paladin.statMeleeDamage++;
                                e.Player.SendMessage(Variables.Message1, Color.Silver);
                                return;
                            }
                            else
                            {
                                e.Player.SendMessage(Variables.Message2, Color.Silver);
                                return;
                            }
                        }
                        else
                        {
                            e.Player.SendMessage(Variables.Message3, Color.Silver);
                            return;
                        }
                    }
                    if (Variables.playersData[e.Player.Name].ActualClass == "wizard")
                    {
                        if (Variables.playersData[e.Player.Name].Wizard.statsPoints > 0)
                        {
                            if (Variables.playersData[e.Player.Name].Wizard.statMeleeDamage < 50)
                            {
                                Variables.playersData[e.Player.Name].Wizard.statsPoints--;
                                Variables.playersData[e.Player.Name].Wizard.statMeleeDamage++;
                                e.Player.SendMessage(Variables.Message1, Color.Silver);
                                return;
                            }
                            else
                            {
                                e.Player.SendMessage(Variables.Message2, Color.Silver);
                                return;
                            }
                        }
                        else
                        {
                            e.Player.SendMessage(Variables.Message3, Color.Silver);
                            return;
                        }
                    }
                }
                if (e.Parameters[0] == "rangeddmg")
                {
                    if (Variables.playersData[e.Player.Name].ActualClass == "warrior")
                    {
                        if (Variables.playersData[e.Player.Name].Warrior.statsPoints > 0)
                        {
                            if (Variables.playersData[e.Player.Name].Warrior.statRangedDamage < 50)
                            {
                                Variables.playersData[e.Player.Name].Warrior.statsPoints--;
                                Variables.playersData[e.Player.Name].Warrior.statRangedDamage++;
                                e.Player.SendMessage(Variables.Message1, Color.Silver);
                                return;
                            }
                            else
                            {
                                e.Player.SendMessage(Variables.Message2, Color.Silver);
                                return;
                            }
                        }
                        else
                        {
                            e.Player.SendMessage(Variables.Message3, Color.Silver);
                            return;
                        }
                    }
                    if (Variables.playersData[e.Player.Name].ActualClass == "paladin")
                    {
                        if (Variables.playersData[e.Player.Name].Paladin.statsPoints > 0)
                        {
                            if (Variables.playersData[e.Player.Name].Paladin.statRangedDamage < 50)
                            {
                                Variables.playersData[e.Player.Name].Paladin.statsPoints--;
                                Variables.playersData[e.Player.Name].Paladin.statRangedDamage++;
                                e.Player.SendMessage(Variables.Message1, Color.Silver);
                                return;
                            }
                            else
                            {
                                e.Player.SendMessage(Variables.Message2, Color.Silver);
                                return;
                            }
                        }
                        else
                        {
                            e.Player.SendMessage(Variables.Message3, Color.Silver);
                            return;
                        }
                    }
                    if (Variables.playersData[e.Player.Name].ActualClass == "wizard")
                    {
                        if (Variables.playersData[e.Player.Name].Wizard.statsPoints > 0)
                        {
                            if (Variables.playersData[e.Player.Name].Wizard.statRangedDamage < 50)
                            {
                                Variables.playersData[e.Player.Name].Wizard.statsPoints--;
                                Variables.playersData[e.Player.Name].Wizard.statRangedDamage++;
                                e.Player.SendMessage(Variables.Message1, Color.Silver);
                                return;
                            }
                            else
                            {
                                e.Player.SendMessage(Variables.Message2, Color.Silver);
                                return;
                            }
                        }
                        else
                        {
                            e.Player.SendMessage(Variables.Message3, Color.Silver);
                            return;
                        }
                    }
                }
                if (e.Parameters[0] == "magicdmg")
                {
                    if (Variables.playersData[e.Player.Name].ActualClass == "warrior")
                    {
                        if (Variables.playersData[e.Player.Name].Warrior.statsPoints > 0)
                        {
                            if (Variables.playersData[e.Player.Name].Warrior.statMagicDamage < 50)
                            {
                                Variables.playersData[e.Player.Name].Warrior.statsPoints--;
                                Variables.playersData[e.Player.Name].Warrior.statMagicDamage++;
                                e.Player.SendMessage(Variables.Message1, Color.Silver);
                                return;
                            }
                            else
                            {
                                e.Player.SendMessage(Variables.Message2, Color.Silver);
                                return;
                            }
                        }
                        else
                        {
                            e.Player.SendMessage(Variables.Message3, Color.Silver);
                            return;
                        }
                    }
                    if (Variables.playersData[e.Player.Name].ActualClass == "paladin")
                    {
                        if (Variables.playersData[e.Player.Name].Paladin.statsPoints > 0)
                        {
                            if (Variables.playersData[e.Player.Name].Paladin.statMagicDamage < 50)
                            {
                                Variables.playersData[e.Player.Name].Paladin.statsPoints--;
                                Variables.playersData[e.Player.Name].Paladin.statMagicDamage++;
                                e.Player.SendMessage(Variables.Message1, Color.Silver);
                                return;
                            }
                            else
                            {
                                e.Player.SendMessage(Variables.Message2, Color.Silver);
                                return;
                            }
                        }
                        else
                        {
                            e.Player.SendMessage(Variables.Message3, Color.Silver);
                            return;
                        }
                    }
                    if (Variables.playersData[e.Player.Name].ActualClass == "wizard")
                    {
                        if (Variables.playersData[e.Player.Name].Wizard.statsPoints > 0)
                        {
                            if (Variables.playersData[e.Player.Name].Wizard.statMagicDamage < 50)
                            {
                                Variables.playersData[e.Player.Name].Wizard.statsPoints--;
                                Variables.playersData[e.Player.Name].Wizard.statMagicDamage++;
                                e.Player.SendMessage(Variables.Message1, Color.Silver);
                                return;
                            }
                            else
                            {
                                e.Player.SendMessage(Variables.Message2, Color.Silver);
                                return;
                            }
                        }
                        else
                        {
                            e.Player.SendMessage(Variables.Message3, Color.Silver);
                            return;
                        }
                    }
                }
                return;
            }
            else
            {
                e.Player.SendMessage("[cClass] /statsadd [hp/meleedmg/rangeddmg/magicdmg]", Color.Silver);
                return;
            }
        }
        public static void wizardCmd(CommandArgs e)
        {
            if (e.Player.IsLoggedIn == false)
            {
                e.Player.SendMessage("[cClass] Please login and try again!", Color.Silver);
                return;
            }
            if (!(Variables.playersData.ContainsKey(e.Player.Name)))
            {
                e.Player.SendMessage("[cClass] You don't have settings class! Please try reconnect!", Color.Silver);
                return;
            }
            if (Variables.playersData[e.Player.Name].ActualClass == "wizard")
            {
                e.Player.SendMessage("[cClass] Your actual class is already Wizard!", Color.Silver);
                return;
            }

            if (Variables.playersData[e.Player.Name].ActualClass == "paladin")
            {
                Inventory.saveBar(e.Player, "paladin");
                Inventory.saveEquipment(e.Player, "paladin");
            }
            if (Variables.playersData[e.Player.Name].ActualClass == "warrior")
            {
                Inventory.saveBar(e.Player, "warrior");
                Inventory.saveEquipment(e.Player, "warrior");
            }

            Variables.playersData[e.Player.Name].ActualClass = "wizard";
            Inventory.loadBar(e.Player, "wizard");
            Inventory.loadEquipment(e.Player, "wizard");
            return;
        }
        public static void paladinCmd(CommandArgs e)
        {
            if (e.Player.IsLoggedIn == false)
            {
                e.Player.SendMessage("[cClass] Please login and try again!", Color.Silver);
                return;
            }
            if (!(Variables.playersData.ContainsKey(e.Player.Name)))
            {
                e.Player.SendMessage("[cClass] You don't have settings class! Please try reconnect!", Color.Silver);
                return;
            }
            if (Variables.playersData[e.Player.Name].ActualClass == "paladin")
            {
                e.Player.SendMessage("[cClass] Your actual class is already Paladin!", Color.Silver);
                return;
            }

            if (Variables.playersData[e.Player.Name].ActualClass == "warrior")
            {
                Inventory.saveBar(e.Player, "warrior");
                Inventory.saveEquipment(e.Player, "warrior");
            }
            if (Variables.playersData[e.Player.Name].ActualClass == "wizard")
            {
                Inventory.saveBar(e.Player, "wizard");
                Inventory.saveEquipment(e.Player, "wizard");
            }

            Variables.playersData[e.Player.Name].ActualClass = "paladin";
            Inventory.loadBar(e.Player, "paladin");
            Inventory.loadEquipment(e.Player, "paladin");
            return;
        }
        public static void warriorCmd(CommandArgs e)
        {
            if (e.Player.IsLoggedIn == false)
            {
                e.Player.SendMessage("[cClass] Please login and try again!", Color.Silver);
                return;
            }
            if (!(Variables.playersData.ContainsKey(e.Player.Name)))
            {
                e.Player.SendMessage("[cClass] You don't have settings class! Please try reconnect!", Color.Silver);
                return;
            }
            if (Variables.playersData[e.Player.Name].ActualClass == "warrior")
            {
                e.Player.SendMessage("[cClass] Your actual class is already Warrior!", Color.Silver);
                return;
            }

            if (Variables.playersData[e.Player.Name].ActualClass == "paladin")
            {
                Inventory.saveBar(e.Player, "paladin");
                Inventory.saveEquipment(e.Player, "paladin");
            }
            if (Variables.playersData[e.Player.Name].ActualClass == "wizard")
            {
                Inventory.saveBar(e.Player, "wizard");
                Inventory.saveEquipment(e.Player, "wizard");
            }

            Variables.playersData[e.Player.Name].ActualClass = "warrior";
            Inventory.loadBar(e.Player, "warrior");
            Inventory.loadEquipment(e.Player, "warrior");
            return;
        }
        public static void levelCmd(CommandArgs e)
        {
            if (e.Player.IsLoggedIn == false)
            {
                e.Player.SendMessage("[cClass] Please login and try again!", Color.Silver);
                return;
            }
            if (!(Variables.playersData.ContainsKey(e.Player.Name)))
            {
                e.Player.SendMessage("[cClass] You don't have settings class! Please try reconnect!", Color.Silver);
                return;
            }
            Color c = new Color(255, 120, 0);
            if (Variables.playersData[e.Player.Name].ActualClass == "warrior")
            {
                string message = Variables.levelCommand.Replace("%level%", Variables.playersData[e.Player.Name].Warrior.level + "");
                message = message.Replace("%exp%", Variables.playersData[e.Player.Name].Warrior.exprience + "");
                message = message.Replace("%neededexp%", Variables.playersData[e.Player.Name].Warrior.level * (896 + (896 * 43 / 100)) + "");
                message = message.Replace("%percent%", ((Variables.playersData[e.Player.Name].Warrior.exprience * 100) / Variables.playersData[e.Player.Name].Warrior.level * (896 + (896 * 43 / 100))) + "%");
                NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, message, (int)c.PackedValue, e.Player.X, e.Player.Y, 0, 0, 0, 0);
                return;
            }
            if (Variables.playersData[e.Player.Name].ActualClass == "paladin")
            {
                string message = Variables.levelCommand.Replace("%level%", Variables.playersData[e.Player.Name].Paladin.level + "");
                message = message.Replace("%exp%", Variables.playersData[e.Player.Name].Paladin.exprience + "");
                message = message.Replace("%neededexp%", Variables.playersData[e.Player.Name].Paladin.level * (896 + (896 * 43 / 100)) + "");
                message = message.Replace("%percent%", ((Variables.playersData[e.Player.Name].Paladin.exprience * 100) / Variables.playersData[e.Player.Name].Paladin.level * (896 + (896 * 43 / 100))) + "%");
                NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, message, (int)c.PackedValue, e.Player.X, e.Player.Y, 0, 0, 0, 0);
                return;
            }
            if (Variables.playersData[e.Player.Name].ActualClass == "wizard")
            {
                string message = Variables.levelCommand.Replace("%level%", Variables.playersData[e.Player.Name].Wizard.level + "");
                message = message.Replace("%exp%", Variables.playersData[e.Player.Name].Wizard.exprience + "");
                message = message.Replace("%neededexp%", Variables.playersData[e.Player.Name].Wizard.level * (896 + (896 * 43 / 100)) + "");
                message = message.Replace("%percent%", ((Variables.playersData[e.Player.Name].Wizard.exprience * 100) / Variables.playersData[e.Player.Name].Wizard.level * (896 + (896 * 43 / 100))) + "%");
                NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, message, (int)c.PackedValue, e.Player.X, e.Player.Y, 0, 0, 0, 0);
                return;
            }
        }
    }
}