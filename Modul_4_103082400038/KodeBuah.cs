using System;
using System.Collections.Generic;
using System.Text;

namespace Modul_4_103082400038
{
    class KodeBuah
    {
        public enum NamaBuah
        {
            Apel,
            Aprikot,
            Alpukat,
            Pisang,
            Paprika,
            Kurma,
            Durian,
            Anggur,
            Melon,
            Semangka
        }

        private string[] kodeBuah =
        {
            "A00",
            "B00",
            "C00",
            "D00",
            "E00",
            "K00",
            "L00",
            "M00",
            "N00",
            "O00"
        };

        public string getKodeBuah(NamaBuah buah)
        {
            return kodeBuah[(int)buah];
        }
    }
}
