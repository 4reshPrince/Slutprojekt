using System;


// Skapar en ny instans av klassen Username
Username u = new Username();

u.ReadUsername();


string stat = "";

while (stat != "strength" && stat != "endurence" && stat != "agility")
{
    Console.WriteLine($"Player Name: {u.name}");
    Console.WriteLine();
    
    Console.WriteLine("Choose your stats:");
    Console.WriteLine();

    Console.WriteLine("Strength");
    Console.WriteLine();

    Console.WriteLine("Endurence");
    Console.WriteLine();

    Console.WriteLine("Agility");
    Console.WriteLine();

    Console.Write("Write your choice here:");

    stat = Console.ReadLine().ToLower();
    Console.Clear();
}


if (stat == "strength")
{
Console.WriteLine("Stats");
}

Console.ReadLine();
Console.Clear();