using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MCD_InterfacePractice
{
    public class KrediKartiOdeme : Odeme, IOdeme
    {
        public string KartSahibiAd { get; set; }
        public string KartSahibiSoyad { get; set; }
        public byte SonKullanimAy { get; set; }
        public int SonKullanimYili { get; set; }
        public short CVV { get; set; }
        private string _KartNumarasi;

        public string KartNumarasi
        {
            get
            {
                return _KartNumarasi;
            }
            set
            {
                char[] dizi = value.ToCharArray();
                bool rakamDeğilMi = false;
                foreach (var item in dizi)
                {
                    if (!char.IsDigit(item)) //digit olmayan varsa 
                    {
                        rakamDeğilMi = true; //hemen yakala
                        break; //çık.
                    }

                }//döngü bitti.

                if (!rakamDeğilMi&&value.Length==16)
                {
                    _KartNumarasi = value;
                }
                else
                {
                    throw new FormatException("Geçerli bir kart numarası giriniz.");
                }
            }
        }



        public void OdemeSekliAyariYap()
        {
            Console.WriteLine("Kredi Kartıyla Ödeme --> 1");
        }

        public void OdemeYap()
        {
            Console.WriteLine("Kart sahibinin adı: ");
            KartSahibiAd = Console.ReadLine();
            Console.WriteLine("Kart sahibinin soyadı: ");
            KartSahibiSoyad = Console.ReadLine();
            Console.WriteLine("16 haneli kart numarasını giriniz: ");
            KartNumarasi = Console.ReadLine();
            Console.WriteLine("Kartınızın son kullanma ay bilgisini 1-12 arasında sayı olarak giriniz: ");
            SonKullanimAy =Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Kartınızın son kullanım yılı bilgisini 20XX formatında giriniz: ");
            SonKullanimYili = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kartın üzerindeki CVV numarasını giriniz: ");
            CVV = Convert.ToInt16(Console.ReadLine());

            //kart numarası boş olmamalı ve diğer özellikler de boş olmamalı.
            //encapsulation yap.
            //bu if'in içindeki koşulları encapsulatıon ile gerçekleştiriniz.
            //biz çok vakit harcamamak için if ile yazıp geçmek istedik.

            if (KartSahibiAd.Length>0&&KartSahibiSoyad.Length>0&&SonKullanimAy>0&&SonKullanimAy<13&& SonKullanimYili >= DateTime.Now.Year)
            {
                Console.Clear();
                Console.WriteLine($"Sayın {KartSahibiAd} {KartSahibiSoyad} {OdenecekTutar} lira ödeniyor..." +
                    $"Lütfen bekleyiniz.");
                Random rnd = new Random();
                int bekleme = rnd.Next(3000, 5000);
                Thread.Sleep(bekleme);
                Console.WriteLine("Ödeme alındı.");
            }

        }
    }
}
