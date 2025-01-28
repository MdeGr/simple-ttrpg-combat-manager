using consoleFrontendFramework.ActionPreset;
using consoleFrontendFramework.interfaces;
using consoleFrontendFramework.UiPreset;
using simple_ttrpg_combat_manager.UI.screens.Create.creatureCreation;
using simple_ttrpg_combat_manager.UI.screens.Create.general;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ttrpg_combat_engine.coreEngine.interfaces;

namespace simple_ttrpg_combat_manager.UI.screens.Create
{
    internal class CreateCreature : NavigatingUI
    {
        private Action<ICreature> addCreature;
        private string name;
        private List<IStat> stats = new List<IStat>();
        private List<IAttack> attacks = new List<IAttack>();

        internal bool SetName(string name)
        {
            try
            {
                this.name = name;
                return true;
            }
            catch { return false; }
        }

        public override string GetScreen()
        {
            string screen = base.GetScreen();
            screen += $"name: {name}\n" +
                    "\n Stats:\n";
            foreach (IStat stat in stats)
            {
                screen += stat.GetName() + "\n";
            }

            screen += "\n Attacks:\n";
            foreach (IAttack attack in attacks)
            {
                screen += attack.GetName() + "\n";
            }

            return screen;
        }

        internal CreateCreature(string? header,Action<ICreature> addCreature,IUI parent): base (header)
        {
            this.addCreature = addCreature;
            this.actions = [new NavigateTo("Change Name",new ChangeString("Change name\n\nType name or press enter to return to creation...\n",SetName,this)),
                            new NavigateTo("Add attack", new CreateAttack("Create Attack\n",attacks.Add,this)),
                            new NavigateTo("Add Stat", new CreateStat(stats)),
                            new Confirm("Confirm", parent, addCreature as Action<Object>, Factorys.internal_creature_factory.CreateCreature(this.name,this.stats,this.attacks)),
                            new NavigateTo("back",parent)];
        }
    }
}
