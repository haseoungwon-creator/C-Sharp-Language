using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal abstract class Product
    {
        protected string name;
        protected int price;
        protected string menual;

        public void Describe()
        {
            Console.WriteLine($"Name : {name}, Price : {price}, Menual : {menual}");
            Console.WriteLine();
        }


    }
}
