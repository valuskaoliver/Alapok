using Valuta;

ValutaValto marcius = new ValutaValto();
marcius.Arfolyam = 385.5;
Console.WriteLine($"Euró: 100 Árfolyam:{marcius.Arfolyam}, huf: {marcius.EurorolHuf(100)}");
ValutaValto junius = new ValutaValto();
junius.Arfolyam = 390.5;
Console.WriteLine($"Euró: 100 Árfolyam:{junius.Arfolyam}, huf: {junius.EurorolHuf(100)}");

double fixHuf = ValutaValto.FixErorolHuf(100);
Console.WriteLine($"Euró: 100, Árfolyam fix: 400, HuF: {fixHuf}");