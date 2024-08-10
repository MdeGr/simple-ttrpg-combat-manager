using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ttrpg_combat_engine.coreEngine.interfaces;

namespace ttrpg_combat_engine.coreEngine.stat
{
    public class StatFactory : IStatFactory
    {
        public StatFactory() { }
        public Stat CreateStat(string name, int normalValue)
        {
            return new Stat(name, normalValue);
        }
    }
}
