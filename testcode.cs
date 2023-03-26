using GTA;
using System.Windows.Forms;

public class MyMod : Script
{
    public MyMod()
    {
        Tick += OnTick;
    }

    private void OnTick(object sender, EventArgs e)
    {
        if (Game.Player.Character.IsInVehicle())
        {
            Game.Player.Character.CurrentVehicle.EngineRunning = true;
        }
    }
}
