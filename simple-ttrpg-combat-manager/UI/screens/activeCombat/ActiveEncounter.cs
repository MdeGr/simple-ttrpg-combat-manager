﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using consoleFrontendFramework.interfaces;
using ttrpg_combat_engine.coreEngine.interfaces;

namespace simple_ttrpg_combat_manager.UI.screens.activeCombat
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
