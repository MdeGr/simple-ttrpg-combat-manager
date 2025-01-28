using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using consoleFrontendFramework.interfaces;

namespace simple_ttrpg_combat_manager.UI.screens.Create.general
{
    internal class ChangeString : IUI
    {
        private string header;
        private string? error;
        private IUI parentUi;
        private Func<string, bool> changeFunc;

        string IUI.GetScreen()
        {
            string screen = "";

            screen += header;
            if ( error != null ) { screen += error; }

            return screen;
        }

        IUI? IUI.input(string? input)
        {
            if (input == "" || input == null) { return this; }
            else
            {
                bool status = changeFunc(input);
                if (!status)
                {
                    error = "Something went wrong\n";
                    return this;
                }
                else
                {
                    return parentUi;
                }
            }
        }

        internal ChangeString(string header, Func<string, bool> changeFunc, IUI parentUi)
        {
            this.header = header;
            this.changeFunc = changeFunc;
            this.parentUi = parentUi;
        }
    }
}
