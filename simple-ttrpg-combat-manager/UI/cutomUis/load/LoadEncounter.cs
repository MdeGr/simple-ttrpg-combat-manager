using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using consoleFrontendFramework.interfaces;

namespace simple_ttrpg_combat_manager.UI.screens.load
{
    internal class LoadEncounter : IUI
    {
        private string screen = "not yet implemented\n\n" +
            "1) Back";

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
                    case 1: return new StartScreen("Simple combat manager\n" +" by: Merel de Graauw\n\n");
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

        internal LoadEncounter() { }
    }
}
