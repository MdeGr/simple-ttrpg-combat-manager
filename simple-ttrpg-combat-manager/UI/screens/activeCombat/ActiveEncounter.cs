using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using simple_ttrpg_combat_manager.UI.Interfaces;
using simple_ttrpg_combat_manager.UI.screens.Create.general;
using ttrpg_combat_engine.coreEngine.attack;
using ttrpg_combat_engine.coreEngine.interfaces;
using ttrpg_combat_engine.utility.interfaces;

namespace simple_ttrpg_combat_manager.UI.screens.activeCombat
{
    internal class ActiveEncounter : IUI
    {
        private IEncounter encounter;
        private ICreature attackingCreature;
        private bool attacking = false;

        private IUI? nestedUI;
        private string screen;

        string IUI.GetScreen()
        {
            if (nestedUI != null)
            {
                return nestedUI.GetScreen();
            }
            else
            {
                screen = "Running Encounter\n\n"+
                    " Creatures:\n";
                int count = 0;
                foreach (ICreature creature in encounter.GetCreatures())
                {
                    count++;
                    screen += $"{count}) {creature.GetName()}\n";
                }

                count++;
                screen += $"/n{count}) Exit";

                return screen;
            }
        }

        IUI? IUI.input(string? input)
        {
            if (input == null || input == "") { return null; }
            if (nestedUI != null)
            {
                IUI? returnUI = nestedUI.input(input);
                nestedUI = returnUI;
                return this;
            }

            try
            {
                int inputNum = int.Parse(input);
                int creatureCount = encounter.GetCreatures().Count;

                if (inputNum <= creatureCount + 1 && !attacking)
                {
                    attackingCreature = encounter.GetCreatures()[inputNum];
                    return this;
                }
                if (inputNum <= creatureCount + 1 && attacking)
                {
                    ICreature target = encounter.GetCreatures()[inputNum];
                    encounter.get
                }
                else if (inputNum == creatureCount + 2)
                {
                    return new Exit();
                }
                else
                {
                    screen += "\n Error: input must be number from the list";
                    return this;
                }
            }
            catch
            {
                screen += "\nError: input must be a number";
                return this;
            }
        }

        internal ActiveEncounter(IEncounter encounter)
        {
            this.encounter = encounter;
        }
    }
}
