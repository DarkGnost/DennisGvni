using System;

namespace DatarBangun
{
    class BangunDatar
    {
        public string hidup()
        {
            return "Hai Dennis";
        }





        public void luas_segitiga()
        {
            int alas,tinggi;
            double luas;
            double phi;
            phi=3.14;
            
            Console.WriteLine("Alas segitiga= ");
            alas=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tinggi segitiga= ");
            tinggi=Convert.ToInt32(Console.ReadLine());

            luas=phi*alas*tinggi;
            Console.WriteLine("Hasil luas segitiga ini adalah "+luas+"\n");
        }




        public void luas_persegi()
        {
            int sisi,luas;

            Console.WriteLine("Sisi persegi= ");
            sisi=Convert.ToInt32(Console.ReadLine());

            luas=sisi*sisi;
            Console.WriteLine("Hasil luas segitiga adalah "+luas+"\n");
        }




        
        public void luas_lingkaran()
        {
            int r;
            double luas;
            double phi;
            phi=3.14;

            Console.WriteLine("Jari-jari lingkaran= ");
            r=Convert.ToInt32(Console.ReadLine());

            luas=phi*r*r;
            Console.WriteLine("Hasil luas lingkaran adalah "+luas+"\n");
        }
    }
}