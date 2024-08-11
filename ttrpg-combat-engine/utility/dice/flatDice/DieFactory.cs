using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ttrpg_combat_engine.utility.interfaces;

namespace ttrpg_combat_engine.utility.dice.flatDice
{
    public class DieFactory : IDieFactory
    {
        private Random random;

        public DieFactory(Random random)
        {
            this.random = random;
        }

        public IDie CreateDie(int max, int min)
        {
            if (max > min)
            {
                return new Die(max, min, random);
            }
            else { throw new ArgumentException("Max bigger than min."); }
        }
        public IDie CreateDie(int max)
        {
            return new Die(max, 1, random);
        }
    }
}
