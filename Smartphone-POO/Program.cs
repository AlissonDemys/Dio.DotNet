using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("123456", "Modelo 1", "11111", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia");
Smartphone iphone = new Iphone("123456", "Modelo 1", "11111", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");