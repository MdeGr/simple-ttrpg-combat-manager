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
    public class Creature : ICreature
    {
        private string name;
        private List<IStat> stats;
        private List<IAttack> attacks;

        public string GetName() { return name; }
        public List<IStat> GetStats() { return stats; }
        public List<IAttack> GetAttacks() { return attacks; }
        public IStat? GetStat(string name)
        {
            foreach (Stat stat in stats)
            {
                if (stat.GetName() == name)
                {
                    return stat;
                }
            }
            return null;
        }

        public Creature(string name, List<IStat> stats, List<IAttack> attacks)
        {
            this.name = name;
            this.stats = stats;
            this.attacks = attacks;
        }
        public Creature(string name)
        {
            this.name = name;
            stats = new List<IStat>();
            attacks = new List<IAttack>();
        }
        public bool Addstat(IStat stat)
        {
            if (stat == null) { return false; }
            try
            {
                stats.Add(stat);
                return true;
            }
            catch { return false; }
        }
        public bool AddAttack(IAttack attack)
        {
            if (attack == null) { return false; }
            try
            {
                attacks.Add(attack);
                return true;
            }
            catch { return false; }
        }

        public bool EditStat(string statname, int curentValue)
        {
            if (statname == null || statname == "") { return false; }
            try
            {
                foreach (Stat stat in stats)
                {
                    if (stat.GetName() == statname)
                    {
                        stat.EditCurentValue(curentValue);
                        return true;
                    }
                }
                return false;
            }
            catch { return false; }
        }
    }
}
