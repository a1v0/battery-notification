using Microsoft.Toolkit.Uwp.Notifications;

namespace ToastUtility
{
    public class ToastProvider
    {
        private ToastContentBuilder ToastMessage
        {
            get;
        } = new ToastContentBuilder();

        private void SetHeader(string headerText)
        {
            ToastMessage.AddText(headerText);
        }

        public enum Type
        {
            FullBattery
        }
    }
}