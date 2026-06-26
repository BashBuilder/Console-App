using System.Runtime.InteropServices;

class FunctionExample
{
  public static void Run(int a, [Optional] int b)
  {
    Console.WriteLine($"The sum of the two numbers are {a + b}, a is {a}, b is {b}");
  }

  public static bool tryInt(out int num, int number)
  {
    return int.TryParse(number.ToString(), out num);
  }
}