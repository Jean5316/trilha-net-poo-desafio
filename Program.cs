using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia("99475787", "LX-3", "030005", 8);
nokia.InstalarAplicativo("Telegram");
nokia.ReceberLigacao();
nokia.Ligar();


Console.WriteLine("\nSmartphone Iphone");
Iphone iphone = new Iphone("99475785", "13", "0305", 8);
iphone.InstalarAplicativo("Netflix");
iphone.ReceberLigacao();
iphone.Ligar();