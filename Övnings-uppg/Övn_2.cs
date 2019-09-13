using System;

namespace Övn_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Vad är rektangelns längd?: ");
            double tal1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vad är rektangelns bredd?: ");
            double tal2 = Convert.ToDouble(Console.ReadLine());
            if (tal1 == tal2)
            {
                Console.WriteLine("Det är ingen rektangel! Objektet är en kvadrat");
            }
            else
            {
                Console.WriteLine("Arean på rektangeln är");
                Console.WriteLine(tal1 * tal2);
                Console.WriteLine("Omkrätsen på rektangeln är");
                Console.WriteLine(tal1 + tal2 + tal1 + tal2);
            }


        }
    }
}
