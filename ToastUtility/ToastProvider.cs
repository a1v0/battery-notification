using Microsoft.Toolkit.Uwp.Notifications;

namespace ToastUtility
{
    public class ToastProvider
    {

        private ToastContentBuilder? _toastMessage;
        private ToastContentBuilder ToastMessage
        {
            get
            {
                _toastMessage ??= GetBaseToastMessage();
                return _toastMessage;
            }
        }

        public void ShowToast(Type type)
        {
            switch (type)
            {
                case Type.FullBattery:
                    BuildFullBatteryToast();
                    break;
                case Type.NoArgsError:
                    BuildErrorToast("Error: No arguments given.", "ToastUtility called without any arguments.");
                    break;
                default:
                    break;
            }

            ToastMessage.Show();
        }

        private void BuildFullBatteryToast()
        {
            ToastMessage.SetToastScenario(ToastScenario.Alarm);
            SetHeader("Unplug your machine.");
            SetBody("Your battery is fully charged and can be unplugged.");
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
            ToastMessage.AddAppLogoOverride(new Uri(@"C:\Users\mensu\Desktop\battery-notification\ToastUtility\toast-icon.png"), ToastGenericAppLogoCrop.Circle);
        }

        private void BuildErrorToast(string header, string body)
        {
            ToastMessage.SetToastScenario(ToastScenario.Alarm);
            SetHeader(header);
            SetBody(body);
            // 
            // TODO:
            // provide suitable icon
            // 
            // 
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
            ToastMessage.AddAppLogoOverride(new Uri(@"C:\Users\mensu\Desktop\battery-notification\ToastUtility\toast-icon.png"), ToastGenericAppLogoCrop.Circle);
        }

        private void SetHeader(string headerText)
        {
            ToastMessage.AddText(headerText);
        }

        private void SetBody(string bodyText)
        {
            ToastMessage.AddText(bodyText);
        }

        public enum Type
        {
            FullBattery = 1,
            NoArgsError = 400
        }

        private static ToastContentBuilder GetBaseToastMessage()
        {
            ToastContentBuilder baseToastMessage = new();

            Uri notificationSoundUri = new(@"C:\Windows\Media\Windows Notify System Generic.wav");
            baseToastMessage
                .AddAudio(notificationSoundUri)
                .AddButton(new ToastButtonDismiss());

            return baseToastMessage;
        }
    }
}