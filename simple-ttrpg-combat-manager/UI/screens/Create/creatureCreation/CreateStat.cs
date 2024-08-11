using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simple_ttrpg_combat_manager.UI.Interfaces;
using simple_ttrpg_combat_manager.UI.screens.Create.general;
using ttrpg_combat_engine.coreEngine.attack;
using ttrpg_combat_engine.coreEngine.interfaces;
using ttrpg_combat_engine.utility.interfaces;

namespace simple_ttrpg_combat_manager.UI.screens.Create.creatureCreation
{
    internal class CreateStat : IUI
    {
        private List<IStat> stats;
        private string name;
        private int normalValue;

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
        internal bool SetNormVal(int normalValue)
        {
            try
            {
                this.normalValue = normalValue;
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
                screen = "Create creature\n\n";
                try { screen += $"name: {name}\n"; } catch { }
                try { screen += $"normal value: {normalValue}\n"; } catch { }

                screen += "\n1)Change name\n" +
                    "2)Change normal value\n" +
                    "3)Confirm\n" +
                    "4)Back";

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
                            nestedUI = new ChangeName(SetName);
                            return this;
                        }
                    case 2:
                        {
                            nestedUI = new ChangeNumber(SetNormVal);
                            return this;
                        }
                    case 3:
                        {
                            IStat stat = Factorys.internal_stat_factory.CreateStat(name, normalValue);
                            stats.Add(stat);
                            return null;
                        }
                    case 4: return null;
                    default:
                        {
                            return this;
                        }
                }
            }
            catch { return this; }
        }
        internal CreateStat(List<IStat> stats)
        {
            this.stats = stats;
        }
    }
}
