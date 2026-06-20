
namespace ConsoleApp;

class Condition
{
  public static void Run()
  {
    int num = 10;

    switch (num)
    {
      case 0:
        Console.WriteLine("Zero");
        break;
      case 1:
        Console.WriteLine("One"); break;
      case 2:
        Console.WriteLine("");
        break;
      default:
        Console.WriteLine("Default case");
        break;
    }


    Console.WriteLine("In the conditional example");
    Console.WriteLine(num);
  }
}


