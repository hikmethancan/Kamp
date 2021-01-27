using System;

namespace GenericsInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            // Mylist<string> gibi ifade kullanirsan <> icerisine calisacagin turu girmek zorundasin uyari verir

            isimler.Add(" Hikmet");
            // listemiz string oldugu icin Add komutunda string ifade girmek zorundasin



            
        }
    }
}
