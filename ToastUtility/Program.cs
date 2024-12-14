using Microsoft.Toolkit.Uwp.Notifications;

namespace ToastUtility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new ToastContentBuilder()
                .AddText("Andrew sent you a picturesdmsd")
                .AddText("Andrew sent you a pictures")
                .SetToastScenario(ToastScenario.Reminder)
                .AddButton(new ToastButtonDismiss())

                // 
                // TODO:
                // un-hard-code this URI
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
                .AddAppLogoOverride(new Uri(@"C:\Users\mensu\Desktop\battery-notification\ToastUtility\toast-icon.png"), ToastGenericAppLogoCrop.Circle)
                .Show();
            if (args.Length < 1)
            {
                // 
                // TODO:
                // trigger notification 
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
                // return;
            }
            // 
            // 
            // TODO:
            // cycle through args and trigger notifications accordingly
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
        }
    }
}
