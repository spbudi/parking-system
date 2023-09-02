// See https://aka.ms/new-console-template for more information
using System;


class Program
{
    static void Main(string[] args)
    {
        SistemParkir.SistemParkir sistemParkir = new SistemParkir.SistemParkir(10, 15);

        while (true)
        {
            Console.WriteLine("Pilih aksi:");
            Console.WriteLine("1. Parkir Mobil");
            Console.WriteLine("2. Parkir Motor");
            Console.WriteLine("3. Tampilkan Info Lot");
            Console.WriteLine("4. Keluar");

            int pilihan;
            if (int.TryParse(Console.ReadLine(), out pilihan))
            {
                switch (pilihan)
                {
                    case 1:
                        Console.Write("Nama Pemilik Mobil: ");
                        string pemilikMobil = Console.ReadLine();
                        sistemParkir.ParkirMobil(pemilikMobil);
                        break;

                    case 2:
                        Console.Write("Nama Pemilik Motor: ");
                        string pemilikMotor = Console.ReadLine();
                        sistemParkir.ParkirMotor(pemilikMotor);
                        break;

                    case 3:
                        sistemParkir.TampilInfoLots();
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Pilihan tidak valid.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Masukan tidak valid.");
            }
        }
    }
}
