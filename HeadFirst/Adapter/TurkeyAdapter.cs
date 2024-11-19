using HeadFirst.Adapter.Models;

namespace HeadFirst.Adapter;

public class TurkeyAdapter : IDuck
{
    private readonly ITurkey _turkey;
    public TurkeyAdapter(ITurkey turkey)
    {
        this._turkey = turkey;
    }

    public void Fly()
    {
        for (int i = 0; i < 5; i++)
        {
            _turkey.Fly();
        }
    }

    public void Quack()
    {
        _turkey.Gobble();
    }
}
