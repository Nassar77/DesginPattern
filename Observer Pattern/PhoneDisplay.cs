using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern;
public class PhoneDisplay : IObserver
{
    public void Update(float temperature)
    {
        Console.WriteLine($"the temperature in your phone is Updated: {temperature}°C");
    }
}
