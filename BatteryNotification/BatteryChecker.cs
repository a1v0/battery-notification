namespace BatteryNotification
{
    public class BatteryChecker
    {
        private static readonly byte FullChargeThreshold = 98;

        public static void HandleFullBattery()
        {
            Program.SYSTEM_POWER_STATUS status;
            if (Program.GetSystemPowerStatus(out status))
            {
                byte batteryLife = status.BatteryLifePercent;

                Console.WriteLine($"Battery Life Percent: {batteryLife}%");
                
                bool isCharging = status.ACLineStatus == 1; // TODO: check if there can be any other value other than 1 and 0. Should the check actually be != 0? Does this return 0 if battery is at 100%?

                if (!isCharging)
                {
                    Console.WriteLine("Battery not charging.");
                    return;
                }

                bool thresholdIsMet = batteryLife >= FullChargeThreshold;

                if (!thresholdIsMet) return;

                NotificationHandler.Notify($"Battery Charge: {batteryLife}%.\n\nPlease unplug device.");
            }
            else
            {
                Console.WriteLine("Unable to get battery status.");
                NotificationHandler.Notify("Unable to get battery status."); // This could become irritating if inability to access the battery status is a frequent occurrence
            }
        }
    }
}