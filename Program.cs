using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "1111111", memoria: 64);
Console.WriteLine($"Número = {nokia.Numero}");
Console.WriteLine($"Modelo = {nokia.Modelo}");
Console.WriteLine($"IMEI = {nokia.Imei}");
Console.WriteLine($"Memória = {nokia.Memoria}");

nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n") ;

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo 2", imei: "2222222", memoria: 128);
Console.WriteLine($"Número = {iphone.Numero}");
Console.WriteLine($"Modelo = {iphone.Modelo}");
Console.WriteLine($"IMEI = {iphone.Imei}");
Console.WriteLine($"Memória = {iphone.Memoria}");

iphone.ReceberLigacao() ;
iphone.InstalarAplicativo("Telegram");
