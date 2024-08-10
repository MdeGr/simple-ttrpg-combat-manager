using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ttrpg_combat_engine.coreEngine.stat;

namespace ttrpg_combat_engine.coreEngine.interfaces
{
    internal interface IStatFactory
    {
        public Stat CreateStat(string name, int normalValue);
    }
}
