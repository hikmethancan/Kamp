﻿using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazilim Gelistirici Yetistirme Kampi";
            string kurs2 = "Programlama Baslangic Icin Temel Kurs";
            string kurs3 = "Java";
            //array=dizi
            string[] kurslar = new string[] { "Yazilim Gelistirici Yetistirme Kampi", "Programlama Baslangic Icin Temel Kurs", "Java","Python" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }

            Console.WriteLine("sayfa sonu");
        }

    }
}
