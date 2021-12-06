using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_InterfacePractice
{
    public class KapidaOdeme : Odeme, IOdeme
    {

        public string MusteriAd { get; set; }
        public string MusteriSoyad { get; set; }
        public string TcNo { get; set; }
        public string Adres { get; set; }
        public string KuryeBilgisi { get; set; }



        public void OdemeSekliAyariYap()
        {
            Console.WriteLine("Kapıda Ödeme --> 2");
        }

        public void OdemeYap()
        {
            Console.WriteLine("Teslimatı yapan kurye ad soyad: ");
            KuryeBilgisi = Console.ReadLine();
            Console.WriteLine("Hasarsız mı?");
            if (Console.ReadKey().Key==ConsoleKey.E)
            {
                Console.WriteLine("Teslimat başarılı...");
            }
            else
            {
                Console.WriteLine("Teslimat başarısız...");
            }
            
            
        }
    }
}
