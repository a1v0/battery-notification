using System.Diagnostics;

namespace BatteryNotification
{
    public class NotificationHandler
    {
        private static readonly string NotificationHeader = "Battery Status";

        public static void NotifyBasic(string message)
        {
            Program.MessageBox((IntPtr)0, message, NotificationHeader, 0);
        }

        /// <summary>
        /// Calls EXE for ToastUtility, specifying arguments.
        /// </summary>
        /// <param name="args">String containing all CLI arguments to be provided to the ToastUtility.</param>
        public static void ShowToast(string args)
        {
            ProcessStartInfo startInfo = new();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = @$"{AppContext.BaseDirectory}ToastUtility.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = args;

            try
            {
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit(); // The `using` statement will close after the exit
                }
            }
            catch
            {
                NotifyBasic($"Error invoking {startInfo.FileName}.");
            }
        }
    }
}