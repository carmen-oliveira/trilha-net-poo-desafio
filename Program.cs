using DesafioPOO.Models;

Console.WriteLine("Cadastrando um Smartphone da Nokia");

Smartphone nokia = new Nokia("11999013256", "Nokia G21", "31239855019123", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Cadastrando um Smartphone Iphone");

Smartphone iphone = new Iphone("11985315507", "Iphone 16 Pro", "901235706134605", 256);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");