// الواجهة المشتركة للمراقب
// الموضوع (Subject)
public class WeatherStation
{
    private List<IObserver> observers = new List<IObserver>();
    private float temperature;

    public void AddObserver(IObserver observer) => observers.Add(observer);
    public void RemoveObserver(IObserver observer) => observers.Remove(observer);

    public void SetTemperature(float temp)
    {
        temperature = temp;
        NotifyObservers();
    }

    private void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(temperature);
        }
    }
}
