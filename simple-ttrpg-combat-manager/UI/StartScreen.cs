﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using ttrpg_combat_engine;

namespace simple_ttrpg_combat_manager.UI
{
    internal class StartScreen : IUI
    {
        private string screen = "Simple combat manager\n"+
            " by: Merel de Graauw\n\n"+
            "1) New Encounter\n"+
            "2) Load Encounter\n"+
            "3) Exit\n";
        string IUI.GetScreen()
        {
            return screen;
        }

        IUI? IUI.input(string? input)
        {
            if (input == null || input == "") { return null; }

            try
            {
                int inputNum = int.Parse(input);
                switch (inputNum)
                {
                    case 1: return new CreateEncounter();
                    case 2: return new LoadEncounter();
                    case 3: return new Exit();
                    default:
                        {
                            screen += "\nError: input must be a number from the list";
                            return null;
                        }
                }
            }
            catch
            {
                screen += "\nError: input must be a number";
                return null;
            }
        }

        internal StartScreen() { }
    }
}
