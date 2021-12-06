using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MCD_InterfacePractice
{
    public class FastPayOdeme : Odeme, IOdeme
    {
        public string EPosta { get; set; }
        public string Sifre { get; set; }

        public void OdemeSekliAyariYap()
        {
            Console.WriteLine("FastPay --> 3");
        }

        public void OdemeYap()
        {
            Console.WriteLine("Eposta adresi giriniz.");
            EPosta = Console.ReadLine();
            Console.WriteLine("Şifre giriniz.");
            Sifre = Console.ReadLine();

            Random rnd = new Random();
            int bekleme = rnd.Next(3, 5);
            Console.WriteLine(bekleme);
            for (int i = 0; i < bekleme; i++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(i + "...");
                Thread.Sleep(bekleme*1000);
            }
            Console.WriteLine("Ödeme alındı... İyi günler...");

            
        }
    }
}
