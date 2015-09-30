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
    [ApiVersion(1, 21)]
    public class main : TerrariaPlugin
    {

        public static Config Config;

        public main(Main game) : base(game) { Order -= 1; }
        public override Version Version { get { return new Version("1.4"); } }
        public override string Name { get { return "cClass"; } }
        public override string Author { get { return "Teddy"; } }
        public override string Description { get { return "Classes And Levels"; } }

        public override void Initialize()
        {
            string path = Path.Combine(TShock.SavePath, "cClassData1_4.json");
            Config = Config.Read(path);
            if (!File.Exists(path))
            {
                Config.Write(path);
            }
            //Events
            ServerApi.Hooks.NpcStrike.Register(this, Events.OnDamage.run);
            ServerApi.Hooks.ServerJoin.Register(this, Events.OnJoin.run);
            ServerApi.Hooks.WorldSave.Register(this, onSave);
            //Commands
            Commands.ChatCommands.Add(new Command("cclass.level", Cmds.levelCmd, "level") { AllowServer = false, HelpText = "Check level" });
            Commands.ChatCommands.Add(new Command("cclass.warrior", Cmds.warriorCmd, "warrior") { AllowServer = false, HelpText = "Change your class to Warrior" });
            Commands.ChatCommands.Add(new Command("cclass.paladin", Cmds.paladinCmd, "paladin") { AllowServer = false, HelpText = "Change your class to Paladin" });
            Commands.ChatCommands.Add(new Command("cclass.wizard", Cmds.wizardCmd, "wizard") { AllowServer = false, HelpText = "Change your class to Wizard" });
            Commands.ChatCommands.Add(new Command("cclass.bwizard", Cmds.bestWizardsCmd, "bwizard") { AllowServer = false, HelpText = "Show 5 best players in Wizard class" });
            Commands.ChatCommands.Add(new Command("cclass.bpaladin", Cmds.bestPaladinsCmd, "bpaladin") { AllowServer = false, HelpText = "Show 5 best players in Paladin class" });
            Commands.ChatCommands.Add(new Command("cclass.bwarrior", Cmds.bestWarriorsCmd, "bwarrior") { AllowServer = false, HelpText = "Show 5 best players in Warrior class" });
            Commands.ChatCommands.Add(new Command("cclass.statsadd", Cmds.statCmd, "statsadd") { AllowServer = false, HelpText = "Statictics class" });
            //Load Levels etc
            Variables.playersData = Config.playersData;
            Variables.levelUp = Config.levelUp;
            Variables.levelCommand = Config.levelCommand;
            Variables.BlockedNPCs = Config.BlockedNPCs;
            Variables.Chance = Config.Chance;
            Variables.startClass = Config.startClass;
            Variables.Message1 = Config.Message1;
            Variables.Message2 = Config.Message2;
            Variables.Message3 = Config.Message3;
        }

        public void onSave(WorldSaveEventArgs e)
        {
            TSPlayer.All.SendMessage("[cClass] Saving player statistics.. Possible lags!", Color.Silver);
            string path = Path.Combine(TShock.SavePath, "cClassData1_4.json");
            Config.BlockedNPCs = Variables.BlockedNPCs.ToList();
            
           
            Config.Write(path);
            TSPlayer.All.SendMessage("[cClass] Saved statistics!", Color.Silver);
        }

    }
}
