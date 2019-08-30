using System;

class MainClass {
 static void Main()
{
Console.Write("Skriv ett tal: ");
int tal = int.Parse(Console.ReadLine());
if(tal > 50)
Console.WriteLine("Talet är större än 50");
else if(tal<50)
Console.WriteLine("Talet är mindre än 50");
else if(tal==50)
Console.WriteLine("Talet är lika stort");

 }
}
