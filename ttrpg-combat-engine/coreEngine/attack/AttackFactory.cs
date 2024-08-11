using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ttrpg_combat_engine.coreEngine.interfaces;
using ttrpg_combat_engine.utility.interfaces;

namespace ttrpg_combat_engine.coreEngine.attack
{
    public class AttackFactory : IAttackFactory
    {
        public AttackFactory() { }
        public Attack CreateAttack(string name, string targetStat, IDie hitDie, int hitMod, IDie damageDie, int nDamageDie, int damageMod)
        {
            return new Attack(name, targetStat, hitDie, hitMod, damageDie, nDamageDie, damageMod);
        }
        public Attack CreateAttack(string name, string targetStat, IDie damageDie, int nDamageDie, int damageMod)
        {
            if (nDamageDie <= 0) { throw new ArgumentException("Number of damage dice to low"); }
            return new Attack(name, targetStat, damageDie, nDamageDie, damageMod);
        }
    }
}
