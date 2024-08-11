using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using simple_ttrpg_combat_manager.UI.Interfaces;

namespace simple_ttrpg_combat_manager.UI.Create.general
{
    internal class ChangeName : IUI
    {
        private Func<string, bool> changeFunc;
        private string screen = "Change name\n\n" +
            "type name or press enter to return to creature creation...\n";

        string IUI.GetScreen()
        {
            return screen;
        }

        IUI? IUI.input(string? input)
        {
            if (input == "") { return null; }
            else
            {
                bool status = changeFunc(input);
                if (!status) { throw new ArgumentException(); }
                else { return null; }
            }
        }

        internal ChangeName(Func<string, bool> changeFunc)
        {
            this.changeFunc = changeFunc;
        }
    }
}
