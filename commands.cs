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
    class commands
    {
        public static void statCmd(CommandArgs e)
        {
            int index = vars.warrior.FindIndex(w => w.player == e.Player.Name);
            if (e.Player.Index == -1) //CHECK WHO SEND (CONSOLE OR PLAYER)
            {
                Console.WriteLine("[cClass] You can't use this command from console!");
                return;
            }
            if (e.Player.IsLoggedIn == false)
            {
                e.Player.SendMessage("[cClass] Please login and try again!", Color.Silver);
                return;
            }
            if (index == -1)
            {
                e.Player.SendMessage("[cClass] You don't have settings class! Please try reconnect!", Color.Silver);
                return;
            }
            if (e.Parameters.Count == 0)
            {
                e.Player.SendMessage("[cClass] /statsadd [hp/meeledmg/rangeddmg/magicdmg]", Color.Silver);
                return;
            }
            if (e.Parameters[0] == "hp" || e.Parameters[0] == "meeledmg" || e.Parameters[0] == "rangeddmg" || e.Parameters[0] == "magicdmg")
            {
                if (e.Parameters[0] == "magicdmg")
                {
                    if (vars.informations[index].actualClass == "wizard")
                    {
                        if (vars.wizard[index].statsPoints > 0)
                        {
                            if (vars.wizard[index].statMagicDamage < 51)
                            {
                                vars.wizard[index].statsPoints--;
                                vars.wizard[index].statMagicDamage++;
                                e.Player.SendMessage("[cClass] Your skill has been upgraded!", Color.Silver);
                                return;
                            }
                            else
                            {
                                e.Player.SendMessage("[cClass] You can't develop this skill more!", Color.Silver);
                                return;
                            }
                        }
                        else
                        {
                            e.Player.SendMessage("[cClass] You don't have enough stat points!", Color.Silver);
                            return;
                        }
                    }
                    if (vars.informations[index].actualClass == "paladin")
                    {
                        if (vars.paladin[index].statsPoints > 0)
                        {
                            if (vars.paladin[index].statMagicDamage < 51)
                            {
                                vars.paladin[index].statsPoints--;
                                vars.paladin[index].statMagicDamage++;
                                e.Player.SendMessage("[cClass] Your skill has been upgraded!", Color.Silver);
                                return;
                            }
                            else
                            {
                                e.Player.SendMessage("[cClass] You can't develop this skill more!", Color.Silver);
                                return;
                            }
                        }
                        else
                        {
                            e.Player.SendMessage("[cClass] You don't have enough stat points!", Color.Silver);
                            return;
                        }
                    }
                    if (vars.informations[index].actualClass == "warrior")
                    {
                        if (vars.warrior[index].statsPoints > 0)
                        {
                            if (vars.warrior[index].statMagicDamage < 51)
                            {
                                vars.warrior[index].statsPoints--;
                                vars.warrior[index].statMagicDamage++;
                                e.Player.SendMessage("[cClass] Your skill has been upgraded!", Color.Silver);
                                return;
                            }
                            else
                            {
                                e.Player.SendMessage("[cClass] You can't develop this skill more!", Color.Silver);
                                return;
                            }
                        }
                        else
                        {
                            e.Player.SendMessage("[cClass] You don't have enough stat points!", Color.Silver);
                            return;
                        }
                    }
                }
                if (e.Parameters[0] == "rangeddmg")
                {
                    if (vars.informations[index].actualClass == "wizard")
                    {
                        if (vars.wizard[index].statsPoints > 0)
                        {
                            if (vars.wizard[index].statRangedDamage++ < 51)
                            {
                                vars.wizard[index].statsPoints--;
                                vars.wizard[index].statRangedDamage++;
                                e.Player.SendMessage("[cClass] Your skill has been upgraded!", Color.Silver);
                                return;
                            }
                            else
                            {
                                e.Player.SendMessage("[cClass] You can't develop this skill more!", Color.Silver);
                                return;
                            }
                        }
                        else
                        {
                            e.Player.SendMessage("[cClass] You don't have enough stat points!", Color.Silver);
                            return;
                        }
                    }
                    if (vars.informations[index].actualClass == "paladin")
                    {
                        if (vars.paladin[index].statsPoints > 0)
                        {
                            if (vars.paladin[index].statRangedDamage++ < 51)
                            {
                                vars.paladin[index].statsPoints--;
                                vars.paladin[index].statRangedDamage++;
                                e.Player.SendMessage("[cClass] Your skill has been upgraded!", Color.Silver);
                                return;
                            }
                            else
                            {
                                e.Player.SendMessage("[cClass] You can't develop this skill more!", Color.Silver);
                                return;
                            }
                        }
                        else
                        {
                            e.Player.SendMessage("[cClass] You don't have enough stat points!", Color.Silver);
                            return;
                        }
                    }
                    if (vars.informations[index].actualClass == "warrior")
                    {
                        if (vars.warrior[index].statsPoints > 0)
                        {
                            if (vars.warrior[index].statRangedDamage++ < 51)
                            {
                                vars.warrior[index].statsPoints--;
                                vars.warrior[index].statRangedDamage++;
                                e.Player.SendMessage("[cClass] Your skill has been upgraded!", Color.Silver);
                                return;
                            }
                            else
                            {
                                e.Player.SendMessage("[cClass] You can't develop this skill more!", Color.Silver);
                                return;
                            }
                        }
                        else
                        {
                            e.Player.SendMessage("[cClass] You don't have enough stat points!", Color.Silver);
                            return;
                        }
                    }
                }
                if (e.Parameters[0] == "meeledmg")
                {
                    if (vars.informations[index].actualClass == "wizard")
                    {
                        if (vars.wizard[index].statsPoints > 0)
                        {
                            if (vars.wizard[index].statMeeleDamage < 51)
                            {
                                vars.wizard[index].statsPoints--;
                                vars.wizard[index].statMeeleDamage++;
                                e.Player.SendMessage("[cClass] Your skill has been upgraded!", Color.Silver);
                                return;
                            }
                            else
                            {
                                e.Player.SendMessage("[cClass] You can't develop this skill more!", Color.Silver);
                                return;
                            }
                        }
                        else
                        {
                            e.Player.SendMessage("[cClass] You don't have enough stat points!", Color.Silver);
                            return;
                        }
                    }
                    if (vars.informations[index].actualClass == "paladin")
                    {
                        if (vars.paladin[index].statsPoints > 0)
                        {
                            if (vars.paladin[index].statMeeleDamage < 51)
                            {
                                vars.paladin[index].statsPoints--;
                                vars.paladin[index].statMeeleDamage++;
                                e.Player.SendMessage("[cClass] Your skill has been upgraded!", Color.Silver);
                                return;
                            }
                            else
                            {
                                e.Player.SendMessage("[cClass] You can't develop this skill more!", Color.Silver);
                                return;
                            }
                        }
                        else
                        {
                            e.Player.SendMessage("[cClass] You don't have enough stat points!", Color.Silver);
                            return;
                        }
                    }
                    if (vars.informations[index].actualClass == "warrior")
                    {
                        if (vars.warrior[index].statsPoints > 0)
                        {
                            if (vars.warrior[index].statMeeleDamage < 51)
                            {
                                vars.warrior[index].statsPoints--;
                                vars.warrior[index].statMeeleDamage++;
                                e.Player.SendMessage("[cClass] Your skill has been upgraded!", Color.Silver);
                                return;
                            }
                            else
                            {
                                e.Player.SendMessage("[cClass] You can't develop this skill more!", Color.Silver);
                                return;
                            }
                        }
                        else
                        {
                            e.Player.SendMessage("[cClass] You don't have enough stat points!", Color.Silver);
                            return;
                        }
                    }
                }
                if (e.Parameters[0] == "hp")
                {
                    if (vars.informations[index].actualClass == "warrior")
                    {
                        if (vars.warrior[index].statsPoints > 0)
                        {
                            if (e.Player.TPlayer.statLifeMax < 700)
                            {
                                vars.warrior[index].statsPoints--;
                                e.Player.TPlayer.statLifeMax = e.Player.TPlayer.statLifeMax + 3;
                                NetMessage.SendData(16, -1, -1, "", e.Player.Index, 0f, 0f, 0f, 0);
                                vars.warrior[index].statHP++;

                                e.Player.SendMessage("[cClass] Your skill has been upgraded!", Color.Silver);
                                return;
                            }
                            else
                            {
                                e.Player.SendMessage("[cClass] You can't develop this skill more!", Color.Silver);
                                return;
                            }
                        }
                        else
                        {
                            e.Player.SendMessage("[cClass] You don't have enough stat points!", Color.Silver);
                            return;
                        }
                    }
                    if (vars.informations[index].actualClass == "paladin")
                    {
                        if (vars.paladin[index].statsPoints > 0)
                        {
                            if (e.Player.TPlayer.statLifeMax < 700)
                            {
                                vars.paladin[index].statsPoints--;
                                e.Player.TPlayer.statLifeMax = e.Player.TPlayer.statLifeMax + 3;
                                NetMessage.SendData(16, -1, -1, "", e.Player.Index, 0f, 0f, 0f, 0);
                                vars.paladin[index].statHP++;
                                e.Player.SendMessage("[cClass] Your skill has been upgraded!", Color.Silver);
                                return;
                            }
                            else
                            {
                                e.Player.SendMessage("[cClass] You can't develop this skill more!", Color.Silver);
                                return;
                            }
                        }
                        else
                        {
                            e.Player.SendMessage("[cClass] You don't have enough stat points!", Color.Silver);
                            return;
                        }
                    }
                    if (vars.informations[index].actualClass == "wizard")
                    {
                        if (vars.wizard[index].statsPoints > 0)
                        {
                            if (e.Player.TPlayer.statLifeMax < 700)
                            {
                                vars.wizard[index].statsPoints--;
                                e.Player.TPlayer.statLifeMax = e.Player.TPlayer.statLifeMax + 3;
                                NetMessage.SendData(16, -1, -1, "", e.Player.Index, 0f, 0f, 0f, 0);
                                vars.wizard[index].statHP++;
                                e.Player.SendMessage("[cClass] Your skill has been upgraded!", Color.Silver);
                                return;
                            }
                            else
                            {
                                e.Player.SendMessage("[cClass] You can't develop this skill more!", Color.Silver);
                                return;
                            }
                        }
                        else
                        {
                            e.Player.SendMessage("[cClass] You don't have enough stat points!", Color.Silver);
                            return;
                        }
                    }
                }
            }
            else
            {
                e.Player.SendMessage("[cClass] /statsadd [hp/meeledmg/rangeddmg/magicdmg]", Color.Silver);
                return;
            }
        }
        public static void levelCmd(CommandArgs e)
        {
            int index = vars.warrior.FindIndex(w => w.player == e.Player.Name);
            if (e.Player.Index == -1) //CHECK WHO SEND (CONSOLE OR PLAYER)
            {
                Console.WriteLine("[cClass] You can't use this command from console!");
                return;
            }
            if (e.Player.IsLoggedIn == false)
            {
                e.Player.SendMessage("[cClass] Please login and try again!", Color.Silver);
                return;
            }
            if (index == -1)
            {
                e.Player.SendMessage("[cClass] You don't have settings class! Please try reconnect!", Color.Silver);
                return;
            }

            string actualClass = vars.informations[index].actualClass;
            Color c = new Color(255, 120, 0);

            if (actualClass == "warrior")
            {
                int lvl = vars.warrior[index].level;
                int exp = vars.warrior[index].exprience;
                int neededExpForLevelUp = vars.warrior[index].level * (896 + (896 * 43 / 100));
                int percent = exp * 100 / neededExpForLevelUp;
                //[1LVL] [2000/4000] - 45%
                NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, "[" + lvl + "LVL] [" + exp + "/" + neededExpForLevelUp + "] " +  percent + "%", (int)c.PackedValue, e.Player.X, e.Player.Y, 0, 0, 0, 0);
                return;
            }
            if (actualClass == "paladin")
            {
                int neededExpForLevelUp = vars.paladin[index].level * (896 + (896 * 43 / 100));
                int lvl = vars.paladin[index].level;
                int exp = vars.paladin[index].exprience;
                //[1LVL] [2000/4000] - 45%
                int percent = exp * 100 / neededExpForLevelUp;
                NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, "[" + lvl + "LVL] [" + exp + "/" + neededExpForLevelUp + "] " + percent + "%", (int)c.PackedValue, e.Player.X, e.Player.Y, 0, 0, 0, 0);
                return;
            }
            if (actualClass == "wizard")
            {
                int neededExpForLevelUp = vars.wizard[index].level * (896 + (896 * 43 / 100));
                int lvl = vars.wizard[index].level;
                int exp = vars.wizard[index].exprience;
                //[1LVL] [2000/4000] - 45%
                int percent = exp * 100 / neededExpForLevelUp;
                NetMessage.SendData((int)PacketTypes.CreateCombatText, -1, -1, "[" + lvl + "LVL] [" + exp + "/" + neededExpForLevelUp + "] " + percent + "%", (int)c.PackedValue, e.Player.X, e.Player.Y, 0, 0, 0, 0);
                return;
            }
        }
        public static void warriorCmd(CommandArgs e)
        {
            if (e.Player.Index == -1) //CHECK WHO SEND (CONSOLE OR PLAYER)
            {
                Console.WriteLine("[cClass] You can't use this command from console!");
                return;
            }
            if (e.Player.IsLoggedIn == false)
            {
                e.Player.SendMessage("[cClass] Please login and try again!", Color.Silver);
                return;
            }
            int index = vars.warrior.FindIndex(w => w.player == e.Player.Name);
            if (index == -1)
            {
                e.Player.SendMessage("[cClass] You don't have settings class! Please try reconnect!", Color.Silver);
                return;
            }
            string actualClass = vars.informations[index].actualClass;
            if (actualClass == "warrior")
            {
                e.Player.SendMessage("[cClass] Your actual class is already Warrior!", Color.Silver);
                return;
            }

            if (actualClass == "wizard")
            {
                inventory.saveEquipment(index, "wizard");
                inventory.saveBar(index, "wizard");
            }
            if (actualClass == "paladin")
            {
                inventory.saveEquipment(index, "paladin");
                inventory.saveBar(index, "paladin");
            }
            inventory.loadEquipment(index, "warrior");
            inventory.loadBar(index, "warrior");
            vars.informations[index].actualClass = "warrior";
            e.Player.SendMessage("[cClass] Class has been changed to Warrior", Color.Silver);
            return;
        }

        public static void paladinCmd(CommandArgs e)
        {
            if (e.Player.Index == -1) //CHECK WHO SEND (CONSOLE OR PLAYER)
            {
                Console.WriteLine("[cClass] You can't use this command from console!");
                return;
            }
            if (e.Player.IsLoggedIn == false)
            {
                e.Player.SendMessage("[cClass] Please login and try again!", Color.Silver);
                return;
            }
            int index = vars.warrior.FindIndex(w => w.player == e.Player.Name);
            if (index == -1)
            {
                e.Player.SendMessage("[cClass] You don't have settings class! Please try reconnect!", Color.Silver);
                return;
            }
            string actualClass = vars.informations[index].actualClass;
            if (actualClass == "paladin")
            {
                e.Player.SendMessage("[cClass] Your actual class is already Paladin!", Color.Silver);
                return;
            }

            if (actualClass == "wizard")
            {
                inventory.saveEquipment(index, "wizard");
                inventory.saveBar(index, "wizard");
            }
            if (actualClass == "warrior")
            {
                inventory.saveEquipment(index, "warrior");
                inventory.saveBar(index, "warrior");
            }
            inventory.loadEquipment(index, "paladin");
            inventory.loadBar(index, "paladin");
            vars.informations[index].actualClass = "paladin";
            e.Player.SendMessage("[cClass] Class has been changed to Paladin", Color.Silver);
            return;
        }
        public static void wizardCmd(CommandArgs e)
        {
            if (e.Player.Index == -1) //CHECK WHO SEND (CONSOLE OR PLAYER)
            {
                Console.WriteLine("[cClass] You can't use this command from console!");
                return;
            }
            if (e.Player.IsLoggedIn == false)
            {
                e.Player.SendMessage("[cClass] Please login and try again!", Color.Silver);
                return;
            }
            int index = vars.warrior.FindIndex(w => w.player == e.Player.Name);
            if (index == -1)
            {
                e.Player.SendMessage("[cClass] You don't have settings class! Please try reconnect!", Color.Silver);
                return;
            }
            string actualClass = vars.informations[index].actualClass;
            if (actualClass == "wizard")
            {
                e.Player.SendMessage("[cClass] Your actual class is already Wizard!", Color.Silver);
                return;
            }

            if (actualClass == "warrior")
            {
                inventory.saveEquipment(index, "warrior");
                inventory.saveBar(index, "warrior");
            }
            if (actualClass == "paladin")
            {
                inventory.saveEquipment(index, "paladin");
                inventory.saveBar(index, "paladin");
            }
            inventory.loadEquipment(index, "wizard");
            inventory.loadBar(index, "wizard");
            vars.informations[index].actualClass = "wizard";
            e.Player.SendMessage("[cClass] Class has been changed to Wizard", Color.Silver);
            return;
        }
    }
}
