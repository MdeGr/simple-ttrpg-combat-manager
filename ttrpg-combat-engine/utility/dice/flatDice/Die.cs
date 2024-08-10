using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ttrpg_combat_engine.utility.interfaces;

namespace ttrpg_combat_engine.utility.dice.flatDice
{
    public class Die : IDie
    {
        private int max;
        private int min;
        private Random random;
        internal Die(int max, int min, Random random)
        {
            this.max = max;
            this.min = min;
            this.random = random;
        }

        public int GetMax()
        {
            return max;
        }

        public int GetMin()
        {
            return min;
        }

        public string GetName()
        {
            string name = "empty";
            if (min == 1)
            {
                name = "D" + max.ToString();
            }
            else
            {
                name = "D " + min.ToString() + " - " + max.ToString();
            }

            return name;
        }

        public int Roll()
        {
            int rolled = random.Next(min, max+1);

            if (rolled < max && rolled > min)
            {
                return rolled;
            }
            else
            {
                throw new Exception("Rolled imposible value.");
            }
        }
    }
}
