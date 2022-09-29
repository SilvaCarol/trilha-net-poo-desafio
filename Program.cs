using DesafioPOO.Models;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "145", modelo: "Modelo 12", iMEI: "3242545", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "690", modelo: "Modelo 33", iMEI: "23423423", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");