using System;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;
using Color = System.Drawing.Color;

namespace JunglePosition
{
    class Program
    {
        public static LeagueSharp.Common.Menu _menu;
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
            _menu.SubMenu("saysomething").SubMenu("topmiss").AddItem(new MenuItem("top_miss", "Enable this key").SetValue(true));
            _menu.SubMenu("saysomething").SubMenu("topmiss").AddItem(new MenuItem("clcktop", "Top_miss").SetValue(new KeyBind(32, KeyBindType.Press)));
            _menu.SubMenu("saysomething").AddSubMenu(new Menu("Mid_Miss", "midmiss"));
            _menu.SubMenu("saysomething").SubMenu("midmiss").AddItem(new MenuItem("mid_miss", "Enable this key").SetValue(true));
            _menu.SubMenu("saysomething").SubMenu("midmiss").AddItem(new MenuItem("clckmid", "Mid_miss").SetValue(new KeyBind('C', KeyBindType.Press)));
            _menu.SubMenu("saysomething").AddSubMenu(new Menu("Sup_Miss", "supmiss"));
            _menu.SubMenu("saysomething").SubMenu("supmiss").AddItem(new MenuItem("sup_miss", "Enable this key").SetValue(true));
            _menu.SubMenu("saysomething").SubMenu("supmiss").AddItem(new MenuItem("clcksup", "Sup_miss").SetValue(new KeyBind('V', KeyBindType.Press)));
            _menu.SubMenu("saysomething").AddSubMenu(new Menu("Sup&Ad_miss", "supad"));
            _menu.SubMenu("saysomething").SubMenu("supad").AddItem(new MenuItem("supad_miss", "Enable this key").SetValue(true));
            _menu.SubMenu("saysomething").SubMenu("supad").AddItem(new MenuItem("clcksupad", "Sup&Ad_miss").SetValue(new KeyBind('X', KeyBindType.Press)));
            _menu.SubMenu("saysomething").SubMenu("supad").AddItem(new MenuItem("clcksupad", "Sup&Ad_miss").SetValue(new KeyBind('X', KeyBindType.Press)));
            _menu.AddItem(new MenuItem("sayDelay", "say Delay").SetValue(new Slider(200, 20, 2000)));
            _menu.AddToMainMenu();

       
            
           


        }
        private static void Game_OnGameUpdate(EventArgs args)
        {

            bool isSend = false;
            string gameTime="";
             if (_menu.Item("clcktop").GetValue<KeyBind>().Active)
            {

                if(isSend == false)
                {
                    Game.Say("top miss,careful~~");
                    isSend = true;
                    gameTime = Game.Time.ToString();
                    
                }

                if (gameTime != Game.Time.ToString())
                {
                    isSend = false;

                }
  
            }

        

            if (_menu.Item("clckmid").GetValue<KeyBind>().Active)
            {

                Game.Say("mid miss,careful~~");

            }

            if (_menu.Item("clcksup").GetValue<KeyBind>().Active)
            {

                Game.Say("sup miss,careful~~");

            }

            if (_menu.Item("clcksupad").GetValue<KeyBind>().Active)
            {

                Game.Say("sup and ad all miss,careful~~");

            }
          
        }


    }   
}

           