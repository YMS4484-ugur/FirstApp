using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritmetikİslemler
{
    class Program
    {
        static void Main(string[] args)
        {
            //-1-dışarıdan alınan iki sayının toplamıyla farkının birbirine bolumunden kalanın sonucu kaçtır?(farkın toplama bölümünden kaçtır?)
            #region Ornek 1
            /*
               Console.WriteLine("Lütfen 1. sayıyı giriniz");
               int s1 = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Lütfen 2. sayıyı giriniz");
               int s2 = Convert.ToInt32(Console.ReadLine());

               int toplam = s1 + s2;
               int fark = s1 - s2;
               int bolum = s1 / s2;
               int result = toplam % fark;

               Console.WriteLine("işlem sonucu:" + result);
               //Console.WriteLine("Toplama işleminin sonucu:" + toplam);
               //Console.WriteLine("fark işleminin sonucu:" + fark);
               //Console.WriteLine("bolme işleminin sonucu:" + bolum);
               */
            #endregion
            //2) dışarıdan girilen bir sayının 10 eksiğinin 20 fazlasının 2 ye bölümünden kalanının karesi kaçtır?
            //1
            #region Ornek 2
            //Console.WriteLine("Sayı girin:");

            //int sayi = int.Parse(Console.ReadLine());
            ////2
            //sayi = sayi - 10;

            ////3
            //sayi = sayi + 20;

            ////4
            //sayi = sayi % 2;

            //Console.WriteLine("işlem sonucu:{0}", sayi * sayi);

            //Console.WriteLine("Sayı girin:");

            //sayi = int.Parse(Console.ReadLine());
            //sayi = (sayi - 10 + 20) % 2;


            //Console.WriteLine("işlem sonucu : {0}", sayi * sayi);
            //Console.Read(); 
            #endregion

            //Dışarıdan girilen iki sayının karelerinin toplamı ile karelerinin farkı toplamı kaçtır.

            #region ornek 3
            /*Console.WriteLine("Lütfen 1. sayıyı giriniz");
            int s1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen 2. sayıyı giriniz");
            int s2 = int.Parse(Console.ReadLine());
            //1
            int k1 = s1 * s2;
            int k2 = s1 * s2;

            int toplam = k1 + k2;
            int fark = k1 - k2;

            int result = toplam + fark;

            Console.WriteLine("işlem sonucu:{0}", result);
            */
            #endregion

            //vize notunun %30'u final notunun %70 inin alıp öğrencisnin not ortalamasının çıkartan bir uygulama yazınız ...Dikkat notlar ondalıklı olabilir?
            #region Ornek 3

            /*Console.WriteLine("Lütfen 1. vize notu giriniz");
            double vize = double.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen 2. final notu giriniz");
            double final = double.Parse(Console.ReadLine());

            double not = (vize * 0.30) + (final + 0.70);
            Console.WriteLine("Not ortalamasınız:{0}", not);
            */



            #endregion

            /*Dışarıdan kullanıcı adını ve soyadını ayrı ayrı olarak alnız ve adı.soyadı@hotmail.com şeklinde 
            adresi oluşturup kullanıcıya gösteriniz.*/


            #region Ornek 4
            /*Console.WriteLine("Adınızı giriniz");
            string ad = Console.ReadLine();
            Console.WriteLine("soyadınızı giriniz");
            string soyad = Console.ReadLine();

            Console.WriteLine("Mail adresiniz:{0}.{1}@hotmail.com", ad, soyad);
            */

            #endregion




            Console.Read();





        }
    }
}
