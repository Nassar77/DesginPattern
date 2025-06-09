public class ConfigurationManager
{
    private static ConfigurationManager _instance;
    private static readonly object _lock = new object();

    public string DatabaseConnectionString { get; private set; }
    public string ApplicationName { get; private set; }

    // المُنشئ خاص لمنع إنشاء الكائن من الخارج
    private ConfigurationManager()
    {
        // محاكاة تحميل الإعدادات
        Console.WriteLine("Loading configuration...");
        DatabaseConnectionString = "Server=.;Database=MyApp;Trusted_Connection=True;";
        ApplicationName = "My Cool App";
    }

    // الوصول إلى الكائن الوحيد
    public static ConfigurationManager GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new ConfigurationManager();
                }
            }
        }

        return _instance;
    }
}

