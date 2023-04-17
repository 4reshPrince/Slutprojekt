using System;

class Username
{

    public string name;

    public void ReadUsername()
    {
        string u = "";
        while (u.Length == 0)
        {
            Console.Write("Write your Player Name:");

            u = Console.ReadLine();

            Console.Clear();
        }

        name = u;

    }
}
