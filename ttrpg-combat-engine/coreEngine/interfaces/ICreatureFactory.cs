using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ttrpg_combat_engine.coreEngine.attack;
using ttrpg_combat_engine.coreEngine.creature;
using ttrpg_combat_engine.coreEngine.stat;

namespace ttrpg_combat_engine.coreEngine.interfaces
{
    internal interface ICreatureFactory
    {
        public Creature CreateCreature(string name, List<Stat> stats, List<Attack> attacks);
        public Creature CreateCreature(string name);
    }
}
