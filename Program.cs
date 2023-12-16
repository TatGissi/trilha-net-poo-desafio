using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "99999-9999", modelo: "Modelo ABC", imei: "111111111", memoria: 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "8888-8888", modelo: "Modelo XYZ", imei: "121212121", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");