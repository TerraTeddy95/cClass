using System;
using System.Collections.Generic;
using System.IO;
using TShockAPI;
using Newtonsoft.Json;

namespace cClass
{
    public class Config
    {
        public string Message1 = "[cClass] Your skill has been upgraded!";
        public string Message2 = "[cClass] You can't develop this skill more!";
        public string Message3 = "[cClass] You don't have enough stat points!";
        public string levelUp = "[%level%] Level Up!";
        public int Chance = 7;
        public List<int> BlockedNPCs = new List<int>() { 488, 49, 74, 46, 85, 67, 55, 230, 63, 64, 101, 242, 256, 58, 65, 21, 1 };
        public string levelCommand = "[%level%] %exp%/%neededexp% %percent%";
        public string startClass = "warrior";
        public Dictionary<string, Variables.informations> playersData = new Dictionary<string, Variables.informations>();
        public void Write(string path)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(this, Formatting.Indented));
        }
        public static Config Read(string path)
        {
            return File.Exists(path) ? JsonConvert.DeserializeObject<Config>(File.ReadAllText(path)) : new Config();
        }
    }
}