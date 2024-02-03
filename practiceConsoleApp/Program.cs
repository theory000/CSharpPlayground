using System;

namespace RandomNumberGenerator
{
  class Program
  {
    static void Main(string[] args)
    {

      int min, max;

      Console.WriteLine("Enter Minimum Value: ");
      min = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter Maximum Value: ");
      max = Convert.ToInt32(Console.ReadLine());

      Random random = new Random();

      // Generate a random double between 0 and 1
      double randomDouble = random.NextDouble();

      // Calculate the range considering negative values are possible
      int range = (max - min) + 1;

      // Multiply the random double by the range and cast to int
      int randomNum = (int)(randomDouble * range) + min;

      Console.WriteLine("Random number: {0}", randomNum);


    }
  }
}