using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      // Marks Calculator
      Console.Write("Enter your maths marks: ");
      int mats = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter your science marks: ");
      int sci = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter your social studies marks: ");
      int sos = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter your geography marks: ");
      int geo = Convert.ToInt32(Console.ReadLine());

      int totalMarks = Convert.ToInt32(mats + sci + sos + geo);
      Console.WriteLine("Your total Marks are: " + totalMarks);
     }
  }
}