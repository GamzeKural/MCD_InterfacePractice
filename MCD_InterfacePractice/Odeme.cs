using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_InterfacePractice
{
    public class Odeme
    {
        public decimal OdenecekTutar { get; set; }

        

        public void OdemeTutariniKullanicidanAl()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Lütfen ödeme tutarını giriniz.");
            OdenecekTutar = Convert.ToDecimal(Console.ReadLine());
        }

    }
}
