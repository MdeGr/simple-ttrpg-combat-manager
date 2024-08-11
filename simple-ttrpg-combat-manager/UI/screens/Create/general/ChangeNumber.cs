using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simple_ttrpg_combat_manager.UI.Interfaces;

namespace simple_ttrpg_combat_manager.UI.screens.Create.general
{
    internal class ChangeNumber : IUI
    {
        private Func<int, bool> setNum;
        private string screen = "Change number\n\n" +
            "type number or press enter to return to creation...\n";
        string IUI.GetScreen()
        {
            return screen;
        }

        IUI? IUI.input(string? input)
        {
            if (input == "") { return null; }
            try
            {
                bool status = setNum(int.Parse(input));
                if (!status) { throw new ArgumentException(); }
                else { return null; }
            }
            catch
            {
                screen += "somthing went wrong try again...";
                return this;
            }
        }

        internal ChangeNumber(Func<int, bool> setNum)
        {
            this.setNum = setNum;
        }
    }
}
