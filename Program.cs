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

    static void Main(string[] args)
    {
      // user input 
      Console.WriteLine("Enter first number:");
      string firstNumber = Console.ReadLine();

      Console.WriteLine("Enter second number:");
      string secondNumber = Console.ReadLine();

      // checking
      Console.WriteLine("Your input: " + firstNumber + " and " + secondNumber);
      Console.WriteLine("The result is: ");
      Console.WriteLine(BasicMultiplication(int.Parse(firstNumber), int.Parse(secondNumber)));
    }
  }
}
