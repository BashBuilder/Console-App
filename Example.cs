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
      int g, h, i;
      Console.WriteLine("Hello, world");
      Console.WriteLine($"a: {a}, b: {b}, c : {c}, maxValue : {double.MaxValue} , minValue : {double.MinValue}");
      Console.WriteLine($"d: {d}, e: {e}, f : {f}");
    }
  }
}