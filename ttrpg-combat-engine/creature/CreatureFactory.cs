using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ttrpg_combat_engine.attack;
using ttrpg_combat_engine.stat;

namespace ttrpg_combat_engine.mobile
{
    public class CreatureFactory
    {
        public CreatureFactory() { }
        public Creature CreateCreature(string name, List<Stat> stats, List<Attack> attacks)
        {
            return new Creature(name, stats, attacks);
        }
        public Creature CreateCreature(string name)
        {
            return new Creature(name);
        }
    }
}
