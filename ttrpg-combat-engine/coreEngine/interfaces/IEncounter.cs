using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ttrpg_combat_engine.coreEngine.creature;

namespace ttrpg_combat_engine.coreEngine.interfaces
{
    public interface IEncounter
    {
        public List<ICreature> GetCreatures();
        public bool AddCreature(ICreature creature);
    }
}
