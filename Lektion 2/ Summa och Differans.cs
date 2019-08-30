using System;

class MainClass {
  static void Main()
  {
Console.Write("Skriv in första heltalet: ");
string N1 = Console.ReadLine();
int tal1 = int.Parse(N1);
Console.Write("Skriv in andra heltalet: ");
string N2 = Console.ReadLine();
int tal2 = int.Parse(N2);
Console.Write("Summan= ");
Console.WriteLine(tal1+tal2);
Console.Write("Differans= ");
Console.WriteLine(tal1-tal2);
  }
}
