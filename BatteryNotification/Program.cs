using System.Runtime.InteropServices;

namespace BatteryNotification
{
    internal class Program
    {
        // 
        // TODO:
        // Convert this to Windows Console app to prevent the opening the console when executing
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        // 
        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEM_POWER_STATUS
        {
            // More info here: https://learn.microsoft.com/en-us/windows/win32/api/winbase/ns-winbase-system_power_status
            public byte ACLineStatus;
            public byte BatteryFlag;
            public byte BatteryLifePercent;
            public byte Reserved1;
            public uint BatteryLifeTime;
            public uint BatteryFullLifeTime;
        }

        [DllImport("kernel32.dll")]
        public static extern bool GetSystemPowerStatus(out SYSTEM_POWER_STATUS sps);

        [DllImport("User32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr h, string m, string c, int type); // Using MessageBox here prevents us from needing to ship the code with Windows Forms, which ought to improve performance

        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                // Console.WriteLine("No arguments given. Please provide argument and try again.");
                return;
            }
            if (args.Length > 1)
            {
                // Console.WriteLine("Too many arguments given. Please provide one argument and try again.");
                return;
            }

            string arg = args[0];
            switch (arg)
            {
                case "full-battery":
                    BatteryChecker.HandleFullBattery();
                    break;
                default:
                    // Console.WriteLine($"'{arg}' is not a recognised argument.");
                    return;
            }
        }
    }
}
