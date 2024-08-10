using ttrpg_combat_engine.coreEngine.attack;
using ttrpg_combat_engine.coreEngine.creature;
using ttrpg_combat_engine.coreEngine.interfaces;
using ttrpg_combat_engine.coreEngine.stat;

namespace ttrpg_combat_engine.coreEngine.encounter
{
    public class EncounterFactory : IEncounterFactory
    {
        ICreatureFactory creatureFactory;
        IAttackFactory attackFactory;
        IStatFactory statFactory;

        EncounterFactory(ICreatureFactory creatureFactory, IAttackFactory attackFactory, IStatFactory statFactory)
        {
            this.creatureFactory = creatureFactory;
            this.attackFactory = attackFactory;
            this.statFactory = statFactory;
        }
        EncounterFactory()
        {
            creatureFactory = new CreatureFactory();
            attackFactory = new AttackFactory();
            statFactory = new StatFactory();
        }
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
