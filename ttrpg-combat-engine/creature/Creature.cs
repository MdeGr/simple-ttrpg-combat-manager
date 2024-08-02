using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ttrpg_combat_engine.stat;
using ttrpg_combat_engine.attack;
using System.ComponentModel.DataAnnotations;

namespace ttrpg_combat_engine.mobile
{
    public class Creature
    {
        private List<Stat> stats;
        private List<Attack> attacks;

        public List<Stat> GetStats() {  return stats; }
        public List<Attack> GetAttacks() { return attacks; }

        internal Creature(List<Stat> stats, List<Attack> attacks)
        {
            this.stats = stats;
            this.attacks = attacks;
        }
        internal bool Addstat(Stat stat)
        {
            if (stat == null) { return false; }
            try
            {
                stats.Add(stat);
                return true;
            }
            catch { return false; }
        }
        internal bool AddAttack(Attack attack)
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
            }
            catch { return false; }
        }
    }
}
