using System;

namespace RuangBangun
{
    class BangunRuang
    {
        public void volume_balok()
        {
            int panjang,lebar,tinggi,volume;

            Console.WriteLine("Panjang balok= ");
            panjang=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lebar balok= ");
            lebar=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tinggi balok= ");
            tinggi=Convert.ToInt32(Console.ReadLine());

            volume=panjang*lebar*tinggi;
            Console.WriteLine("Total volume balok adalah "+volume+"\n");
        }



        
        public void volume_kubus()
        {
            int sisi,volume;

            Console.WriteLine("Sisi kubus= ");
            sisi=Convert.ToInt32(Console.ReadLine());

            volume=sisi*sisi*sisi;
            Console.WriteLine("Hasil volume kubus adalah "+volume+"\n");
        }
    }
}