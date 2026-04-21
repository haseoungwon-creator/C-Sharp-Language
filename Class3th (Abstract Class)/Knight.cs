using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Knight : Soldier
{
    public Knight() 
    {
        health = 200;
        defence = 5;
    }
    public override void Attack()
    {
        Console.WriteLine("Knight Attack\n");
    }
}
