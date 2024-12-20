using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matematik matematik = new Matematik();
            yenidenIslemYap:

            matematik.menuHazirla();


           int kullaniciSayi = int.Parse(Console.ReadLine());


            Console.WriteLine("Lütfen Birinci Sayiyi Giriniz");
            decimal kullaniciSayi1  = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen İkinici Sayiyi Giriniz");
            decimal kullaniciSayi2 = decimal.Parse(Console.ReadLine());

            decimal sonuc = 0;

            switch(kullaniciSayi)
            {
                case 1:
                    sonuc = matematik.toplamaIslemi(kullaniciSayi1, kullaniciSayi2);
                    matematik.EkranaYazdir(kullaniciSayi, kullaniciSayi2, sonuc, "+");
                    break;
                case 2:
                    sonuc = matematik.cikarmaIslemi(kullaniciSayi1, kullaniciSayi2);
                    matematik.EkranaYazdir(kullaniciSayi1, kullaniciSayi2, sonuc, "-");
                    break;
                case 3:
                    sonuc = matematik.bolmeIslemi(kullaniciSayi1, kullaniciSayi2);
                    matematik.EkranaYazdir(kullaniciSayi1, kullaniciSayi2, sonuc, "/");
                    break;
                case 4:
                    sonuc = matematik.carpmaIslemi(kullaniciSayi1, kullaniciSayi2);
                    matematik.EkranaYazdir(kullaniciSayi1, kullaniciSayi2, sonuc, "*");
                    break;
                default:
                    Console.WriteLine("Belirtmiş oldugunuz deger liste içerisinde bulunamadı");
                    Console.WriteLine("Lütfen Yeniden Deneyiniz");
                    System.Threading.Thread.Sleep(2000);
                    goto yenidenIslemYap;
            }

            Console.WriteLine("Yeni işelm yapmak istiyor musunuz?");
            string EH = Console.ReadLine();

            if(EH.ToUpper() =="E")
            {
                goto yenidenIslemYap;
            }
        }
    }
}
