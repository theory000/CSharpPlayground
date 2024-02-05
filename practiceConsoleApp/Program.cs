using System;
using System.ComponentModel;

namespace String
{
  class Program
  {
    static void Main(string[] args)
    {

      // Guessing a number

      Random random = new Random();
      int secNum = random.Next(1, 100);

      int guess;
      int attempts = 0;

      while (attempts < 5) {
          Console.WriteLine("Guess a number between 1 and 100 (inclusive).");
          Console.WriteLine("You have spend {0} out of 5 attempts.", attempts);

          try {
              guess = Convert.ToInt32(Console.ReadLine());
          } catch (FormatException) {
              Console.WriteLine("Invalid input. Please enter a number.");
              continue;
          }

          if (guess < 1 || guess > 100) {
              Console.WriteLine("Please enter a number between 1 and 100.");
              continue;
          }

          int difference = Math.Abs(guess - secNum);

          if (guess == secNum) {
              Console.WriteLine("Congrats, you guessed the number in {0} attempts!", attempts);
              break;
          } else if (difference > 20) {
              Console.WriteLine("Way too {0}! Try again.", guess < secNum ? "low" : "high");
          } else if (difference > 10) {
              Console.WriteLine("Getting closer, but still {0}. Try again.", guess < secNum ? "low" : "high");
          } else {
              Console.WriteLine("Very close! Just a little {0}. Try again.", guess < secNum ? "lower" : "higher");
          }

          attempts++;
        }

        if (attempts == 5) {
        Console.WriteLine("Sorry, you ran out of guesses. The secret number was {0}.", secNum);
        }


      
    }
  }
}