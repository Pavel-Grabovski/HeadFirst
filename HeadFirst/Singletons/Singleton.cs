using System.Runtime.CompilerServices;

namespace HeadFirst.Singletons;

public class Singleton
{
    private static Singleton _uniqueInstance = new Singleton();

    public readonly Guid Guid;

    private Singleton()
    {
        Guid = Guid.NewGuid();
    }

    //[MethodImpl(MethodImplOptions.Synchronized)]
    public static Singleton GetInstance()
    {
        Console.WriteLine(_uniqueInstance.Guid.ToString());
        return _uniqueInstance;
        //lock (uniqueInstance)
        //{
        //    if (uniqueInstance == null)
        //    {
        //        uniqueInstance = new Singleton();
        //    }

        //    return uniqueInstance;
        //}
    }

}
