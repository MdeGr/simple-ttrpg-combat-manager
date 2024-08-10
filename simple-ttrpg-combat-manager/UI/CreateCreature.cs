using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ttrpg_combat_engine.coreEngine.interfaces;

namespace simple_ttrpg_combat_manager.UI
{
    internal class CreateCreature : IUI
    {
        private string Screen = "";
        private List<ICreature> creatures;
        string IUI.GetScreen()
        {
            throw new NotImplementedException();
        }

        IUI? IUI.input(string? input)
        {
            throw new NotImplementedException();
        }

        internal CreateCreature(List<ICreature> creatures)
        {
            this.creatures = creatures;
        }
    }
}
