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
                byte batteryLife = status.BatteryLifePercent; // TODO: This returns 0 to 100, or 255 if unknown. Need to handle 255

                bool isCharging = status.ACLineStatus != 0; // 0 is not charging; 1 is charging; 255 is unknown, which I am treating the same as 1
                // N.B.: status.BatteryFlag also contains useful charging info. ACLineStatus will return 1 even when there's no battery

                if (!isCharging)
                {
                    return;
                }

                bool thresholdIsMet = batteryLife >= FullChargeThreshold;

                if (!thresholdIsMet) return;

                NotificationHandler.NotifyToast($"1 {batteryLife}");
            }
            else
            {
                NotificationHandler.NotifyBasic("Unable to get battery status."); // This could become irritating if inability to access the battery status is a frequent occurrence
            }
        }
    }
}