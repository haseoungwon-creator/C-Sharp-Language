using System.Diagnostics.Tracing;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int select;

            ISelectable[] Object =
                {
                    new Frame(),
                    new Clock(),
                    new Switch()
                };

            for (int i = 0; i < Object.Length; i++)
            {
                Console.Write("Select an Object (0 : Frame, 1 : Clock, 2 : Switch) : ");
                select = int.Parse(Console.ReadLine());
                if (select >= 0 && select < 3)
                {
                    Object[select].Select();
                }
                else
                    i--;
            }





        }
    }
}


