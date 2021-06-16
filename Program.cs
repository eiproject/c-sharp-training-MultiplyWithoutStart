using System;

namespace TrainingMultiplication
{
  class RunMultiplication
  {
    static int BasicMultiplication(int a, int b)
    {
      if (b == 0) return 0;
      return a + BasicMultiplication(a, b-1);
    }

    static int AdvanceMultiplication(int a, int b)
    {
      if (a == 0 || b == 0) return 0; // when multiply by zero
      else if (b == 1) return a; // when mutiply by one
      else if ((b & 1) == 0) return AdvanceMultiplication(a + a, b >> 1); // when even number
      else return a + AdvanceMultiplication(a + a, b >> 1);
    }

    static void Main(string[] args)
    {
      // Test something
      // Console.WriteLine(-4 & 1);
      // Console.WriteLine(-4 >> 1);
      int x = -5;
      while (x != -1)
      {
        Console.WriteLine(x);
        x >>= 1;
      }

      // user input 
      Console.WriteLine("Enter first number:");
      string firstNumber = Console.ReadLine();

      Console.WriteLine("Enter second number:");
      string secondNumber = Console.ReadLine();

      // checking
      Console.WriteLine("Your input: " + firstNumber + " and " + secondNumber);
      Console.WriteLine("The result is: ");

      //Console.WriteLine("Basic Result: ");
      //int basic_result = BasicMultiplication(int.Parse(firstNumber), int.Parse(secondNumber));
      //Console.WriteLine(basic_result);

      //Console.WriteLine("Advance Result: ");
      int advanceResult = AdvanceMultiplication(Convert.ToInt32(firstNumber), Convert.ToInt32(secondNumber));
      Console.WriteLine(advanceResult);
    }
  }
}
