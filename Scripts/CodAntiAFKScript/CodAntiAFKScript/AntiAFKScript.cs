using System;
using System.Timers;
using PS4MacroAPI;

namespace CodAntiAFKScript
{
    public class AntiAfkScript : ScriptBase
    {
        private static Random rand = new Random();

        public AntiAfkScript()
        {
            Config.Name = "AntiAfkScript";
            Config.LoopDelay = 1000; // in ms
        }

        public override void Start()
        {
            base.Start();
        }

        public void wait_random_seconds(int base_time, int min_rand, int max_rand) { Sleep(base_time + rand.Next(min_rand, max_rand)); }

        public override void Update()
        {
//            Press(new DualShockState() { Cross = true });
//            wait_random_seconds(1000, 500, 1500);
//            Press(new DualShockState() { R3 = true });
//            wait_random_seconds(1000, 500, 1500);
//            Press(new DualShockState() { Square = true });
//            wait_random_seconds(1000, 500, 1500);

//            Press(new DualShockState() { Square = true });
            Press(new DualShockState() { LX = 0xFF }, 4000);
            wait_random_seconds(500, 500, 1500);
            Press(new DualShockState() { LX = 0x00 }, 4000);
            wait_random_seconds(500, 500, 1500);
            Press(new DualShockState() { Cross = true });
            wait_random_seconds(500, 500, 1500);

        }
    }
}