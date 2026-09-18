using Jatekos;

Jatekosok jatekos1 = new Jatekosok();
jatekos1.Nev = "Béla";
jatekos1.Elet = 300;

Jatekosok jatekos2 = new Jatekosok();
jatekos2.Nev = "József";
jatekos2.Elet = -50;

Console.WriteLine($"{jatekos1.Nev}: {jatekos1.Elet} élete");
Console.WriteLine($"{jatekos2.Nev}: {jatekos2.Elet} élete");