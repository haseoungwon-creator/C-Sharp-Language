using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Seller : ICommunicable, ISellable
{
    public int money = 100;
    public void Sell(int SellMoney)
    {
        money += SellMoney;
        Console.WriteLine("Sell this");
        Console.WriteLine($"Money : {money}");
        if (money > 1000)
        {
            Console.WriteLine("Wow Good");
        }
        Console.WriteLine();
    }
    public void Communicable()
    {
        Console.WriteLine("Talking to customer");
        Console.WriteLine();
    }
}
