using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ttrpg_combat_engine.coreEngine.attack;
using ttrpg_combat_engine.coreEngine.interfaces;
using ttrpg_combat_engine.coreEngine.stat;

namespace ttrpg_combat_engine.coreEngine.creature
{
    public class CreatureFactory : ICreatureFactory
    {
        public CreatureFactory() { }
        public Creature CreateCreature(string name, List<IStat> stats, List<IAttack> attacks)
        {
            return new Creature(name, stats, attacks);
        }
        public Creature CreateCreature(string name)
        {
            return new Creature(name);
        }
    }
}
