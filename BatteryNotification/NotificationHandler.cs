namespace BatteryNotification
{
    public class NotificationHandler
    {
        private static readonly string NotificationHeader = "Battery Status";

        public static void Notify(string message)
        {
            // 
            // 
            // TODO:
            // Expand this to enable calls to the ToastUtility project,
            // as and where necessary.
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
            Program.MessageBox((IntPtr)0, message, NotificationHeader, 0);
        }
    }
}