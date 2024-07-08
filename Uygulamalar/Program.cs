using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Uygulamalar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Kullanıcı Adı şifr ile giriş

            //kullanıcı adı = Admin
            //şifra = 1234
            //ise hoşgeldiniz değilse kullanıcı adı veya şifre hatalı uyarısı verilecek

            //Console.WriteLine("Kullanıcı adınızı giriniz: ");
            //string kullaniciAdi = Console.ReadLine();
            //Console.WriteLine("Şifrenizi giriniz:");
            //string sifre = Console.ReadLine();

            //if (sifre == "1234" && kullaniciAdi == "admin")
            //{
            //    Console.WriteLine("Hoşgeldiniz");
            //}
            //else
            //{
            //    Console.WriteLine("Kullanıcı adı veya şifre hatalı");
            //}


            #endregion

            #region Kayıtlı Kullanıcı Adı ve Şifre İle giriş

            //string[] kullaniciAdlari = { "alp", "samet", "mevlüt" };
            //string[] sifreler = { "1234", "1235", "1236" };

            //Console.Write("Kullanıcı adınızı giriniz: ");
            //string kullaniciAdi = Console.ReadLine();
            //Console.Write("Sifrenizi giriniz");
            //string sifre = Console.ReadLine();

            //int index = -1;
            //for (int i = 0; i < kullaniciAdlari.Length; i++)
            //{
            //    if (kullaniciAdlari[i] == kullaniciAdi)
            //    {
            //        index = i; break;
            //    }
            //}
            //if (index == -1)
            //{
            //    Console.WriteLine("Kullanıcı Bulunamadı Lütfen bilgileri kontrol ediniz");
            //}
            //else
            //{
            //    if (sifreler[index] == sifre)
            //    {
            //        Console.WriteLine("Hoşgeldiniz");
            //    }
            //    else
            //    {
            //        {
            //            Console.WriteLine("Şifre Hatalı");
            //        }
            //    }
            //}

            #endregion

            #region RFID ile giriş işlemi

            //string[] kullaniciAdlari = { "Alp", "Samet", "Mevlüt", "Batuhan" };
            //string[] kartnolar = { "0490753442", "3758322375", "3122814980", "2971462090" };


            //while (true)
            //{
            //    Console.WriteLine("LÜTFEN KARTINIZI OKUTUNUZ");
            //    string kartNo = Console.ReadLine();
            //    int index = -1;
            //    for (int i = 0; i < kullaniciAdlari.Length; i++)
            //    {
            //        if (kartnolar[i] == kartNo)
            //        {
            //            index = i; break;
            //        }
            //    }
            //    if (index == -1)
            //    {
            //        Console.WriteLine("Kullanıcı Bulunamadı Lütfen bilgileri kontrol ediniz");
            //    }
            //    else
            //    {
            //        if (kartnolar[index] == kartNo)
            //        {
            //            Console.WriteLine("Hoşgeldiniz");
            //        }
            //        else
            //        {
            //            {
            //                Console.WriteLine("Şifre Hatalı");
            //            }
            //        }
            //    }
            //}
            #endregion


            #region Bem Market

            string[] kullaniciAdlari = { "Alp", "Samet", "Mevlüt", "Batuhan" };
            string[] kartnolar = { "0490753442", "3758322375", "3122814980", "2971462090" };


            string[] urunler = { "Domates", "Karpuz", "Ekmek", "Yumurta", "Ayran", "Sosis", "Salam" };
            double[] fiyatlar = { 48, 12.5, 12, 4.15, 32, 65, 122.9 };
            string[] birimler = { "KG", "KG", "Adet", "Adet", "LT", "Paket", "Adet" };
            

            #region Indırım Kart İşlemi
            Console.WriteLine("İndirimlerden faydalanmak için Bem Kartınızı Okutunuz. Kartsız devam etmek istiyorsanız 'Enter' tuşuna basınız");
            string kartno = Console.ReadLine();

            int index = -1;
            for (int i = 0; i < kartnolar.Length; i++)
            {
                if (kartnolar[i] == kartno)
                {
                    index = i;
                    break;
                }
            }
            #endregion

            #region Mesaj
            string mesaj = "";
            if (index != -1)
            {
                mesaj = "Merhaba" + kullaniciAdlari[index] + " ";
            }
            mesaj += "Bem Markete Hoşgeldiniz";
            Console.WriteLine(mesaj);

            #endregion

            #region Menü yazdırma
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine((i+1) + ") " + urunler[i] + "\t"+birimler[i] + " \t" + fiyatlar[i]+ " TL");
            }


            #endregion

            #region Ürün satın alma
            
            string devammi = "e";
            double toplam = 0;
            while (devammi == "e")
            {

                Console.WriteLine("Almak istediğiniz ürün numarasını giriniz ");
                int urunno = Convert.ToInt32(Console.ReadLine());

                int urunindex = urunno - 1;

                Console.WriteLine("Kaç "+ birimler[urunindex] + urunler[urunindex]+ " aklacaksınız?");
                int adet = Convert.ToInt32((Console.ReadLine()));

                double urunfiyat = fiyatlar[urunindex];

                toplam += (urunfiyat * adet);

                Console.WriteLine("Alışverişe devam edilsinzmi ? e/h");
                devammi = Console.ReadLine();
            }

            #endregion

            #region Satış sonlandırma

            if (index != -1)
            {
                double indirim = toplam * 0.1;
                Console.WriteLine("Bem Kart sahibi olduğunuz  için " + indirim + " TL indirim kazandınız");
                Console.WriteLine("Toplam = " +(toplam- indirim));

            }
            else
            {
                Console.WriteLine("Toplam = "+ toplam);
            }
            #endregion

            #endregion

            
        }
    }
}
