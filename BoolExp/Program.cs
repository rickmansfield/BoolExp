using System;

namespace BoolExp
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      int apples = 18;
      int oranges = 9;
      Console.WriteLine(apples == oranges);
      Console.WriteLine(apples != oranges);
      Console.WriteLine($"{apples} > {oranges} is {apples > oranges}");
      Console.WriteLine($"{apples} < {oranges} is {apples < oranges}");
      Console.WriteLine($"{apples} >= {oranges} is {apples >= oranges}");
      Console.WriteLine($"{apples} <= {oranges} is {apples <= oranges}");
      Console.WriteLine($"{apples} is int is {apples is int}");
        }
  }
}
