using app.Class;

Chaise brutuce3000 = new Chaise();
Console.WriteLine($"{brutuce3000.couleur}");
brutuce3000.couleur = "Bleu";
Console.WriteLine($"{brutuce3000.couleur}");
Console.WriteLine(brutuce3000.ToStrings());