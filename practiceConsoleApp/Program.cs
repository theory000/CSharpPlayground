using System;

namespace String
{
  class Program
  {
    static void Main(string[] args)
    {

     string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
      cars[0] = "Opel";
      Console.WriteLine(cars[0]);
      // Now outputs Opel instead of Volvo

    }
  }
}