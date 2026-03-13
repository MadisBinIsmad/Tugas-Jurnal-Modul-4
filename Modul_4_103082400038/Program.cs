using Modul_4_103082400038;
using System;

namespace modul3_103082400038
{
    class Program
    {
        static void Main(string[] args)
        {
            KodeBuah kode = new KodeBuah();

            Console.WriteLine("Kode Buah Apel: " + kode.getKodeBuah(KodeBuah.NamaBuah.Apel));
            Console.WriteLine("Kode Buah Durian: " + kode.getKodeBuah(KodeBuah.NamaBuah.Durian));
            Console.WriteLine("Kode Buah Semangka: " + kode.getKodeBuah(KodeBuah.NamaBuah.Semangka));

            Console.WriteLine("\n===== Posisi Karakter Game =====\n");

            PosisiKarakterGame karakter = new PosisiKarakterGame();

            while (true)
            {
                Console.WriteLine("\nState saat ini: " + karakter.currentState);
                Console.WriteLine("Tekan tombol:");
                Console.WriteLine("W = TombolW");
                Console.WriteLine("S = TombolS");
                Console.WriteLine("X = TombolX");
                Console.WriteLine("Q = Keluar");

                Console.Write("Input: ");
                string input = Console.ReadLine().ToUpper();

                if (input == "Q")
                {
                    break;
                }

                switch (input)
                {
                    case "W":
                        karakter.ActivateTrigger(PosisiKarakterGame.Trigger.TombolW);
                        break;

                    case "S":
                        karakter.ActivateTrigger(PosisiKarakterGame.Trigger.TombolS);
                        break;

                    case "X":
                        karakter.ActivateTrigger(PosisiKarakterGame.Trigger.TombolX);
                        break;

                    default:
                        Console.WriteLine("Input tidak valid");
                        break;
                }
            }
        }
    }
}