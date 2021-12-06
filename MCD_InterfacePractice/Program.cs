using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_InterfacePractice
{
    class Program
    {
        static void Main(string[] args)
        {

            KrediKartiOdeme krediKartiIleOde = new KrediKartiOdeme();
            KapidaOdeme kapidaOde = new KapidaOdeme();
            FastPayOdeme fastPayOde = new FastPayOdeme();

            List<KeyValuePair<byte, IOdeme>> OdemeTuruListesi = new List<KeyValuePair<byte, IOdeme>>()
            {
                new KeyValuePair<byte, IOdeme>(1,krediKartiIleOde),
                new KeyValuePair<byte, IOdeme>(2,kapidaOde),
                new KeyValuePair<byte, IOdeme>(3,fastPayOde)
            };

            //OdemeTuruListesi.Add(new KeyValuePair<byte, IOdeme>)

            foreach (var item in OdemeTuruListesi)
            {
                item.Value.OdemeSekliAyariYap();
            }

            int secim = Convert.ToInt32(Console.ReadLine());
            OdemeTuruListesi[secim - 1].Value.OdemeYap();
            //switch (secim)
            //{
            //    case 1:
            //        krediKartiIleOde.OdemeTutariniKullanicidanAl();
            //        krediKartiIleOde.OdemeYap();
            //        break;
            //    case 2:
            //        kapidaOde.OdemeTutariniKullanicidanAl();
            //        kapidaOde.OdemeYap();
            //        break;
            //    case 3:
            //        fastPayOde.OdemeTutariniKullanicidanAl();
            //        fastPayOde.OdemeYap();
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı seçim");
            //        break;
            //}

            Console.ReadKey();
        }
    }
}
