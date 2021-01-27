using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = " Elma";
            double fiyati = 15;
            string aciklama = " Amasya elmasi";

            

            Product urun1 = new Product();

            urun1.Adi = " Elma ";
            urun1.Fiyati = 15;
            urun1.Aciklama = " Amasya elmasi";

            Product urun2 = new Product();
            urun2.Adi = " Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = " Diyarbakir karpuzu";

            Product[] urunler = new Product[] { urun1, urun2 };
            // type safe -- tip guvenligi onemli/ Verilerin bas harfi buyuk harf

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------");



            }

            Console.WriteLine("------------Metodlar----------");

            SepetManager sepet = new SepetManager();

            sepet.Ekle(urun1);
            sepet.Ekle(urun2);

            
            






        }
    }
}
