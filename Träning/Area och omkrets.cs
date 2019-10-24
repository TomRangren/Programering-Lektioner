using System;

class MainClass 
{
  public static void Main () 
  {
    Console.Write("Skriv diametern i cm: ");
    double diameter =Convert.ToDouble(Console.ReadLine()); 
    omkretsarea(diameter);
  }
   static void omkretsarea(double d)
  {
    Console.WriteLine("Omkretsen är " + (d*3.14)+" cm");
    Console.WriteLine("Arean är " + (d/2)*(d/2)*3.14+" cm2");
    Console.WriteLine("Halva cirkelns area är " + (d/2*d/2*3.14)/2+" cm2");
  }
}
