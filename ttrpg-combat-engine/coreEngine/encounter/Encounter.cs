using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ttrpg_combat_engine.coreEngine.interfaces;

namespace ttrpg_combat_engine.coreEngine.encounter
{
    public class Encounter : IEncounter
    {
        private List<ICreature> creatures;

        public List<ICreature> GetCreatures() { return creatures; }

        public Encounter(List<ICreature> creatures)
        {
            this.creatures = creatures;
        }
        public Encounter()
        {
            creatures = new List<ICreature>();
        }
        public bool AddCreature(ICreature creature)
        {
            try
            {
                creatures.Add(creature);
                return true;
            }
            catch { return false; }
        }
        public int MangeToHit(IAttack attack)
        {
            return attack.GetToHit();
        }
        public Exception? ManageAttackDamage(ICreature target, IAttack attack)
        {
            try
            {
                IStat? stat = target.GetStat(attack.GetTargetStat());
                int roll = attack.GetDamage();

                if (stat == null) 
                { 
                    throw new ArgumentException("target does not have this stat."); 
                }
                else
                {
                    int endValue = stat.GetCurentValue() - roll;
                    target.EditStat(stat.GetName(), endValue);
                    return null;
                }
            }
            catch (Exception e) { return e; }
        }
    }
}
