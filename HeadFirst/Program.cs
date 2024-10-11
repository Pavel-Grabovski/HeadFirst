using HeadFirst.Observer.CSharp.Kingdom;
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

        KingdomSimulation.Start();

    }
}
