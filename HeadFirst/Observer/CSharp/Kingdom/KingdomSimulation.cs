using HeadFirst.Observer.CSharp.Kingdom.Observable;
using HeadFirst.Observer.CSharp.Kingdom.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst.Observer.CSharp.Kingdom;

public static class KingdomSimulation
{
    public static void Start()
    {
        Tsar tsar = new("Рюкик");

        Guard guard_1 = new Guard("Иван");
        Guard guard_2 = new Guard("Саня");
        Guard guard_3 = new Guard("Вова");

        guard_1.Subscribe(tsar);
        guard_2.Subscribe(tsar);
        guard_3.Subscribe(tsar);


        Order order_1 = new() { Message = "Выпороть!" };
        Order order_2 = new();

        tsar.IssueDecree(order_1);
        tsar.IssueDecree(order_2);
        tsar.IssueDecree(null);

        guard_3.Unsubscribe();

        tsar.IssueDecree(order_1);

        tsar.Abdication();

        tsar.IssueDecree(order_1);

        guard_1.Subscribe(tsar);


        tsar.IssueDecree(order_1);
    }
}
