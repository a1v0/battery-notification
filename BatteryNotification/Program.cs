using System;
using System.Runtime.InteropServices;

namespace BatteryNotification
{
    internal class Program
    {
        // Define SYSTEM_POWER_STATUS struct
        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEM_POWER_STATUS
        {
            public byte ACLineStatus;
            public byte BatteryFlag;
            public byte BatteryLifePercent;
            public byte Reserved1;
            public uint BatteryLifeTime;
            public uint BatteryFullLifeTime;
        }

        // Import GetSystemPowerStatus from kernel32.dll
        [DllImport("kernel32.dll")]
        public static extern bool GetSystemPowerStatus(out SYSTEM_POWER_STATUS sps);

         [DllImport("User32.dll", CharSet = CharSet.Unicode)]
         public static extern int MessageBox(IntPtr h, string m, string c, int type); // Using MessageBox here prevents us from needing to ship the code with Windows Forms

        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("No arguments given. Please provide argument and try again.");
                return;
            }
            if (args.Length > 1)
            {
                Console.WriteLine("Too many arguments given. Please provide one argument and try again.");
                return;
            }

            string arg = args[0];
            switch (arg)
            {
                case "check-full":
                    // TODO:
                    // rename argument
                    // it doesn't sound very good
                    BatteryChecker.HandleFullBattery();
                    // 
                    // TODO:
                    // create notification class to send resultant message
                    // 
                    // 
                    // 
                    // 
                    // 
                    // 
                    // 
                    break;
                default:
                    Console.WriteLine($"'{arg}' is not a recognised argument.");
                    return;
            }
        }
    }
}
