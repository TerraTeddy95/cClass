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
        public string levelCommand = "[%level%] %exp%/%neededexp% %percent%";
        public string startClass = "warrior";
        public Dictionary<int, bool> blockedNPCs = new Dictionary<int, bool>() { { 448, true }, {49, true}, {74, true}, {46, true}, {85, true}, {67, true}, {55, true}, {230, true}, {63, true}, {64, true}, {101, true}, {242, true}, {256, true}, {58, true}, {65, true}, {21, true}, {1, true}};
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