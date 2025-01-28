using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using consoleFrontendFramework.ActionPreset;
using consoleFrontendFramework.interfaces;
using consoleFrontendFramework.UiPreset;
using simple_ttrpg_combat_manager.UI.screens.activeCombat;
using ttrpg_combat_engine.coreEngine.creature;
using ttrpg_combat_engine.coreEngine.interfaces;

namespace simple_ttrpg_combat_manager.UI.screens.Create
{
    internal class CreateEncounter : NavigatingUI
    {
        private List<ICreature> creatures = new List<ICreature>();

        public CreateEncounter(string? header, IUI parentUI) : base(header)
        {
            this.actions = [new NavigateTo("Create creature", new CreateCreature("Create creature\n\n",creatures.Add,this)),
                            new NavigateTo("Active encounter", new ActiveEncounter(creatures)),
                            new NavigateTo("Back", parentUI)];
        }

        public override string? GetScreen()
        {
            string screen = "creatures:\n";
            foreach(Creature creature in creatures)
            {
                screen += $" {creature.GetName}\n";
            }
            screen += $"\n{base.GetScreen()}";
            return screen;
        }
    }
}
