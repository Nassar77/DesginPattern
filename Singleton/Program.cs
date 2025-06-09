
class Program
{
    static void Main(string[] args)
    {
        var config1 = ConfigurationManager.GetInstance();
        var config2 = ConfigurationManager.GetInstance();

        Console.WriteLine(config1.ApplicationName);
        Console.WriteLine(config1.DatabaseConnectionString);

        // تحقق أن الكائنين هما نفس المرجع
        Console.WriteLine(object.ReferenceEquals(config1, config2)); // True
    }
}

