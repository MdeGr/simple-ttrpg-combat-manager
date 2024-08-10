using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ttrpg_combat_engine.coreEngine.creature;
using ttrpg_combat_engine.coreEngine.interfaces;

namespace simple_ttrpg_combat_manager.UI
{
    internal class CreateEncounter : IUI
    {
        private List<ICreature> creatures;
        private IEncounterFactory factory;
        private string screen;
        private IUI nestedUI;
        string IUI.GetScreen()
        {
            if (nestedUI != null)
            {
                return nestedUI.GetScreen();
            }
            else { return screen; }
        }
        IUI? IUI.input(string? input)
        {
            if (input == null || input == "") { return null; }
            if (nestedUI != null) { return nestedUI.input(input); }

            try
            {
                int inputNum = int.Parse(input);
                switch (inputNum)
                {
                    case 1:
                        {
                            nestedUI = new CreateCreature(creatures);
                            return null;
                        }
                    case 2: return new ActiveEncounter(factory.CreateEncounter(creatures));
                    case 3: return new StartScreen();
                    default:
                        {
                            screen += "\nError: input must be a number from the list";
                            return null;
                        }
                }
            }
            catch
            {
                screen += "\nError: input must be a number";
                return null;
            }
        }

        internal CreateEncounter(IEncounterFactory factory)
        {
            this.factory = factory;

            screen = "Create encounter\n\n" + " Creatures:\n";

            foreach (ICreature creature in creatures)
            {
                screen += creature.GetName();
            }

            screen += "\n1)Add creature\n" +
                "2)Confirm\n" +
                "3)Back to startScreen";
        }
    }
}
