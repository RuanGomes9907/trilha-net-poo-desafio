using System.ComponentModel;
using DesafioPOO.Models;

Console.WriteLine("\n__________________________\n");


Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "(12)997365714", modelo: "G11 Plus NK095", imei: "12122333", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("'Whatsapp'");


Console.WriteLine("\n__________________________\n");


Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "(12)998873675", modelo: "XS", imei: "111111111", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("'Instagram'");


Console.WriteLine("\n__________________________\n");




