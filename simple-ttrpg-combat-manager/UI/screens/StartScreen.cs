using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using consoleFrontendFramework.ActionPreset;
using consoleFrontendFramework.interfaces;
using consoleFrontendFramework.UiPreset;
using simple_ttrpg_combat_manager.UI.screens.Create;
using simple_ttrpg_combat_manager.UI.screens.load;
using ttrpg_combat_engine;

namespace simple_ttrpg_combat_manager.UI.screens
{
    internal class StartScreen : NavigatingUI
    {
        internal StartScreen(string? header) : base(header)
        {
            this.actions = [new NavigateTo("Create encounter",new CreateEncounter("Create encounter\n",this)),
                            new NavigateTo("Load encounter", new LoadEncounter()),
                            new ExitAction(this)];
        }
    }
}
