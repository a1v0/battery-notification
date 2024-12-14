using Microsoft.Toolkit.Uwp.Notifications;

namespace ToastUtility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new ToastContentBuilder()
                .SetToastScenario(ToastScenario.Alarm)
                .AddText("Andrew sent you a picturesdmsd")
                .AddText("Andrew sent you a pictures")
                .AddButton(new ToastButtonDismiss())
                .AddAudio(new Uri(@"C:\Windows\Media\Windows Notify System Generic.wav"))
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
