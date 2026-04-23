using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Obstacle
{
    private int x, y;

    public Obstacle()
    {
        x = 0;
        y = 0;
    }

    public void Translate(int x, int y)
    {
        this.x = x;
        this.y = y;

        Console.WriteLine("x : " + x );
        Console.WriteLine("y : " + y);
    }

}
