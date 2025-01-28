using consoleFrontendFramework.ActionPreset;
using consoleFrontendFramework.interfaces;
using consoleFrontendFramework.UiPreset;
using simple_ttrpg_combat_manager.UI.screens.Create.general;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ttrpg_combat_engine.coreEngine.attack;
using ttrpg_combat_engine.coreEngine.creature;
using ttrpg_combat_engine.coreEngine.interfaces;
using ttrpg_combat_engine.utility.interfaces;

namespace simple_ttrpg_combat_manager.UI.screens.Create.creatureCreation
{
    internal class CreateAttack : NavigatingUI
    {
        private string name;
        private IDie? hitDie;
        private IDie? damageDie;
        private int hitMod = 0;
        private int damageMod = 0;
        private int nDamageDice = 0;

        internal bool SetHitDie(IDie die, int number)
        {
            try
            {
                hitDie = die;
                return true;
            }
            catch { return false; }
        }
        internal bool SetDamageDice(IDie die, int number)
        {
            try
            {
                damageDie = die;
                nDamageDice = number;
                return true;
            }
            catch { return false; }
        }
        internal bool SetName(string name)
        {
            try
            {
                this.name = name;
                return true;
            }
            catch { return false; }
        }
        internal bool SetHitMod(int hitMod)
        {
            try
            {
                this.hitMod = hitMod;
                return true;
            }
            catch { return false; }
        }
        internal bool SetDamageMod(int damageMod)
        {
            try
            {
                this.damageMod = damageMod;
                return true;
            }
            catch { return false; }
        }

        public override string GetScreen()
        {
            string screen = base.GetScreen();

            screen += $"name: {name}\n";
            if (hitDie != null) { screen += $"Hit die: {hitDie.GetName()}\n"; }
            if (damageDie != null) { screen += $"Damage die: {damageDie.GetName()}\n"; }
            screen += $"hit modifier: {hitMod}\n";
            screen += $"damage modifier: {damageMod}\n";
            screen += $"number of damage dice: {nDamageDice}\n";

            return screen;
        }

        internal CreateAttack(string header, Action<IAttack> action,IUI parentUi): base (header)
        {
            this.actions = [new NavigateTo("Change name", new ChangeString("Enter attack name:\n", SetName, this)),
                            new NavigateTo("Set hit die", new CreateDie(SetHitDie)),
                            new NavigateTo("Set hit Mod", new ChangeNumber(SetHitMod)),
                            new NavigateTo("Set hit die", new CreateDie(SetDamageDice)),
                            new NavigateTo("Set hit Mod", new ChangeNumber(SetDamageMod)),
                            new Confirm("Confirm",parentUi,action as Action<Object>,Factorys.internal_attack_factory.CreateAttack(name, hitDie, hitMod, damageDie, nDamageDice, damageMod)),
                            new NavigateTo("Back",parentUi)];
        }
    }
}
