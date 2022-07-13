// class- metod- koleksiyon birlikte kullanacağın bir uygulama yap. rent a car olabilir.
// 1-arabanın özelliklerini class a aktarabilirsin.
// 2- odenecek tutarı methodla hesaplayabilirsin
// 3- eklenecek yeni arabaları arraylistle sıralayabilirsin.
// alış tarihi- veriş tarihi- sürücü yaşı- araba seçimine yönlendirme- arabaları listele- arabaya göre fiyat belirleme metodu

using General_projectx;



Console.WriteLine("Araba Kiralama Uygulamasına Hoşgeldiniz.");
Console.WriteLine();

Console.WriteLine("Lütfen alış tarihini giriniz (g.a.y):");
DateTime alisTarihi = Convert.ToDateTime(Console.ReadLine());

Console.WriteLine("Lütfen iade tarihini giriniz (g.a.y):");
DateTime iadeTarihi = Convert.ToDateTime(Console.ReadLine());

TimeSpan kiralanacakGun = iadeTarihi-alisTarihi;
//Console.WriteLine(kiralanacakGun.TotalDays.ToString());

Console.WriteLine("Lütfen sürücünün yaşını giriniz:");
int surucuYasi = Convert.ToInt16(Console.ReadLine());

Araba araba1 = new Araba();
araba1.ID = 1;
araba1.Marka = "Ford";
araba1.Model = "Tourneo";
araba1.KiralamaFiyati = 758;

Araba araba2 = new Araba();
araba2.ID = 2;
araba2.Marka = "Hyundai";
araba2.Model = "i20";
araba2.KiralamaFiyati = 804;

Araba araba3 = new Araba();
araba3.ID = 3;
araba3.Marka = "Toyoa";
araba3.Model = "C-HR";
araba3.KiralamaFiyati = 1058;

Araba araba4 = new Araba();
araba4.ID = 4;
araba4.Marka = "Hyundai";
araba4.Model = "i20";
araba4.KiralamaFiyati = 804;

Araba araba5 = new Araba();
araba5.ID = 5;
araba5.Marka = "Fiat";
araba5.Model = "Egea";
araba5.KiralamaFiyati = 730;

Araba araba6 = new Araba();
araba6.ID = 6;
araba6.Marka = "Audi";
araba6.Model = "A6";
araba6.KiralamaFiyati = 1263;

List<Araba> arabalar = new List<Araba>();
arabalar.Add(araba1);
arabalar.Add(araba2);
arabalar.Add(araba3);
arabalar.Add(araba4);
arabalar.Add(araba5);
arabalar.Add(araba6);




if (surucuYasi>=18)
    {
    Araba.ArabaGetir(arabalar);
    //metotu cagırıp parametre olarak da olusturdugum listın adını gonderdım.
    Console.WriteLine();
    int secim = 7;
    while (secim >6 || secim<1)
    {


        Console.WriteLine("Araba seçimini yapınız (numara ile):");
        secim = Convert.ToInt16(Console.ReadLine());


        switch (secim)
        {
            case 1:
                Araba.OdemeHesapla(araba1, kiralanacakGun);
                break;

            case 2:
                Araba.OdemeHesapla(araba2, kiralanacakGun);
                break;
            case 3:
                Araba.OdemeHesapla(araba3, kiralanacakGun);
                break;
            case 4:
                Araba.OdemeHesapla(araba4, kiralanacakGun);
                break;
            case 5:
                Araba.OdemeHesapla(araba5, kiralanacakGun);
                break;
            case 6:
                Araba.OdemeHesapla(araba6, kiralanacakGun);
                break;


            default:
                Console.WriteLine("Hatali secim yaptiniz.");
                break;
        }
    }
    }
    else
    {
    Environment.Exit(0);

    }
  
Console.ReadKey();



















