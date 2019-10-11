using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            int antal = 5;
            double summa = 0, tal;

            for(int i = 0; i < antal; i++)
            {
                Console.Write("Skriv in ett tal: ");
                tal = Convert.ToDouble(Console.ReadLine());
                summa += tal;
            }

            Console.WriteLine("Medelvärdet blir: " + summa / antal);
        }
    }
}
