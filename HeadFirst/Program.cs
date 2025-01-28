using HeadFirst.Adapter;
using HeadFirst.Commands;
using HeadFirst.Facade;
using HeadFirst.IteratorAndLinkerPattern;
using HeadFirst.DeputyPattern;
using HeadFirst.TemplateMethod;
using System.Text;
using HeadFirst.CompositionPatterns;

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

        //HomeTheaterTestDrive.Start();

        //BeverageTestDrive.Start();

        //GumballMachineTestDrive.Start();

        //DinerMenuTestDrive.Start();

        DuckSimulator.Start();
    }
}
