Console.Write("Enter the original string: ");
string origin = Console.ReadLine();
Console.Write("Enter the string you want to replace: ");
string old = Console.ReadLine();
Console.Write("Enter the new string: ");
string nw= Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"The new string is: {origin.Replace(old, nw)}\n");
Console.ForegroundColor = ConsoleColor.White;