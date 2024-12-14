using Microsoft.Toolkit.Uwp.Notifications;

namespace ToastUtility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddArgument("conversationId", 9813)
                .AddText("Andrew sent you a picture")
                .AddText("Check this out, The Enchantments in Washington!")
                .Show();
        }
    }
}
