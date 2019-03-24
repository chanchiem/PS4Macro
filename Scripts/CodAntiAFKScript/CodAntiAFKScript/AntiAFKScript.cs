using System.Timers;
using PS4MacroAPI;

namespace CodAntiAFKScript
{
    public class AntiAfkScript : ScriptBase
    {
        public AntiAfkScript()
        {
            Config.Name = "AntiAfkScript";
            Config.LoopDelay = 1000; // in ms
        }

        public override void Start()
        {
            base.Start();
        }

        public override void Update()
        {
            Press(new DualShockState() { R2 = 0xFF });
            Sleep(1000);
            Press(new DualShockState() { Square = true });
            Sleep(1000);
        }
    }
}