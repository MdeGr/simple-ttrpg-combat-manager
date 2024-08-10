using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ttrpg_combat_engine.coreEngine.creature;

namespace ttrpg_combat_engine.coreEngine.encounter
{
    public class Encounter
    {
        private List<Creature> creatures;

        public Encounter(List<Creature> creatures)
        {
            this.creatures = creatures;
        }
        public Encounter()
        {
            creatures = new List<Creature>();
        }
    }
}
