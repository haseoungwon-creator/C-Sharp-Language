using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



abstract class Enemy
{
    protected int damage;
    protected int speed;
    protected int health;
    public abstract void Patrol();
    public abstract void Attack();
}

