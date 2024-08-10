using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ttrpg_combat_engine.coreEngine.interfaces
{
    public interface IStat
    {
        public string GetName();
        public int GetNormalValue();
        public int GetCurentValue();
        public bool EditCurentValue(int curentValue);
    }
}
