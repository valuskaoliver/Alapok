using Auto;

Autok kek = new Autok();
kek.Marka = "Toyota";
kek.Eletkor = 5;
Autok zold = new Autok();
Console.Write("Kérem az autó márkáját");
zold.Marka = Console.ReadLine();
Console.Write("Kérem az autó életkorát");
zold.Eletkor = int.Parse(Console.ReadLine());

Console.WriteLine($"A kék autó márkája: {kek.Marka} és életkora: {kek.Eletkor}");
Console.WriteLine($"A zöld autó márkája: {zold.Marka} és életkora: {zold.Eletkor}");