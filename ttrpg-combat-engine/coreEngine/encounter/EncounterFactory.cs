using ttrpg_combat_engine.coreEngine.attack;
using ttrpg_combat_engine.coreEngine.creature;
using ttrpg_combat_engine.coreEngine.interfaces;
using ttrpg_combat_engine.coreEngine.stat;

namespace ttrpg_combat_engine.coreEngine.encounter
{
    public class EncounterFactory : IEncounterFactory
    {
        public EncounterFactory() { }
        public IEncounter CreateEncounter(List<ICreature> creatures)
        {
            return new Encounter(creatures);
        }
        public IEncounter CreateEncounter()
        {
            return new Encounter();
        }
    }
}
