using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 internal class Factory<T> where T : new()
 {
    private T[] objects;
    private int index = 0;
    

    public Factory(int size = 5)
    {
        objects = new T[size];
    }

    public T Instantiate()
    {

        if(index >= objects.Length)
        {
            Console.WriteLine("No more can be created");

            return default;
        }
        T clone = new();
       
        objects[index] = clone;


            return objects[index++];
    }
 }

