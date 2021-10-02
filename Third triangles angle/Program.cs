using System;

namespace Third_triangles_angle
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Calcular terceiro angulo do triangulo");
      Console.WriteLine("-------------------------------------\n");

      const double MAX_DEGREE = 180;

      // initialize variables
      double angle1, angle2, angle3;

            
      // Input and test first angle
      // First angle must be < than 180 degrees

      Console.Write("Entre com valor do primeiro angulo interno: ");

      if (double.TryParse(Console.ReadLine(), out angle1) && angle1 < MAX_DEGREE)
      {

        // Input and test second angle
        // Second angle must be <= second angle

        Console.Write("Entre com valor do segundo ângulo interno: ");

        if (double.TryParse(Console.ReadLine(), out angle2) && angle2 < MAX_DEGREE &&  angle2 <= (MAX_DEGREE - angle1))
        {
          
          // calculate third degree
          angle3 = MAX_DEGREE- angle1 - angle2;

          // show result
          Console.WriteLine($"Terceiro Ângulo interno = {angle3}");
        }

        else
        {
          Console.WriteLine();
          Console.WriteLine($"Entre somente números." +
                            $" O valor do segundo angulo deve ser sempre menor ou igual à diferença entre 180 graus e valor do primeiro ângulo.");
        }
                
      }
      else
      {
        Console.WriteLine();
        Console.WriteLine($"Entre apenas com Numeros." +
                          $"O valor do primeiro ângulo deve ser sempre menor que 180");
      }

    }
  }
}
