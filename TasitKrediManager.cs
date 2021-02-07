using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TasitKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı");
        }
        public void CiktiAl()
        {
            Console.WriteLine("Taşıt kredisi çıktısı alındı");        }
    }
}
