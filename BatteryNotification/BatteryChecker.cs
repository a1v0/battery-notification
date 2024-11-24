namespace BatteryNotification
{
    public class BatteryChecker
    {
        public static bool CheckIsFull()
        {
            Program.SYSTEM_POWER_STATUS status;
            if (Program.GetSystemPowerStatus(out status))
            {
                Console.WriteLine("Battery Life Percent: {0}%", status.BatteryLifePercent);
                Console.WriteLine("Battery Life Time: {0} seconds", status.BatteryLifeTime);
                Console.WriteLine(status.ACLineStatus); // This determines whether the battery is charging: 1=yes, 0=no
            }
            else
            {
                Console.WriteLine("Unable to get battery status.");
            }
            // 
            // TODO:
            // improve placeholder
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
            return true;
        }
    }
}