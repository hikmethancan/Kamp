using System;

namespace DictionaryOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("1. isim"," hikmethan can");
            myDictionary.Add("2. isim"," uzbay yelce");
            myDictionary.Add("3. isim"," mehmet tuzcu");

            myDictionary.Sonuc();


        }
    }
}
