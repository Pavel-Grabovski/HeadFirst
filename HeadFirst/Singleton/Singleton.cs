namespace HeadFirst.Singleton;

public class Singleton
{
    private static Singleton? uniqueInstance;

    public static Singleton GetInstance()
    {
        if (uniqueInstance == null)
            uniqueInstance = new Singleton();

        return uniqueInstance;
    }
}
