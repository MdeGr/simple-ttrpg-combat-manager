using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using consoleFrontendFramework.interfaces;
using simple_ttrpg_combat_manager.UI.screens;

namespace simple_ttrpg_combat_manager.UI
{
    internal class UIManager
    {
        private IUI curentUI { get; set; }

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
                    IUI? newUI = curentUI.input(input);

                    if (newUI != null)
                    {
                        curentUI = newUI;
                    }
                    try
                    {
                        Exit exit = (Exit)newUI;
                        isRunning = !exit.GetExit();
                    }
                    catch { }
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
                if (curentState == null || curentState == "")
                {
                    throw new NullReferenceException("Curent UI element is empty");
                }

                Console.Clear();
                Console.WriteLine(curentState);
            }
            else
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }
    }
}
