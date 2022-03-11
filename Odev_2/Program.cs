using System;
using System.Collections.Generic;
using System.IO;

namespace Odev_2 //Haşim Ensar Kavak 2018280027
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin;
            MyList liste = new MyList();
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    Console.WriteLine("Lütfen {0}. Metni Giriniz: ", i + 1);
                    metin = Console.ReadLine().ToLower();
                    liste.ParcalaEkle(metin);
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }
            Console.WriteLine("===========================================================");
            HashSet<string> hashSet = new HashSet<string>(liste);
            MyTable tablo = new MyTable(liste);
            tablo.KelimeSay();
            try
            {
                Console.WriteLine("Toplam Girilen Sözcük Sayısı: " + liste.Count + "\n");
                Console.WriteLine("Farklı Sözcük Adedi: " + hashSet.Count + "\n");
                tablo.Yazdir();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
