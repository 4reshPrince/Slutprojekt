using System;

class Username
{

    public string name;

    public void ReadUsername()
    {
        string u = "";
        while (u.Length == 0)
        {
            Console.WriteLine("Write your Player Name:");

            u = Console.ReadLine();

            Console.Clear();
        }

        Console.WriteLine($"Player Name: {u}");

        Console.WriteLine();
            
        Console.Write("Press Enter to continue");

        Console.ReadLine();

        Console.Clear();

        name = u;

    }
}
