using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_projectx
{

    public class Araba
    {
        public int ID;
        public string Marka;
        public string Model;
        public double KiralamaFiyati;

        public static void OdemeHesapla(Araba araba, TimeSpan timeSpan)
        {
            Console.WriteLine("Odenecek Tutar: " + " " + araba.KiralamaFiyati * Convert.ToDouble(timeSpan.TotalDays) + "TL");
        }


        public static void ArabaGetir(List<Araba> arabalar)
            // void ama parametre olarak list<araba sınıfı> alan bir metot yazdım.
        {            
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba.ID + " " + araba.Marka + " " + araba.Model + " " + araba.KiralamaFiyati);
            }
        }

    }

}

    


    
