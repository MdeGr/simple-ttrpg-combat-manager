using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttrpg_combat_engine.utility.interfaces
{
    public interface IDie
    {
        public string GetName();
        public int Roll();
        public int GetMax();
        public int GetMin();
    }
}
