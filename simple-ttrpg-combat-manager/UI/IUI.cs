using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_ttrpg_combat_manager.UI
{
    internal interface IUI
    {
        internal string GetScreen();
        internal IUI? input(string? input);
    }
}
