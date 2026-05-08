using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



internal class Knife : Weapon
{
    public int Damage = 10;
    public int Range = 2;

    public override void Attack()
    {
        Console.WriteLine($"Damage : {Damage}\t");
    }
}

