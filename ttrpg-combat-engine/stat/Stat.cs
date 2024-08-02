using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttrpg_combat_engine.stat
{
    public class Stat
    {
        private string name;
        private int normalValue;
        private int curentValue;

        public string GetName() {  return name; }
        public int GetNormalValue() { return normalValue; }
        public int GetCurentValue() { return curentValue; }

        internal Stat(string name, int normalValue)
        {
            this.name = name;
            this.normalValue = normalValue;
        }
        internal bool EditCurentValue(int curentValue)
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
