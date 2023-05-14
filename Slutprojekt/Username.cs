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
            List<string> listNamn = new List<string>();
            listNamn.Add("Jordan");
            listNamn.Add("Jack");
            listNamn.Add("Max");

            Console.WriteLine("Alternative names if you have hard to choose.");
            Console.WriteLine();


            Console.WriteLine(listNamn[0]);
            Console.WriteLine(listNamn[1]);
            Console.WriteLine(listNamn[2]);
            Console.WriteLine();


            Console.Write("Write your Player Name:");

            u = Console.ReadLine();

            Console.Clear();
        }

        name = u;

    }

    

}
