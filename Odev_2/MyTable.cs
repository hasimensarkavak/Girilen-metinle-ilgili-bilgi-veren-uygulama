using System;
using System.Collections.Generic;
using System.Text;

namespace Odev_2
{
    class MyTable : Dictionary<string,int>
    {
        private List<string> kelimeler;
        public MyTable(List<string> kelimeler) //kelime listemizi tablomuza constructor ile alıyoruz.
        {
            this.kelimeler = kelimeler;
        }

        public void KelimeSay() // Dictionary den kalıtım aldığımız için this ile ekliyoruz.
        {
            foreach (var kelime in kelimeler)
            {
                if (this.ContainsKey(kelime))
                {
                    int value = this[kelime];
                    this[kelime] = value + 1;
                }
                else
                {
                    this.Add(kelime, 1);  
                }
            }
        }

        public void Yazdir() 
        {
            string enCokTekrarlananKelime = "";
            int tekrarSayisi = 0;

            Console.WriteLine("Sözcük Frekansları: \n");

            foreach (KeyValuePair<string, int> kelime in this)
            {
                Console.WriteLine("  {0} : {1}",kelime.Key,kelime.Value);
                if (kelime.Value>tekrarSayisi)
                {
                    tekrarSayisi = kelime.Value;
                    enCokTekrarlananKelime = kelime.Key;
                }
            }

            Console.WriteLine("\nEn Sık Tekrarlanan Kelime: \"{0}\" ",enCokTekrarlananKelime);
            Console.WriteLine("En Sık Tekrarlanan Kelimenin Frekansı: {0}" , tekrarSayisi);
            Console.WriteLine("===========================================================");
        }
    }
}
