using System;
using DatarBangun;
using RuangBangun;

namespace Perograman
{
    class Program
    {
        static void Main(string[]args)
        {
            BangunDatar kelases=new BangunDatar();

            Console.WriteLine("Kelas saya ialah X TKJ 1, "+kelases.hidup()+"\n");

            kelases.luas_segitiga();
            kelases.luas_persegi();
            kelases.luas_lingkaran();

            BangunRuang kelasesbaru=new BangunRuang();

            kelasesbaru.volume_balok();
            kelasesbaru.volume_kubus();









        }
    }

}