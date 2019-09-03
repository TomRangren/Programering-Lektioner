using System;

class MainClass
{
    public static void Main()
    {
        Console.Write("Skriv in ett tal mellan 1 och 101: ");
        int i = int.Parse(Console.ReadLine());
            for (int I = i; I < 101; I++) //Man får inte använda samma variabel och fick då gå med I
            //För att programmet ska kunna avläsa talet man skrev så måste int I=i
            {
                Console.WriteLine(I);
            }
        }
    }
