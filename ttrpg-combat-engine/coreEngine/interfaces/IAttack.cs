using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttrpg_combat_engine.coreEngine.interfaces
{
    public interface IAttack
    {
        public string GetName();
        public int GetToHit();
        public int GetDamage();
    }
}
