using DesafioPOO.Models;

// Testes com as classes Nokia e Iphone
Console.WriteLine("Este é o Smartphone Iphone");
Smartphone iphone = new Iphone("11 948822959", "Iphone 13 PRO Max", "2124373487324", 128);
Console.WriteLine($"Este é o número do aparelho:{iphone.Numero}");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Este é o Smartphone NOKIA");
Smartphone nokia = new Nokia("18 99790-1991", "Lumia 1020", "1970666", 264);
Console.WriteLine($"Este é o número do aparelho:{nokia.Numero}");
nokia.InstalarAplicativo(" Gayminho de gundam");

Console.WriteLine("Aperte qualquer tecla para encerrar");
Console.ReadKey();