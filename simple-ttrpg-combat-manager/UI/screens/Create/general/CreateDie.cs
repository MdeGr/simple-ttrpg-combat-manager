using simple_ttrpg_combat_manager.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ttrpg_combat_engine.coreEngine.interfaces;
using ttrpg_combat_engine.utility.interfaces;

namespace simple_ttrpg_combat_manager.UI.screens.Create.general
{
    internal class CreateDie : IUI
    {
        private Func<IDie, int, bool> setDie;
        private int max;
        private int min;
        private int number;

        private IUI? nestedUI;
        private string screen = "";

        internal bool SetMax(int max)
        {
            try
            {
                this.max = max;
                return true;
            }
            catch { return false; }
        }
        internal bool SetMin(int min)
        {
            try
            {
                this.min = min;
                return true;
            }
            catch { return false; }
        }
        internal bool SetNum(int number)
        {
            try
            {
                this.number = number;
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
                try { screen += $"max: {max}\n"; } catch { }
                try { screen += $"min: {min}\n"; } catch { }
                try { screen += $"number: {number}\n"; } catch { }

                screen += "\n1)Set Max\n" +
                    "2)Set min\n" +
                    "3)Set number of dice\n" +
                    "4)Confirm\n" +
                    "5)Back";

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
                            nestedUI = new ChangeNumber(SetMax);
                            return this;
                        }
                    case 2:
                        {
                            nestedUI = new ChangeNumber(SetMin);
                            return this;
                        }
                    case 3:
                        {
                            nestedUI = new ChangeNumber(SetNum);
                            return this;
                        }
                    case 4:
                        {
                            try
                            {
                                IDie die = Factorys.internal_die_factory.CreateDie(max, min);
                                setDie(die, number);
                                return null;
                            }
                            catch
                            {
                                screen += "somthing went wrong set all atributes";
                                return this;
                            }
                        }
                    case 5: return null;
                    default:
                        {
                            screen += "\nError: input must be a number from the list";
                            return this;
                        }
                }
            }
            catch
            {
                screen += "\nError: input must be a number";
                return null;
            }
        }

        internal CreateDie(Func<IDie, int, bool> setDie)
        {
            this.setDie = setDie;
        }
    }
}
