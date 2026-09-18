using Konyv;
Konyvek konyv1 = new Konyvek();
konyv1.Cim = "A gyűrűk ura";
konyv1.Oldalszam = 1178;
konyv1.Kiadaseve = 1954;

Konyvek konyv2 = new Konyvek("A legyek ura");
konyv2.Oldalszam = 224;
konyv2.Kiadaseve = 1964;

Konyvek konyv3 = new Konyvek("A kis herceg", 96, 1943);

Console.WriteLine($"{konyv1.Cim}, {konyv1.Oldalszam}, {konyv1.Kiadaseve}");
Console.WriteLine($"{konyv2.Cim}, {konyv2.Oldalszam}, {konyv2.Kiadaseve}");
Console.WriteLine($"{konyv3.Cim}, {konyv3.Oldalszam}, {konyv3.Kiadaseve}");