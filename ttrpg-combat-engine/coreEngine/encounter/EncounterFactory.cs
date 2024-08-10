using ttrpg_combat_engine.attack;
using ttrpg_combat_engine.coreEngine.interfaces;
using ttrpg_combat_engine.mobile;
using ttrpg_combat_engine.stat;

namespace ttrpg_combat_engine.coreEngine.encounter
{
    public class EncounterFactory
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
    }
}
