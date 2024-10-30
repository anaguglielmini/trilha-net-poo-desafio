using DesafioPOO.Models;

// Implementado!
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia("11987654123", "Modelo1", "123456789101213", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("SoundCloud");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone("11932165498", "Modelo2", "032165498703216", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Samsung Wearable");