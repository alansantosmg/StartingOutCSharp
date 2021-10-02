using System;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Area do triangulo!");
      Console.WriteLine("------------------\n");

      const double TDIVISOR = 2;
      double tBase, tHeight, result;

      Console.Write("Input the triangle's base: ");

      if(double.TryParse(Console.ReadLine(), out tBase))
      {

        Console.Write("Input the triangle's height: ");

        if (double.TryParse(Console.ReadLine(), out tHeight))
        {

          result = (tBase * tHeight) / TDIVISOR;
          Console.WriteLine($"The triangle's area is {result.ToString("n2")}");

        }
        else
        {
          Console.WriteLine("Input a number for triangle height.");
        }







      }
      else
      {
        Console.WriteLine("Input a number for triangle base");
      }
      Console.ReadKey();
      


    }

  
  }
}
