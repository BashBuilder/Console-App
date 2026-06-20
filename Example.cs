using System;


namespace ConsoleApp
{
  internal class Example
  {
    static void Main(string[] args)
    {
      int a = 10;
      long b = 20L;
      double c = -30.5D;

      int d = 121, e = 122, f = 123;
      Console.WriteLine("Hello, world");
      Console.WriteLine($"a: {a}, b: {b}, c : {c}, maxValue : {double.MaxValue} , minValue : {double.MinValue}");
      Console.WriteLine($"d: {d}, e: {e}, f : {f}");

      Console.WriteLine($"{a + b} {a - b} {a * b} {a / b} {a % b} {a++} {++a} {a--} {--a}");

      // string types
      string name = "Anthony";
      char initials = 'A';
      Console.WriteLine($"My name is {name} and my initial is {initials}");

      string firstName = Convert.ToString(Console.ReadLine()) ?? string.Empty;
      string lastName = Convert.ToString(Console.ReadLine()) ?? string.Empty;

      int ageInt = Convert.ToInt32(Console.ReadLine());

      if (ageInt < 18)
      {
        Console.WriteLine("You are a minor");
      }
      else if (ageInt >= 18 && ageInt < 65)
      {
        Console.WriteLine("You are an adult");
      }
      else
      {
        Console.WriteLine("You are a senior citizen");
      }

      Console.WriteLine($"My name is {firstName} {lastName} and I am {ageInt} years old.");



      // constants
      const int num = 1000;
      Console.WriteLine(num);

      // num = 299;


    }
  }
}