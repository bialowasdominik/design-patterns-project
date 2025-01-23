namespace Projekt_zaliczeniowy.Logger
{
    public class Logger
    {
        private static Logger _instance;

        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }

        public void Log(string message)
        {
            Console.WriteLine($"[LOG {DateTime.Now:HH:mm:ss}]: {message}");
        }
    }
}
