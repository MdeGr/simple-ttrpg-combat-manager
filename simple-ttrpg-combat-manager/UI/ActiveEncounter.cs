using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simple_ttrpg_combat_manager.UI.Interfaces;
using ttrpg_combat_engine.coreEngine.interfaces;

namespace simple_ttrpg_combat_manager.UI
{
    internal class ActiveEncounter : IUI
    {
        private IEncounter encounter;

        string IUI.GetScreen()
        {
            throw new NotImplementedException();
        }

        IUI? IUI.input(string? input)
        {
            throw new NotImplementedException();
        }

        internal ActiveEncounter(IEncounter encounter)
        {
            this.encounter = encounter;
        }
    }
}
