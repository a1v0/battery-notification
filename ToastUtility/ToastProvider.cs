using Microsoft.Toolkit.Uwp.Notifications;

namespace ToastUtility
{
    public class ToastProvider
    {
        private ToastContentBuilder ToastMessage
        {
            get;
        } = new ToastContentBuilder();

        public enum Type
        {
            FullBattery
        }
    }
}