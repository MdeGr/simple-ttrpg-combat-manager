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

        public List<ICreature> GetCreatures() { return creatures; }

        public Encounter(List<ICreature> creatures)
        {
            this.creatures = creatures;
        }
        public Encounter()
        {
            creatures = new List<ICreature>();
        }
        public bool AddCreature (ICreature creature)
        {
            try
            {
                creatures.Add(creature);
                return true;
            }
            catch { return false; }
        }
    }
}
