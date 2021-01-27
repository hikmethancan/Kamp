using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 320000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalis butonu ");

            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("artis butonu");
            }
            else
            {

                Console.WriteLine("degismedi butonu");
            }
            



            Console.WriteLine(kategoriEtiketi);


            
        }
    }
}
