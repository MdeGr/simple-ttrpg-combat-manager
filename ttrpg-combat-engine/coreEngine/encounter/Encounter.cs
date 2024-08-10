using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ttrpg_combat_engine.coreEngine.interfaces;

namespace ttrpg_combat_engine.coreEngine.encounter
{
    public class Encounter : IEncounter
    {
        private List<ICreature> creatures;

        public Encounter(List<ICreature> creatures)
        {
            this.creatures = creatures;
        }
        public Encounter()
        {
            creatures = new List<ICreature>();
        }

        public List<ICreature> GetCreatures() { return creatures; }
    }
}
