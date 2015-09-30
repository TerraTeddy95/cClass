using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using TShockAPI;
using TerrariaApi.Server;

namespace cClass
{
    public class Variables
    {
        public static string Message1 = "[cClass] Your skill has been upgraded!";
        public static string Message2 = "[cClass] You can't develop this skill more!";
        public static string Message3 = "[cClass] You don't have enough stat points!";
        public static string levelUp = "[%level%] Level Up!";
        public static int Chance = 7;
        public static List<int> BlockedNPCs = new List<int>() { 488, 49, 74, 46, 85, 67, 55, 230, 63, 64, 101, 242, 256, 58, 65, 21, 1 };
        public static string levelCommand = "[%level%] %exp%/%neededexp% %percent%";
        public static string startClass = "warrior";
        public static Dictionary<string, Variables.informations> playersData = new Dictionary<string, Variables.informations>();
        public class informations
        {
            public string ActualClass = "warrior";
            public Warrior Warrior = new Warrior() { };
            public Paladin Paladin = new Paladin() { };
            public Wizard Wizard = new Wizard() { };
        }
        public class Warrior
        {
            public List<int> itemsBarNetID = new List<int>();
            public List<int> itemsBarPrefix = new List<int>();
            public List<int> itemsBarStack = new List<int>();

            public List<int> itemsArmorNetID = new List<int>();
            public List<int> itemsArmorPrefix = new List<int>();

            public int level = 1;
            public int exprience = 0;
            public int statsPoints = 0;

            public int statMeleeDamage = 0;
            public int statRangedDamage = 0;
            public int statMagicDamage = 0;
        }
        public class Paladin
        {
            public List<int> itemsBarNetID = new List<int>();
            public List<int> itemsBarPrefix = new List<int>();
            public List<int> itemsBarStack = new List<int>();

            public List<int> itemsArmorNetID = new List<int>();
            public List<int> itemsArmorPrefix = new List<int>();

            public int level = 1;
            public int exprience = 0;
            public int statsPoints = 0;

            public int statMeleeDamage = 0;
            public int statRangedDamage = 0;
            public int statMagicDamage = 0;
        }
        public class Wizard
        {
            public List<int> itemsBarNetID = new List<int>();
            public List<int> itemsBarPrefix = new List<int>();
            public List<int> itemsBarStack = new List<int>();

            public List<int> itemsArmorNetID = new List<int>();
            public List<int> itemsArmorPrefix = new List<int>();

            public int level = 1;
            public int exprience = 0;
            public int statsPoints = 0;

            public int statMeleeDamage = 0;
            public int statRangedDamage = 0;
            public int statMagicDamage = 0;
        }
    }
}