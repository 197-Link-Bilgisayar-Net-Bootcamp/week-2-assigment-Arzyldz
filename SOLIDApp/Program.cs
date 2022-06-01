

//SRP — Single Responsibility Principle (Tek Sorumluluk Prensibi)
using static SOLIDApp.LSP;
using static SOLIDApp.OCP;
using static SOLIDApp.SRP;

//SRP — Single Responsibility Principle (Tek Sorumluluk Prensibi)
Customer singleCustomer = new Customer();
Console.WriteLine(singleCustomer.Register("Arzu", "123", "arz@hotmail"));

//OCP — Open Closed Principle (Açık Kapalı Prensibi)
List<Sekil> listSekil = new List<Sekil>();

listSekil.Add(new Kare(8));
listSekil.Add(new Daire(6));

AlanToplamiHesaplama alanToplamiHesaplama = new AlanToplamiHesaplama();
Console.WriteLine(alanToplamiHesaplama.AlanToplamlari(listSekil));

//LSP — Liskov Substitution Principle (Liskov Yerine Geçme Prensibi)
Kus kus = new Penguen();
string penguen= $"Penguneni adı = {kus.LatinceAdi}" + $"kanat aralığı = {kus.KanatAraligi}";
Console.WriteLine(penguen);
kus = new Baykus();
((Baykus)kus).UcmaMesafesi();
Console.WriteLine("UcmaMesafesi sadece baykusa ait bir özellik");


//ISP — Interface Segregation Principle (Arayüz Ayrımı Prensibi)


//DIP — Dependency Inversion Principle (Bağımlılıkların Tersine Çevrilmesi Prensibi)




