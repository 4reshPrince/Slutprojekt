using System;

class Enemy: Username
{
    int xp = 0;
    int level = 1;

    public AddExperience(int amount)
    {
        xp += amount;
        level = 1 + xp / 10;
    }
}
