class TryParseFunction
{
  public static void Run()
  {
    Console.WriteLine("Enter a number to parse");
    string inputData = Console.ReadLine() ?? string.Empty;
    bool isParsed = int.TryParse(inputData, out var result);

    if (isParsed)
    {
      Console.WriteLine($"Parsed successfully: {result}");
    }
    else
    {
      Console.WriteLine("Failed to parse the input.");
    }
  }
}