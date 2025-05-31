using Observer_Pattern;

public class Program
{
    public static void Main()
    {
        var station = new WeatherStation();
        var phone = new PhoneDisplay();

        station.AddObserver(phone);

        station.SetTemperature(25.3f);  // سيتم إشعار الهاتف بالتحديث
        station.SetTemperature(30.1f);  // إشعار جديد
    }
}