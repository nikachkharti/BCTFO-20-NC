namespace Homeworks.MiniBank.Logger
{
    public static class ConsoleLogger /*: ILogger*/
    {
        public static void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
