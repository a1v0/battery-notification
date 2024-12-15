namespace ToastUtility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                new ToastProvider().ShowToast(ToastProvider.Type.NoArgsError);
                return;
            }
            if (args.Length > 2)
            {
                // 
                // TODO:
                // Consider whether it's worth throwing this error or
                // just ignoring all args beyond 2
                // 
                new ToastProvider().ShowToast(ToastProvider.Type.TooManyArgsError);
                return;
            }

            string rawToastType = args[0];
            string? toastData = args.Length == 2 ? args[1] : null;

            ToastProvider toastProvider = new();
            try
            {
                int toastType = int.Parse(rawToastType);
                toastProvider.ShowToast((ToastProvider.Type)toastType, toastData);
            }
            catch
            {
                // 
                // TODO:
                // This catch block occasionally catches other errors
                // down the line, at which point the value of "args"
                // isn't what it should be. Not sure what's causing
                // this to happen, but it's currently not an important
                // bug.
                // 
                string errorData = toastData == null ? rawToastType : $"{rawToastType},{toastData}";
                toastProvider.ShowToast(ToastProvider.Type.InvalidArgsError, errorData);
            }
        }
    }
}
