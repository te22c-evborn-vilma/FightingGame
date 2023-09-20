using System;

Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;

Console.WriteLine("A is fighting B");

int hp1 = 100;
string char1 = "A";

int hp2 = 100;
string char2 = "B";

Random generator = new Random();

while (hp1 > 0 && hp2 > 0)
{
  Console.ForegroundColor = ConsoleColor.Black;
  Console.WriteLine("\n----- NEW GAME -----");
  Console.WriteLine($"{char1}: {hp1}hp  {char2}: {hp2}hp");
  
  Console.ForegroundColor = ConsoleColor.DarkCyan;
  int aDMG = generator.Next(15);
  hp2 -= aDMG;
  hp2 = Math.Max(0, hp2);
  Console.WriteLine($"{char1} does {aDMG} DMG on {char2}");

  Console.ForegroundColor = ConsoleColor.DarkRed;
  int bDMG = generator.Next(15);
  hp1 -= bDMG;
  hp1 = Math.Max(0, hp1);
  Console.WriteLine($"{char2} does {bDMG} DMG on {char1}");

  Console.ForegroundColor = ConsoleColor.Black;
  Console.WriteLine("Press any button to continue");
  Console.ReadKey();
}

Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("\nThe fight is over");

if (hp1 == 0 && hp2 == 0)
{
  Console.WriteLine("The fight was tied");
}
else if (hp1 == 0)
{
  Console.ForegroundColor = ConsoleColor.DarkRed;
  Console.WriteLine($"The winner is {char2}");
}
else
{
  Console.ForegroundColor = ConsoleColor.DarkCyan;
  Console.WriteLine($"The winner is {char1}");
}

Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("Press any button to end");
Console.ReadKey();