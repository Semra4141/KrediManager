using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BireyselKrediManager : IKrediManager
    {
        public void CiktiAl()
        {
            Console.WriteLine("Bireysel kredi çıktısı alındı");        }

        public void Hesapla()
        {
            Console.WriteLine("bireysel kredi ödeme planı hazırlandı");        }
    }
}
