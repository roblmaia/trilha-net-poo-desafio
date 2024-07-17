using System.Security.Cryptography;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone c1 = new Iphone("(41)9 9999-9999","iPhone 14","GTA741258",128);
c1.InstalarAplicativo("Telegram");
c1.Ligar();
c1.DadosSmartphone();


Nokia n1 = new Nokia("(42)9 8888-8888","N10","ABC123456",256);
n1.InstalarAplicativo("Netflix");
n1.ReceberLigacao();
n1.DadosSmartphone();