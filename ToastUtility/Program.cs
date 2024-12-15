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
                    // 
                    // TODO:
                    // This catch block occasionally catches other errors
                    // down the line, at which point the value of "args"
                    // isn't what it should be. Not sure what's causing
                    // this to happen, but it's currently not an important
                    // bug.
                    // 
                    toastProvider.ShowToast(ToastProvider.Type.InvalidArgsError, arg);
                }
            }
        }
    }
}
