using HeadFirst.Adapter;
using HeadFirst.Commands;
using HeadFirst.Facade;
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

        //RemoteLoader.Start();

        //DuckTestDrive.Start();

        HomeTheaterTestDrive.Start();
    }
}
