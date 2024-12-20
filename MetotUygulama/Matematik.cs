using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotUygulama
{
    public class Matematik
    {
        // Topla

        public decimal toplamaIslemi(decimal sayi1,  decimal sayi2)
        {
            decimal sonuc = sayi1 + sayi2;
            return sonuc;
        }

        // Cıkarma

        public decimal cikarmaIslemi(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 - sayi2;
            return sonuc;
        }

        // Bolme 
        public decimal bolmeIslemi(decimal sayi1 ,decimal sayi2)
        {
            decimal sonuc = sayi1 / sayi2;
            return sonuc;
        }

        // Carpma 

        public decimal carpmaIslemi(decimal sayi1 ,  decimal sayi2)
        {
            decimal sonuc = sayi1 * sayi2;
            return sonuc;
        }

        public void menuHazirla()
        {
            Console.Clear();
            Console.WriteLine("************ Menu ***************");
            Console.WriteLine("1- Toplama");
            Console.WriteLine("2- Çıkarma");
            Console.WriteLine("3- Çarpma");
            Console.WriteLine("4-Bölme");
            Console.Write("Seçiniz : ");

        }

        public void EkranaYazdir(decimal sayi1, decimal sayi2, decimal sonuc, string operators)
        {
            Console.WriteLine("{0} {1} {2} = {3}", sayi1, operators, sayi2, sonuc);
        }
    }
}
