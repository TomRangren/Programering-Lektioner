{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Vad är priset på eran vara?: ");
            int pris = int.Parse(Console.ReadLine());

            if (pris > 500) {
                Console.Write("Rabbaten är ");
                Console.Write(pris * 0.1);
                Console.Write(" Kr");
            }
            else {
                Console.Write("Rabbaten är ");
                Console.Write(pris * 0.02);
                Console.Write(" Kr");
            }



        }
    }
}
