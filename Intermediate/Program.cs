using System;

namespace Intermediate
{
   public class Person
   {
      public string Name;

      public void Introduce(string to)
      {
         Console.WriteLine($"Hi {to}, my name is {Name}");
      }

      public static Person Parse(string str)
      {
         var person = new Person();
         person.Name = str;

         return person;
      }
   }

   class Program
   {
      static void Main(string[] args)
      {
         var person = Person.Parse("John");
         person.Introduce("Mosh");
      }
   }

}
