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
        //Tsar tsar = new("Рюкик");

        //Guard guard_1 = new Guard("Иван");
        //Guard guard_2 = new Guard("Саня");
        //Guard guard_3 = new Guard("Вова");

        //guard_1.Subscribe(tsar);
        //guard_2.Subscribe(tsar);
        //guard_3.Subscribe(tsar);


        //Order order_1 = new() { Message = "Выпороть!" };
        //Order order_2 = new();

        //tsar.IssueDecree(order_1);
        //tsar.IssueDecree(order_2);
        //tsar.IssueDecree(null);

        //guard_3.Unsubscribe();

        //tsar.IssueDecree(order_1);

        //tsar.Abdication();

        //tsar.IssueDecree(order_1);

        //guard_1.Subscribe(tsar);


        //tsar.IssueDecree(order_1);

        Console.WriteLine("----------------------------");

        Tsar tsar_2 = new("Ярополк первый");

        Tsar tsar_3 = new("Николай третий");

        Guard guard_4 = new Guard("Сергей");

        guard_4.Subscribe(tsar_2);
        guard_4.Subscribe(tsar_3);


        Order order_3 = new() 
        {
            Message = "Всем повысить жалование",
            Signature = tsar_2.Name
        };

        Order order_4 = new()
        {
            Message = "Воскресенье отдыхаем",
            Signature = tsar_3.Name
        };


        tsar_2.IssueDecree(order_3);
        tsar_3.IssueDecree(order_4);


        guard_4.Unsubscribe();

        tsar_2.IssueDecree(order_3);
        tsar_3.IssueDecree(order_4);

        guard_4.Unsubscribe();


        tsar_2.IssueDecree(order_3);
        tsar_3.IssueDecree(order_4);
    }
}
