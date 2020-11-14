using System;
using System.Security.Cryptography.X509Certificates;

namespace Methods
{
   class Program
   {
      static void Main(string[] args)
      {
         var point = new Point(10,20);
         point.Move(new Point(40,60));
         Console.WriteLine($"Point X {point.X} Point Y {point.Y} ");

         point.Move(100, 200);
         Console.WriteLine($"Point X {point.X} Point Y {point.Y} ");
      }
   }
}
