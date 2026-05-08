using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Slime : Enemy
{
    public Slime()
    {
        health = 50;
        damage = 5;
        speed = 2;
    }
    
    public override void Attack()
    {
        Console.WriteLine($"Damage : {damage}\t \"철퍽\"");
    }

    public override void Patrol()
    {
        Console.WriteLine($"Speed : {speed}\t \"질퍽질퍽\"");
    }
}

