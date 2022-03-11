using System;
using System.Collections.Generic;
using System.Text;

namespace Odev_2
{
    class MyList : List<string>
    {
        public void ParcalaEkle(string metin)
        {
            char[] ayraclar = new char[]
            {
            ' ',
            ',',
            ';',
            '.',
            '\t',
            '\r',
            '\n',
            '\'',
            '"',
            ':',
            '-',
            '!',
            '?',
            ')',
            '('
            };

            this.AddRange(metin.Split(ayraclar, StringSplitOptions.RemoveEmptyEntries)); // kelimeleri ayırıp listemize ekliyoruz.
        }

    }
}
