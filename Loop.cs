class LoopExample()
{
  private int[] num = [];
  private string name = string.Empty;

  public void ListLetters(string name)
  {
    this.name = name;
    foreach (char letter in name)
    {
      Console.WriteLine(letter);
    }
  }


  public void ListNumbers(int[] num)
  {
    this.num = num;
    foreach (int n in num)
    {
      Console.WriteLine($"{n}");
    }
  }
}