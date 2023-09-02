namespace SistemParkir;
using System;
using System.Collections.Generic;

public class SistemParkir
{
    private int totalLotMobil;
    private int totalLotMotor;
    private Dictionary<string, int> pemilikLots;
    
    public SistemParkir(int totalLotMobil, int totalLotMotor)
    {
        this.totalLotMobil = totalLotMobil;
        this.totalLotMotor = totalLotMotor;
        pemilikLots = new Dictionary<string, int>();
    }
    public bool ParkirMobil(string pemilik)
    {
        if (totalLotMobil > 0 && !pemilikLots.ContainsKey(pemilik))
        {
            pemilikLots[pemilik] = 1;
            totalLotMobil--;
            Console.WriteLine($"{pemilik} telah memarkirkan mobil.");
            return true;
        }
        else
        {
            Console.WriteLine("Tidak ada lot mobil tersedia atau Anda sudah memiliki lot.");
            return false;
        }
    }
    
    public bool ParkirMotor(string pemilik)
    {
        if (totalLotMotor > 0 && !pemilikLots.ContainsKey(pemilik))
        {
            pemilikLots[pemilik] = 1;
            totalLotMotor--;
            Console.WriteLine($"{pemilik} telah memarkirkan motor.");
            return true;
        }
        else
        {
            Console.WriteLine("Tidak ada lot motor tersedia atau Anda sudah memiliki lot.");
            return false;
        }
    }
    public void TampilInfoLots()
    {
        Console.WriteLine($"Jumlah Lot Mobil Tersedia: {totalLotMobil}");
        Console.WriteLine($"Jumlah Lot Motor Tersedia: {totalLotMotor}");
    }

}