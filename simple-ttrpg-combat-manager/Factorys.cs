using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ttrpg_combat_engine.coreEngine.attack;
using ttrpg_combat_engine.coreEngine.creature;
using ttrpg_combat_engine.coreEngine.encounter;
using ttrpg_combat_engine.coreEngine.interfaces;
using ttrpg_combat_engine.utility.dice.flatDice;
using ttrpg_combat_engine.coreEngine.stat;
using ttrpg_combat_engine.utility.interfaces;

namespace simple_ttrpg_combat_manager
{
    internal static class Factorys
    {
        internal static readonly IAttackFactory internal_attack_factory = new AttackFactory();
        internal static readonly ICreatureFactory internal_creature_factory = new CreatureFactory();
        internal static readonly IEncounterFactory internal_encounter_factory = new EncounterFactory();
        internal static readonly IStatFactory internal_Stat_factory = new StatFactory();
        internal static readonly IDieFactory internal_Die_factory = new DieFactory(new Random());
    }
}
