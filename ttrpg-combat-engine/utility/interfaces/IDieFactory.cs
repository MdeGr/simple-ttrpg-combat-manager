using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttrpg_combat_engine.utility.interfaces
{
    public interface IDieFactory
    {
        public IDie CreateDie(int max, int min);
        public IDie CreateDie(int max);
    }
}
