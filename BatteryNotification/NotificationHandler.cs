namespace BatteryNotification
{
    public class NotificationHandler
    {
        private static readonly string NotificationHeader = "Battery Status";

        public static void Notify(string message)
        {
            Program.MessageBox((IntPtr)0, message, NotificationHeader, 0);
        }
    }
}