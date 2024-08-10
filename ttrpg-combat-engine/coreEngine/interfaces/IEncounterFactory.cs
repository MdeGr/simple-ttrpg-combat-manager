using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttrpg_combat_engine.coreEngine.interfaces
{
    public interface IEncounterFactory
    {
        public IEncounter CreateEncounter(List<ICreature> creatures);
        public IEncounter CreateEncounter();
    }
}
