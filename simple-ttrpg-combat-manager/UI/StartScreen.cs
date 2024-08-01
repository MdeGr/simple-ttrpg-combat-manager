using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ttrpg_combat_engine;

namespace simple_ttrpg_combat_manager.UI
{
    internal class StartScreen : IUI
    {
        private string screen;
        string IUI.GetScreen()
        {
            return screen;
        }

        void IUI.input(string? input)
        {
            throw new NotImplementedException();
        }

        internal StartScreen() { }
    }
}
