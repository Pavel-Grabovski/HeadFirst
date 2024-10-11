using HeadFirst.Observer.CSharp.Kingdom.Observable;
using HeadFirst.Observer.CSharp.Kingdom.Observers;
using System.Text;

namespace HeadFirst;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        //WeatherStation.Start();

        Tsar tsar = new("Рюкик");

        Guard guard_1 = new Guard("Иван");
        Guard guard_2 = new Guard("Саня");

        guard_1.Subscribe(tsar);
        guard_2.Subscribe(tsar);


        
    }
}
