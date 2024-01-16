namespace Homeworks.MiniBank.Logger
{
    public static class FileLogger /*: ILogger*/
    {
        public static string _filePath = @$"../../../MiniBank/Logger/log.txt";

        public static void Log(string message)
        {
            File.AppendAllText(_filePath, message);
        }
    }
}
