using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ttrpg_combat_engine.utility.interfaces;

namespace ttrpg_combat_engine.attack
{
    public class AttackFactory
    {
        public AttackFactory() { }
        internal Attack CreateAttack(string name, IDie hitDie, int hitMod, IDie damageDie, int nDamageDie, int damageMod)
        {
            return new Attack(name, hitDie, hitMod, damageDie,nDamageDie, damageMod);
        }
        internal Attack CreateAttack(string name, IDie damageDie, int nDamageDie, int damageMod)
        {
            if (nDamageDie <= 0) { throw new ArgumentException("Number of damage dice to low"); }
            return new Attack(name, damageDie, nDamageDie, damageMod);
        }
    }
}
