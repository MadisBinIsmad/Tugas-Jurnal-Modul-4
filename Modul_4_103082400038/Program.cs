using Modul_4_103082400038;
using System;

namespace modul3_103082400038
{
    class Program
    {
        static void Main(string[] args)
        {
            // tabe;
            KodeBuah kode = new KodeBuah();

            Console.WriteLine("Kode Buah Apel: " + kode.getKodeBuah(KodeBuah.NamaBuah.Apel));
            Console.WriteLine("Kode Buah Durian: " + kode.getKodeBuah(KodeBuah.NamaBuah.Durian));
            Console.WriteLine("Kode Buah Semangka: " + kode.getKodeBuah(KodeBuah.NamaBuah.Semangka));

            Console.WriteLine("\n Posisi Karakter Game \n");

            PosisiKarakterGame karakter = new PosisiKarakterGame();

            karakter.ActivateTrigger(PosisiKarakterGame.Trigger.TombolW);
            karakter.ActivateTrigger(PosisiKarakterGame.Trigger.TombolX);
            karakter.ActivateTrigger(PosisiKarakterGame.Trigger.TombolW);
            karakter.ActivateTrigger(PosisiKarakterGame.Trigger.TombolS);
            karakter.ActivateTrigger(PosisiKarakterGame.Trigger.TombolS);
            karakter.ActivateTrigger(PosisiKarakterGame.Trigger.TombolW);
        }
    }
}