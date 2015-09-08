using System;
using System.Collections.Generic;
using System.IO;
using TShockAPI;
using Newtonsoft.Json;

namespace cClass
{
    public class Config
    {


        public List<vars.Warrior> Warrior = new List<vars.Warrior>();
        public List<vars.Paladin> Paladin = new List<vars.Paladin>();
        public List<vars.Wizard> Wizard = new List<vars.Wizard>();
        public List<vars.playerInformation> informations = new List<vars.playerInformation>();

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