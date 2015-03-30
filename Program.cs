using System;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;
using Color = System.Drawing.Color;

namespace JunglePosition
{
    class Program
    {
        public static Menu Config;
        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }

        private static void Game_OnGameLoad(EventArgs args)
        {
            Config = new Menu("Rockwang_Saysomthing", "Saysomething", true);
            Config.AddItem(new MenuItem("Show", "显示"));
            Config.AddToMainMenu();
	    Game.Say("小心上路miss,小心上路miss,小心上路miss,")
	    Game.PrintChat("Rocktest11111111111111111111111");
	    Console.WriteLine("Rocktest22222222222222222222");

           
        }

        private static void Drawing_OnDraw(EventArgs args)
        {
          



        }
    }
}