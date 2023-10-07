using DesafioPOO.Models;

Smartphone Nokia = new Nokia(numero: "111111", modelo: "Nokia", imei: "111111111", memoria: 6);
Console.WriteLine("Smartphone Nokia:");
Nokia.Ligar();
Nokia.InstalarAplicativo("DIO");

Console.WriteLine("\n");

Smartphone Iphone = new Iphone(numero: "222222", modelo: "Iphone", imei: "222222222", memoria: 8);
Console.WriteLine("Smartphone Iphone:");
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("IDE Code");


