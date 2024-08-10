using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ttrpg_combat_engine.coreEngine.attack;
using ttrpg_combat_engine.utility.interfaces;

namespace ttrpg_combat_engine.coreEngine.interfaces
{
    internal interface IAttackFactory
    {
        public Attack CreateAttack(string name, IDie hitDie, int hitMod, IDie damageDie, int nDamageDie, int damageMod);
        public Attack CreateAttack(string name, IDie damageDie, int nDamageDie, int damageMod);
    }
}
