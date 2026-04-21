using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Guard : Soldier
{
    public Guard()
    {
        health = 300;
        defence = 7;
    }
    public override void Attack()
    {
        Console.WriteLine("Guard Attack\n");
    }
}
