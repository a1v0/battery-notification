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

            foreach (string arg in args)
            {
                ToastProvider toastProvider = new();
                try
                {
                    int toastType = int.Parse(arg);
                    toastProvider.ShowToast((ToastProvider.Type)toastType);
                }
                catch
                {
                    toastProvider.ShowToast(ToastProvider.Type.InvalidArgsError, arg);
                }
            }
        }
    }
}
