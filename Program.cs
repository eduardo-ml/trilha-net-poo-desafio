using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "1234", modelo: "Modelo 1", imei: "1111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("YouTube");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "6789", modelo: "Modelo 2", imei: "2222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("TikTok");