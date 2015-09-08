using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cClass
{
    public class vars
    {
        public static List<Warrior> warrior = new List<Warrior>();
        public static List<Paladin> paladin = new List<Paladin>();
        public static List<Wizard> wizard = new List<Wizard>();
        public static List<playerInformation> informations = new List<playerInformation>();

        public class playerInformation
        {
            public string actualClass;
        }
        public class Warrior
        {
            public string player;
            public List<int> itemsBarNetID = new List<int>();
            public List<int> itemsBarPrefix = new List<int>();
            public List<int> itemsBarStack = new List<int>();
            public List<string> itemsBarName = new List<string>();

            public List<int> itemsArmorNetID = new List<int>();
            public List<int> itemsArmorPrefix = new List<int>();
            public List<int> itemsArmorStack = new List<int>();
            public List<string> itemsArmorName = new List<string>();

            public int level = 1;
            public int exprience = 0;
            public int statsPoints = 0;

            public int statHP = 0;
            public int statMana = 0;
            public int statHealthRegeneration = 0;

            public int statMeeleDamage = 0;
            public int statRangedDamage = 0;
            public int statMagicDamage = 0;
        }
        public class Paladin
        {
            public string player;
            public List<int> itemsBarNetID = new List<int>();
            public List<int> itemsBarPrefix = new List<int>();
            public List<int> itemsBarStack = new List<int>();
            public List<string> itemsBarName = new List<string>();

            public List<int> itemsArmorNetID = new List<int>();
            public List<int> itemsArmorPrefix = new List<int>();
            public List<int> itemsArmorStack = new List<int>();
            public List<string> itemsArmorName = new List<string>();

            public int level = 1;
            public int exprience = 0;
            public int statsPoints = 0;

            public int statHP = 0;
            public int statMana = 0;
            public int statHealthRegeneration = 0;

            public int statMeeleDamage = 0;
            public int statRangedDamage = 0;
            public int statMagicDamage = 0;
        }
        public class Wizard
        {
            public string player;
            public List<int> itemsBarNetID = new List<int>();
            public List<int> itemsBarPrefix = new List<int>();
            public List<int> itemsBarStack = new List<int>();
            public List<string> itemsBarName = new List<string>();

            public List<int> itemsArmorNetID = new List<int>();
            public List<int> itemsArmorPrefix = new List<int>();
            public List<int> itemsArmorStack = new List<int>();
            public List<string> itemsArmorName = new List<string>();

            public int level = 1;
            public int exprience = 0;
            public int statsPoints = 0;

            public int statHP = 0;
            public int statMana = 0;
            public int statHealthRegeneration = 0;

            public int statMeeleDamage = 0;
            public int statRangedDamage = 0;
            public int statMagicDamage = 0;
        }
    }
}
