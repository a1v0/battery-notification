namespace BatteryNotification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("No arguments given. Please provide argument and try again.");
                return;
            }
            if (args.Length > 1)
            {
                Console.WriteLine("Too many arguments given. Please provide one argument and try again.");
                return;
            }

            string arg = args[0];
            switch (arg)
            {
                case "check-full":
                    // TODO:
                    // rename argument
                    // it doesn't sound very good
                    break;
                default:
                    Console.WriteLine($"'{arg}' is not a recognised argument.");
                    return;
            }
        }
    }
}
