using System;
using DesafioPOO.Models;


Console.WriteLine("\n\n");
Console.WriteLine("---------------------------------------------------------------------------------");

//Intanciando Iphone

Smartphone iphone = new Iphone(numero: "999999999", modelo: "Apple iPhone 11", imei: "XY0XX0Y0X0YX", memoria: 128);
iphone.Apresentar();
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();

Console.WriteLine("\n\n");
Console.WriteLine("---------------------------------------------------------------------------------");




//Intanciando Nokia

Smartphone Nokia = new Nokia(numero: "111111111", modelo: "Nokia G21", imei: "YX1YY1X1Y1YX", memoria: 62);
Nokia.Apresentar();
Nokia.Ligar();
Nokia.InstalarAplicativo("WhatsApp");
Nokia.ReceberLigacao();

Console.WriteLine("\n\n");
Console.WriteLine("---------------------------------------------------------------------------------");