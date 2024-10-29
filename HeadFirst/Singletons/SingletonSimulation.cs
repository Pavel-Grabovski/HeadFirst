using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst.Singletons;

public static class SingletonSimulation
{
    public static void Start()
    {
        Thread myThread1 = new Thread(Print);
        Thread myThread2 = new Thread(Print);

        myThread1.Start();  // запускаем поток myThread1
        myThread2.Start();  // запускаем поток myThread2


    }
    private static void Print(object? obj)
    {
        Singleton.GetInstance();
    }
}
