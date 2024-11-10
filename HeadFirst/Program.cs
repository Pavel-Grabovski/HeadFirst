using HeadFirst.Commands;
using System.Text;

namespace HeadFirst;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        //WeatherStation.Start();

        //KingdomSimulation.Start();

        //SingletonSimulation.Start();

        //RemoteControlTest.Start();

        RemoteLoader.Start();
    }
}
