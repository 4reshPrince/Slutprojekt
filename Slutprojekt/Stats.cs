using System;


class Stats
{
    public static (string, Username) stats(string stat, Username u)
    {
        while (stat != "strength" && stat != "endurance" && stat != "agility")
        {
        Console.WriteLine($"Player Name: {u.name}");
        Console.WriteLine();
    
        Console.WriteLine("Choose your stats:");
        Console.WriteLine();

        Console.WriteLine("Strength");
        Console.WriteLine();

        Console.WriteLine("Endurance");
        Console.WriteLine();

        Console.WriteLine("Agility");
        Console.WriteLine();

        Console.Write("Write your choice here:");
    
        stat = Console.ReadLine().ToLower();
        Console.Clear();
        }


        if (stat == "strength")
        {
            Console.WriteLine("Strength");
            Console.WriteLine();

            //Strength – 23 Endurance - 12 Agility – 15
            Console.WriteLine("Strength - 23");
            Console.WriteLine("Endurance - 12");
            Console.WriteLine("Agility - 15");
        }

        if (stat == "endurance")
        {
            Console.WriteLine("Endurance");
            Console.WriteLine();

            //Strength – 15 Endurance – 23 Agility – 12
            Console.WriteLine("Strength - 15");
            Console.WriteLine("Endurance - 23");
            Console.WriteLine("Agility - 12");
        }

        if (stat == "agility")
        {
            Console.WriteLine("Agility");
            Console.WriteLine();

            //Strength – 12 Endurance – 15 Agility – 23
            Console.WriteLine("Strength - 12");
            Console.WriteLine("Endurance - 15");
            Console.WriteLine("Agility - 23");
        }

        Console.ReadLine();


        return (stat, u);

    }
    
}
