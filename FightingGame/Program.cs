using System;

Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;

Console.WriteLine("Welcome to my fighting game!");
Console.WriteLine("You are fighting someone");

int hp1 = 100;
string char1 = "You";

int hp2 = 100;
string char2 = "Someone";

Random generator = new Random();

Console.WriteLine($"\n{char1} is fighting {char2}");

while (hp1 > 0 && hp2 > 0)
{
  Console.ForegroundColor = ConsoleColor.Black;
  Console.WriteLine("\n----- NEW GAME -----");
  Console.WriteLine($"{char1}: {hp1}hp  {char2}: {hp2}hp");
  
  Console.ForegroundColor = ConsoleColor.DarkCyan;
  int char1DMG = generator.Next(25);
  hp2 -= char1DMG;
  hp2 = Math.Max(0, hp2);
  Console.WriteLine($"{char1} does {char1DMG} DMG on {char2}");

  Console.ForegroundColor = ConsoleColor.DarkRed;
  int char2DMG = generator.Next(25);
  hp1 -= char2DMG;
  hp1 = Math.Max(0, hp1);
  Console.WriteLine($"{char2} does {char2DMG} DMG on {char1}");

  Console.ForegroundColor = ConsoleColor.Black;
  Console.WriteLine("Press any button to continue the fight");
  Console.ReadKey();
}

Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("\nThe fight is over");

if (hp1 == 0 && hp2 == 0)
{
  Console.WriteLine("It's a tie!");
}
else if (hp1 == 0)
{
  Console.ForegroundColor = ConsoleColor.DarkRed;
  Console.WriteLine($"The winner is {char2}!");
}
else
{
  Console.ForegroundColor = ConsoleColor.DarkCyan;
  Console.WriteLine($"The winner is {char1}!");
}

Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("Press any button to end");
Console.ReadKey();