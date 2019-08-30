using System;

class MainClass {
 static void Main()
{
  Console.WriteLine("Är det fint väder?: ");
  string svar = Console.ReadLine();
  if (svar == "ja" || svar == "Ja")
  Console.WriteLine("Vi går på picknick!");
  else if (svar == "nej" || svar == "Nej")
  Console.WriteLine("Vi stannar inne och läser en bok");
  else
  Console.WriteLine("Jag förstår inte");
  }
}
