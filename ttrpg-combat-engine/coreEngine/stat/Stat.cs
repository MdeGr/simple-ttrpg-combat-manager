using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ttrpg_combat_engine.coreEngine.interfaces;

namespace ttrpg_combat_engine.coreEngine.stat
{
    public class Stat : IStat
    {
        private string name;
        private int normalValue;
        private int curentValue;

        public string GetName() { return name; }
        public int GetNormalValue() { return normalValue; }
        public int GetCurentValue() { return curentValue; }

        public Stat(string name, int normalValue)
        {
            this.name = name;
            this.normalValue = normalValue;
            curentValue = normalValue;
        }
        public bool EditCurentValue(int curentValue)
        {
            try
            {
                this.curentValue = curentValue;
                return true;
            }
            catch { return false; }
        }
    }
}
