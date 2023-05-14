using System;


// Skapar en ny instans av klassen Username
Username u = new Username();

u.ReadUsername();

Enemy myEnemy = new Enemy();

myEnemy.name = "Fatgeek";

myEnemy.Hurt(3);


string stat = "";

(stat, u) = Stats.stats(stat, u);