using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ttrpg_combat_engine.coreEngine.attack;
using ttrpg_combat_engine.coreEngine.stat;

namespace ttrpg_combat_engine.coreEngine.interfaces
{
    public interface ICreature
    {
        public string GetName();
        public List<IStat> GetStats();
        public List<IAttack> GetAttacks();
        public bool Addstat(IStat stat);
        public bool AddAttack(IAttack attack);
        public bool EditStat(string statname, int curentValue);
    }
}
