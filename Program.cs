using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone("283388", "10", "29323228", 128);
iphone.Ligar();
iphone.InstalarAplicativo("whatsap");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia("22222", "nokia", "11111", 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("telegran");