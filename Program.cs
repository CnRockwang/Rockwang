using System;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;
using Color = System.Drawing.Color;

namespace Saysomething
{
    class Program
    {
        public static LeagueSharp.Common.Menu _menu;
        public static bool isSend = false;
        public static float gameTime1 = 0;
        private static Obj_AI_Hero Player;
        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }

        private static void Game_OnGameLoad(EventArgs args)
        {
            Game.OnUpdate += Game_OnGameUpdate;

            _menu = new Menu("Saysomething", "say_something", true);
            _menu.AddSubMenu(new Menu("Say_Something_keybins", "saysomething"));
            _menu.SubMenu("saysomething").AddSubMenu(new Menu("Top_Miss", "topmiss"));
            
            _menu.SubMenu("saysomething").SubMenu("topmiss").AddItem(new MenuItem("clcktop", "Top_miss(9)").SetValue(new KeyBind(57, KeyBindType.Press)));
            _menu.SubMenu("saysomething").AddSubMenu(new Menu("Mid_Miss", "midmiss"));
            
            _menu.SubMenu("saysomething").SubMenu("midmiss").AddItem(new MenuItem("clckmid", "Mid_miss(0)").SetValue(new KeyBind(48, KeyBindType.Press)));
            _menu.SubMenu("saysomething").AddSubMenu(new Menu("Sup_Miss", "supmiss"));
            
            _menu.SubMenu("saysomething").SubMenu("supmiss").AddItem(new MenuItem("clcksup", "Sup_miss(-)").SetValue(new KeyBind(189, KeyBindType.Press)));
            _menu.SubMenu("saysomething").AddSubMenu(new Menu("Sup&Ad_miss", "supad"));
           
            _menu.SubMenu("saysomething").SubMenu("supad").AddItem(new MenuItem("clcksupad", "Sup&Ad_miss(=)").SetValue(new KeyBind(187, KeyBindType.Press)));

            _menu.AddToMainMenu();

       
            
           


        }
        private static void Game_OnGameUpdate(EventArgs args)
        {

            
            
             if (_menu.Item("clcktop").GetValue<KeyBind>().Active)
            {

                if(isSend == false)
                {
                    Game.Say("top miss,careful~~");
                    isSend = true;
                    gameTime1 = Game.Time + 1;

                }

                if (Game.Time > gameTime1)
                {
                    
                    isSend = false;

                }
  
            }

        

            if (_menu.Item("clckmid").GetValue<KeyBind>().Active)
            {
                if (isSend == false)
                {
                    Game.Say("mid miss,careful~~");
                    isSend = true;
                    gameTime1 = Game.Time + 1;

                }

                if (Game.Time > gameTime1)
                {

                    isSend = false;

                }
                

            }

            if (_menu.Item("clcksup").GetValue<KeyBind>().Active)
            {
                if (isSend == false)
                {
                    Game.Say("sup miss,careful~~");
                    isSend = true;
                    gameTime1 = Game.Time + 1;

                }

                if (Game.Time > gameTime1)
                {

                    isSend = false;

                }
                

            }

            if (_menu.Item("clcksupad").GetValue<KeyBind>().Active)
            {
                if (isSend == false)
                {
                    Game.Say("sup and ad all miss,careful~~");
                    isSend = true;
                    gameTime1 = Game.Time + 1;

                }

                if (Game.Time > gameTime1)
                {

                    isSend = false;

                }
                

            }
          
        }


    }   
}

           