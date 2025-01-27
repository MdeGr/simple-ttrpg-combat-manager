﻿using consoleFrontendFramework.ActionPreset;
using consoleFrontendFramework.interfaces;
using consoleFrontendFramework.UiPreset;
using simple_ttrpg_combat_manager.UI.screens.Create.creatureCreation;
using simple_ttrpg_combat_manager.UI.screens.Create.general;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ttrpg_combat_engine.coreEngine.interfaces;

namespace simple_ttrpg_combat_manager.UI.screens.Create
{
    internal class CreateCreature : NavigatingUI
    {
        private string screen;
        private List<ICreature> creatures;
        private string name;
        private List<IStat> stats = new List<IStat>();
        private List<IAttack> attacks = new List<IAttack>();
        private IUI nestedUI;

        internal bool SetName(string name)
        {
            try
            {
                this.name = name;
                return true;
            }
            catch { return false; }
        }
        //string IUI.GetScreen()
        //{
        //    if (nestedUI != null)
        //    {
        //        return nestedUI.GetScreen();
        //    }
        //    else
        //    {
        //        screen = "Create creature\n\n" +
        //            $"name: {name}\n" +
        //            " Stats:\n";
        //        foreach (IStat stat in stats)
        //        {
        //            screen += stat.GetName() + "\n";
        //        }

        //        screen += "\n Attacks:\n";
        //        foreach (IAttack attack in attacks)
        //        {
        //            screen += attack.GetName() + "\n";
        //        }

        //        screen += "\n1)Change name\n" +
        //            "2)Add stat\n" +
        //            "3)Add attack\n" +
        //            "4)Confirm\n" +
        //            "5)Back";

        //        return screen;
        //    }
        //}

        //IUI? IUI.input(string? input)
        //{
        //    if (input == null || input == "") { return null; }
        //    if (nestedUI != null)
        //    {
        //        IUI? returnUI = nestedUI.input(input);
        //        nestedUI = returnUI;
        //        return this;
        //    }

        //    try
        //    {
        //        int inputNum = int.Parse(input);
        //        switch (inputNum)
        //        {
        //            case 1:
        //                {
        //                    nestedUI = new ChangeName(SetName);
        //                    return this;
        //                }
        //            case 2:
        //                {
        //                    nestedUI = new CreateStat(stats);
        //                    return this;
        //                }
        //            case 3:
        //                {
        //                    nestedUI = new CreateAttack(attacks);
        //                    return this;
        //                }
        //            case 4:
        //                {
        //                    ICreature creature = Factorys.internal_creature_factory.CreateCreature(name, stats, attacks);
        //                    creatures.Add(creature);
        //                    return null;
        //                }
        //            case 5: return null;
        //            default:
        //                {
        //                    screen += "\nError: input must be a number from the list";
        //                    return this;
        //                }
        //        }
        //    }
        //    catch
        //    {
        //        screen += "\nError: input must be a number";
        //        return null;
        //    }
        //}

        internal CreateCreature(string? header,Action<ICreature> addCreature,IUI parent): base (header)
        {
            this.creatures = creatures;
            this.actions = [
                            new NavigateTo("back",parent)];
        }
    }
}
