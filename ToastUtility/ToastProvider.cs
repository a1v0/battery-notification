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

        /// <summary>
        /// Handles the display of all toast messages.
        /// </summary>
        /// <param name="type">Toast message type, as determined by enum.</param>
        /// <param name="data">Optional string of data to be included in toast message.</param>
        public void ShowToast(Type type, string? data = null)
        {
            switch (type)
            {
                case Type.FullBattery:
                    BuildFullBatteryToast(data);
                    break;
                case Type.NoArgsError:
                    BuildErrorToast("Error: No arguments given.", "ToastUtility called without any arguments.");
                    break;
                case Type.InvalidArgsError:
                    BuildErrorToast("Error: Invalid arguments provided.", $"Input arguments '{data}' cannot be converted into a valid toast.");
                    break;
                case Type.TooManyArgsError:
                    BuildErrorToast("Error: Too many arguments given.", $"ToastUtility can take exactly 1 or 2 arguments.");
                    break;
                default:
                    BuildErrorToast("Error: Invalid toast type given.", $"Type '{type}' is not a recognised toast type.");
                    break;
            }

            ToastMessage.Show();
        }

        private void BuildFullBatteryToast(string? batteryLife)
        {
            ToastMessage.SetToastScenario(ToastScenario.Alarm);

            SetHeader("Unplug your machine.");

            string body = "Your battery is fully charged and can be unplugged.";
            if (batteryLife != null)
            {
                bool isValidByte = byte.TryParse(batteryLife, out byte result);
                if (isValidByte) body = $"Battery charge: {batteryLife}%. Please unplug device.";
            }

            SetBody(body);
        }

        private void BuildErrorToast(string header, string body)
        {
            ToastMessage.SetToastScenario(ToastScenario.Alarm);

            SetHeader(header);
            SetBody(body);

            ToastMessage.AddAppLogoOverride(new Uri(@$"{AppContext.BaseDirectory}error-icon.png"), ToastGenericAppLogoCrop.Circle);
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
            NoArgsError = 400,
            InvalidArgsError = 401,
            TooManyArgsError = 402
        }

        private static ToastContentBuilder GetBaseToastMessage()
        {
            ToastContentBuilder baseToastMessage = new();

            Uri notificationSoundUri = new(@"C:\Windows\Media\Windows Notify System Generic.wav");
            baseToastMessage
                .AddAudio(notificationSoundUri)
                .AddButton(new ToastButtonDismiss())
                .AddAppLogoOverride(new Uri(@$"{AppContext.BaseDirectory}toast-icon.png"), ToastGenericAppLogoCrop.Circle);

            return baseToastMessage;
        }
    }
}