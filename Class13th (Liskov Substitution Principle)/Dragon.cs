using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Dragon : Enemy, IFlyabls
{
    public Dragon() 
    {
        health = 200;
        damage = 50;
        speed = 10;
    }
    
    
    public override void Attack()
    {

        Console.WriteLine($"Damage : {damage}\t \"불 뿜기\"");
    }

    public void Fly()
    {
        Console.WriteLine("50m high - altitude flight");
    }

    public override void Patrol()
    {
        Console.WriteLine("Move int all direction");
    }
}

