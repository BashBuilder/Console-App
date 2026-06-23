class DictionaryExample()
{
  public static void RunExample()
  {
    Console.WriteLine("This line is executed");
    var myDetails = new Dictionary<string, string>
    {
      { "name", "anthony" }
    };

    Dictionary<string, string> names = new()
    {
      { "firstName", "Anthony" },
      { "lastName", "Adelowotan" }
    };

    for (int i = 0; i < names.Count; i++)
    {
      KeyValuePair<string, string> pair = names.ElementAt(i);
      Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
    }
    Console.WriteLine(names);
  }
}