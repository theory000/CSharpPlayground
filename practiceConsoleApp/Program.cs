using System;

namespace String
{
  class Program
  {
    static void Main(string[] args)
    {

      int votingAge = 18;
      string enterAge = "Enter your age: ";
      Console.Write(enterAge);
      bool success = int.TryParse(Console.ReadLine(), out int yourAge);


      if (yourAge >= votingAge) {
        Console.WriteLine("Your can vote.");
      }
      else if (yourAge < votingAge) {
        Console.WriteLine("You can't vote");
      } else {
        Console.WriteLine("Invalid Input!");
      }

    }
  }
}