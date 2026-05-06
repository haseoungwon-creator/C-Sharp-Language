using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Sentinel: IDamageable, ICommunicable
{

    public int HP = 100;
    public void Damageable(int Damage)
    {
        Console.WriteLine($"HP : {HP}");
        HP -= Damage;
        if ( HP >= 0 )
        {
            
            Console.WriteLine($"Took {Damage} damage\tHP : {HP}");
        }
        if( HP <= 0 ) 
        {
            Console.WriteLine("Die");
        }
        Console.WriteLine();

    }

    public void Communicable()
    {
        Console.WriteLine("hello");
        Console.WriteLine();
    }
}

