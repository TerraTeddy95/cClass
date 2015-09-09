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
    [ApiVersion(1, 21)]
    public class main : TerrariaPlugin
    {

        public static Config Config;

        public main(Main game) : base(game) { Order -= 1; }

        public override Version Version { get { return new Version("1.1"); } }
        public override string Name { get { return "cClass"; } }
        public override string Author { get { return "Teddy"; } }
        public override string Description { get { return "Classes And Levels"; } }

        public override void Initialize()
        {
            string path = Path.Combine(TShock.SavePath, "cClassData.json");
            Config = Config.Read(path);
            if (!File.Exists(path))
            {
                Config.Write(path);
            }
            ServerApi.Hooks.WorldSave.Register(this, onSave);
            ServerApi.Hooks.NpcStrike.Register(this, damage.onDamage);
            ServerApi.Hooks.ServerJoin.Register(this, onJoin.start);
            Commands.ChatCommands.Add(new Command("cclass.level", commands.levelCmd, "level"));
            Commands.ChatCommands.Add(new Command("cclass.warrior", commands.warriorCmd, "warrior"));
            Commands.ChatCommands.Add(new Command("cclass.paladin", commands.paladinCmd, "paladin"));
            Commands.ChatCommands.Add(new Command("cclass.wizard", commands.wizardCmd, "wizard"));
            Commands.ChatCommands.Add(new Command("cclass.statsadd", commands.statCmd, "statsadd"));


            vars.informations = Config.informations;
            vars.warrior = Config.Warrior;
            vars.paladin = Config.Paladin;
            vars.wizard = Config.Wizard;

            System.Timers.Timer timer = new System.Timers.Timer(900000);
            timer.Elapsed += saveRun;
            timer.Start();
        }

        public void onSave(WorldSaveEventArgs e)
        {
            save();
        }

        private void saveRun(object sender, ElapsedEventArgs args)
        {
            save();
        }
        public void save()
        {
            TSPlayer.All.SendMessage("[cClass] Saving player statistics.. Possible lags!", Color.Silver);
            Config.Warrior = vars.warrior;
            Config.Paladin = vars.paladin;
            Config.Wizard = vars.wizard;
            Config.informations = vars.informations;
            string path = Path.Combine(TShock.SavePath, "cClassData.json");
            Config.Write(path);
            TSPlayer.All.SendMessage("[cClass] Saved statistics!", Color.Silver);
        }

    }
}
