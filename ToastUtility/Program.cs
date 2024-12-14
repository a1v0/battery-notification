using Microsoft.Toolkit.Uwp.Notifications;

namespace ToastUtility
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                return;
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













            new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddArgument("conversationId", 9813)
                .AddText("Andrew sent you a picturesdmsd")
                .AddText("Check this out, The Enchantments in Washington!")
                .Show();
        }
    }
}
