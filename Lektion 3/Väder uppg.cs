using System;

class MainClass {
 static void Main()
{
  Console.WriteLine("Är det fint väder?: ");
  string svar = Console.ReadLine();
  if (svar == "ja" || svar == "Ja")
  Console.WriteLine("Vi går på picknick!");
  
  }
}
