using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using simple_ttrpg_combat_manager.UI;

namespace simple_ttrpg_combat_manager
{
    internal class UIManager
    {
        private IUI curentUI {  get; set; }

        internal UIManager()
        {
            curentUI = new StartScreen();
        }
        internal UIManager(IUI UI)
        {
            curentUI = UI;
        }

        internal void run()
        {
            bool isRunning = true;
            while (isRunning)
            {
                try
                {
                    print(null);
                    string? input = Console.ReadLine();
                    curentUI.input(input);
                }
                catch (Exception e)
                {
                    print(e);
                    isRunning = false;
                }
            }
        }
        private void print(Exception? e)
        {
            if (e == null)
            {
                string curentState = curentUI.GetScreen();
                if (curentState != null) { throw new NullReferenceException("Curent UI element is empty"); }

                Console.WriteLine(curentState);
            }
            else
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
