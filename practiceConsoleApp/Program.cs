using System;

namespace String
{
  class Program
  {
    static void Main(string[] args)
    {
      
      // Generate random number between 1 and 100
      Random random = new Random();
      int secretNumber = random.Next(1, 101);

      int guess;
      int attempts = 0;

      // Loop runs until the user guesses the correct number
      while(true)
      {
        attempts++;

        Console.WriteLine("Guess a number between 1 and 100 (attempt {0}):", attempts);
        guess = Convert.ToInt32(Console.ReadLine());

        if (guess < secretNumber){
          Console.WriteLine("Too low! Try again.");
        }
        else if (guess > secretNumber){
          Console.WriteLine("Too high! Try again.");
        }
        else{
          Console.WriteLine("Congrats! You guessed the number in {0} attempts ", attempts);
          break;
        }
      }

    }
  }
}