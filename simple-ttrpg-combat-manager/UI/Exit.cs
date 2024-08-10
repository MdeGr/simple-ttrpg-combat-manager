﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_ttrpg_combat_manager.UI
{
    internal class Exit : IUI
    {
        private string screen = "Confirm to exit\n\n" +
            "1)Confirm\n" +
            "2)Back";
        private bool exit = false;

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
                    case 1:
                        {
                            exit = true;
                            return this;
                        }
                    case 2: return new StartScreen();
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

        internal Exit() { }
        internal bool GetExit()
        {
            return exit;
        }
    }
}