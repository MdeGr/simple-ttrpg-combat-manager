using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using consoleFrontendFramework.interfaces;
using simple_ttrpg_combat_manager.UI.screens.activeCombat;
using ttrpg_combat_engine.coreEngine.creature;
using ttrpg_combat_engine.coreEngine.interfaces;

namespace simple_ttrpg_combat_manager.UI.screens.Create
{
    internal class CreateEncounter : IUI
    {
        private List<ICreature> creatures = new List<ICreature>();
        private IUI? nestedUI = null;
        private string? screen;
        string IUI.GetScreen()
        {
            if (nestedUI != null)
            {
                return nestedUI.GetScreen();
            }
            else
            {
                screen = "Create encounter\n\n" + " Creatures:\n";

                foreach (ICreature creature in creatures)
                {
                    screen += creature.GetName() + "\n";
                }

                screen += "\n1)Add creature\n" +
                    "2)Confirm\n" +
                    "3)Back to startScreen";

                return screen;
            }
        }
        IUI? IUI.input(string? input)
        {
            if (input == null || input == "") { return this; }
            if (nestedUI != null)
            {
                IUI? returnUI = nestedUI.input(input);
                nestedUI = returnUI;
                return this;
            }

            try
            {
                int inputNum = int.Parse(input);
                switch (inputNum)
                {
                    case 1:
                        {
                            nestedUI = new CreateCreature(creatures);
                            return this;
                        }
                    case 2: return new ActiveEncounter(Factorys.internal_encounter_factory.CreateEncounter(creatures));
                    case 3: return new StartScreen();
                    default:
                        {
                            screen += "\nError: input must be a number from the list";
                            return this;
                        }
                }
            }
            catch
            {
                screen += "\nError: input must be a number";
                return null;
            }
        }

        internal CreateEncounter() { }
    }
}
