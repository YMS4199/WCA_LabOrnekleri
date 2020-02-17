using System;

namespace WCA_LabOrnekleri
{
    class Program
    {
        // NOT : Consol üzerine yazılan datayı  içeriye almayı araştırınız :)
        static void Main(string[] args)
        {
            // Dışarıdan nasıl data alıcaz diye düşünüyosanız, üstteki not'u okuyunuz :)


            #region Örnek 1
            //1) Disaridan alinan iki sayının toplamiyla farkinin birbirine bolumunden kalanin sonucu kactir? (Farkın toplama bolumunden kalan kactir?)

            /*
            Console.WriteLine("Lütfen birinci sayıyı giriniz!");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen ikinci sayıyı giriniz!");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int toplam = sayi1 + sayi2;
            int fark = sayi1 - sayi2;

            int sonuc = fark % toplam;
            Console.WriteLine("İşlem Sonucu : " + sonuc);
            Console.WriteLine("İşlem Sonucu : {0}" , sonuc);
            */
            #endregion

            #region Örnek 2
            //2) Disaridan girilen bir sayının 10 eksiginin 20 fazlasinin 2ye bolumunden kalaninin karesi kactir?

            /*
            int sayi = Convert.ToInt32(Console.ReadLine());
            int result = sayi - 10;
            result = result + 20;
            result = result % 2;
            result = result * result; 
            Console.WriteLine("İşlem Sonucu : " + result);


            int sonuc = ((sayi - 10) + 20) % 2;
            Console.WriteLine("İşlem Sonucu : {0}", (sonuc * sonuc));
            */
            #endregion

            #region Örnek 3
            //3) Vize notu'nun % 30'u, final notu'nun % 70'ini alıp öğrencinin not ortalamasini cikartan bir uygulama yaziniz... DİKKAT => Notlar ondalikli olabilir?


            /*
            Console.WriteLine("Lütfen Vize Notunuzu Giriniz : ");
            double vize = double.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen Final Notunuzu Giriniz : ");
            double final = double.Parse(Console.ReadLine());

            double sonuc = (vize * 0.30) + (final * 0.70);

            string result = string.Format("Not Ortalamanız : {0}", sonuc);
            Console.WriteLine(result);
            */
            #endregion

            #region Örnek 4
            //4) Dışarıdan kullanıcı adını ve soyadını ayrı ayrı olarak alnız ve  adi.soyadi@hotmail.com şeklinde mail adresi oluşturup kullanıcıya gösteriniz

            // ToLower() => hepsini küçük harfe çevir

            /*
            Console.WriteLine("Lütfen Adınızı Giriniz : ");
            string isim = Console.ReadLine().ToLower();

            Console.WriteLine("Lütfen Soyadınızı Giriniz : ");
            string soyisim = Console.ReadLine().ToLower();

            string mail = string.Format("{0}.{1}@hotmail.com", isim, soyisim);
            Console.WriteLine(mail);
            */
            #endregion
             
            #region Örnek 5
            //5) Disaridan girilen iki sayının karelerinin toplami ile karelerinin farki toplami kactir? 
            /*
            Console.WriteLine("Lütfen birinci sayıyı giriniz : ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen ikinci sayıyı giriniz : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int k1 = sayi1 * sayi1;
            int k2 = sayi2 * sayi2;

            int toplam = k1 + k2;
            int fark = k1 - k2;

            Console.WriteLine("İşlem sonucu : {0}", (toplam + fark));
            */ 
            #endregion
        }
    }
}
