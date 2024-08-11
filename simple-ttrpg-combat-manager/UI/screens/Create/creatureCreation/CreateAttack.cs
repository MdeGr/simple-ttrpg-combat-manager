using simple_ttrpg_combat_manager.UI.Interfaces;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace simple_ttrpg_combat_manager.UI.screens.Create.creatureCreation
{
    internal class CreateAttack : IUI
    {
        private List<IAttack> attacks;
        private string name;
        private string targetStat;
        private IDie? hitDie;
        private IDie? damageDie;
        private int hitMod;
        private int damageMod;
        private int nDamageDice;

        private IUI? nestedUI;
        private string screen;

        internal bool SetName(string name)
        {
            try
            {
                this.name = name;
                return true;
            }
            catch { return false; }
        }
        internal bool SetTargetStat(string stat)
        {
            try
            {
                targetStat = stat;
                return true;
            }
            catch { return false; }
        }
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

        string IUI.GetScreen()
        {
            if (nestedUI != null)
            {
                return nestedUI.GetScreen();
            }
            else
            {
                screen = "Create Attack\n\n";
                try { screen += $"name: {name}\n"; } catch { }
                try { screen += $"target stat: {targetStat}\n"; } catch { }
                try { screen += $"Hit die: {hitDie.GetName()}\n"; } catch { }
                try { screen += $"Damage die: {damageDie.GetName()}\n"; } catch { }
                try { screen += $"hit modifier: {hitMod}\n"; } catch { }
                try { screen += $"damage modifier: {damageMod}\n"; } catch { }
                try { screen += $"number of damage dice: {nDamageDice}\n"; } catch { }

                screen += "\n1)Change name\n" +
                    "2)Change name\n" +
                    "3)Set hit die\n" +
                    "4)Set damage die\n" +
                    "5)set hit modifier\n" +
                    "6)Set damage modifier\n" +
                    "7)Confirm\n" +
                    "8)Back";

                return screen;
            }
        }
        IUI? IUI.input(string? input)
        {
            if (input == null || input == "") { return null; }
            if (nestedUI != null)
            {
                IUI? returnUI = nestedUI.input(input);
                nestedUI = returnUI;
                return this;
            }

            try
            {
                int inputNum = int.Parse(input);
                switch (inputNum)
                {
                    case 1:
                        {
                            nestedUI = new ChangeString(SetName);
                            return this;
                        }
                    case 2:
                        {
                            nestedUI = new ChangeString(SetTargetStat);
                            return this;
                        }
                    case 3:
                        {
                            nestedUI = new CreateDie(SetHitDie);
                            return this;
                        }
                    case 4:
                        {
                            nestedUI = new CreateDie(SetDamageDice);
                            return this;
                        }
                    case 5:
                        {
                            nestedUI = new ChangeNumber(SetHitMod);
                            return this;
                        }
                    case 6:
                        {
                            nestedUI = new ChangeNumber(SetDamageMod);
                            return this;
                        }
                    case 7:
                        {
                            IAttack attack = null;
                            if (hitDie != null && hitDie != null)
                            {
                                attack = Factorys.internal_attack_factory.CreateAttack(name, targetStat, hitDie, hitMod, damageDie, nDamageDice, damageMod);
                            }
                            else if (hitDie != null)
                            {
                                attack = Factorys.internal_attack_factory.CreateAttack(name, targetStat, damageDie, nDamageDice, damageMod);
                            }
                            else
                            {
                                return this;
                            }
                            attacks.Add(attack);

                            return null;
                        }
                    case 8: return null;
                    default:
                        {
                            return this;
                        }
                }
            }
            catch
            {
                screen += "\nError: input must be a number";
                return this;
            }
        }

        internal CreateAttack(List<IAttack> attacks)
        {
            this.attacks = attacks;
        }
    }
}
