using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ttrpg_combat_engine.coreEngine.interfaces;
using ttrpg_combat_engine.utility.interfaces;

namespace ttrpg_combat_engine.coreEngine.attack
{
    public class Attack : IAttack
    {
        private string name;
        private IDie? hitDie;
        private int hitMod;
        private IDie damageDie;
        private int nDamageDice;
        private int damageMod;

        public Attack(string name, IDie hitDie, int hitMod, IDie damageDie, int nDamageDice, int damageMod)
        {
            this.name = name;
            this.hitDie = hitDie;
            this.hitMod = hitMod;
            this.damageDie = damageDie;
            this.nDamageDice = nDamageDice;
            this.damageMod = damageMod;
        }
        public Attack(string name, IDie damageDie, int nDamageDice, int damageMod)
        {
            this.name = name;
            hitMod = 0;
            this.damageDie = damageDie;
            this.nDamageDice = nDamageDice;
            this.damageMod = damageMod;
        }
        public string GetName()
        {
            return name;
        }
        public int GetToHit()
        {
            int toHit = hitDie.Roll();
            toHit += hitMod;
            return toHit;
        }
        public int GetDamage()
        {
            int damage = 0;
            for (int i = 0; i < nDamageDice; i++)
            {
                damage += damageDie.Roll();
            }
            damage += damageMod;
            return damage;
        }
    }
}
