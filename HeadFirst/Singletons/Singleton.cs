namespace HeadFirst.Singletons;

public class Singleton
{
    private static Singleton? uniqueInstance;

    public Guid Guid;

    public static Singleton GetInstance()
    {
        if (uniqueInstance == null)
        {
            uniqueInstance = new Singleton();
            uniqueInstance.Guid = Guid.NewGuid();
        }

        return uniqueInstance;
    }
}
