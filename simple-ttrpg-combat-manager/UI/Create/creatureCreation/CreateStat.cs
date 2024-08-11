using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simple_ttrpg_combat_manager.UI.Interfaces;
using ttrpg_combat_engine.coreEngine.interfaces;

namespace simple_ttrpg_combat_manager.UI.Create.creatureCreation
{
    internal class CreateStat : IUI
    {
        private List<IStat> stats;
        string IUI.GetScreen()
        {
            throw new NotImplementedException();
        }

        IUI? IUI.input(string? input)
        {
            throw new NotImplementedException();
        }
        internal CreateStat (List<IStat> stats)
        {
            this.stats = stats;
        }
    }
}
