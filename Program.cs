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
            Config.AddItem(new MenuItem("Show", "œ‘ æ").SetValue(new Circle(true, Color.GreenYellow)));
            Config.AddToMainMenu();
	

           
        }

        private static void Drawing_OnDraw(EventArgs args)
        {
          



        }
    }
}