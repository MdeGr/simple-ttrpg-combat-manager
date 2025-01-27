using simple_ttrpg_combat_manager.UI;
using consoleFrontendFramework.UiPreset;
using consoleFrontendFramework.interfaces;
using consoleFrontendFramework.ActionPreset;
using simple_ttrpg_combat_manager.UI.screens.Create;
using simple_ttrpg_combat_manager.UI.screens.load;
using simple_ttrpg_combat_manager.UI.screens;

//initiolizing start screen
string header = "Simple combat manager\n" +
            " by: Merel de Graauw\n\n";
StartScreen startscreen = new StartScreen(header);

//initiolize UI manager
UIManager uiManager = new UIManager(startscreen);

//first loading of UI
Console.WriteLine(uiManager.RunCycle(""));
//core running loop
while (uiManager.GetRunning() == true)
{
    string? input = Console.ReadLine();
    Console.Clear();
    string output = uiManager.RunCycle(input);
    Console.WriteLine(output);
}

Console.WriteLine("The aplication has stopped");