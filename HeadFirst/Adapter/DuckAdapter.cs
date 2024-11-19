using HeadFirst.Adapter.Models;

namespace HeadFirst.Adapter;

public class DuckAdapter : ITurkey
{
    private readonly IDuck _duck;

    public DuckAdapter(IDuck duck)
    {
        _duck = duck;
    }

    public void Fly()
    {
        //Так как утки летают намного дальше индюшек, мы решили, что
        //утка будет летать в среднем один раз из пяти.
        Random random = new Random();
        int rndNum = random.Next(0, 5);
        if(rndNum == 0)
            _duck.Fly();
    }

    public void Gobble()
    {
        _duck.Quack();
    }
}
