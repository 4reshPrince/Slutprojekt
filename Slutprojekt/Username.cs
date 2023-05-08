using System;

class Username
{

    public string name;
    public int hp = 100;
    public int x = 0;
    public int y = 0;

    public void Hurt(int amount)
    {
        hp -= amount;
    }

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
