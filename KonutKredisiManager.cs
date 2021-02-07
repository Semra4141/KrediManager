using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKredisiManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
        }
        public void CiktiAl()
        {
            Console.WriteLine("Konut kredisi çıktısı alındı");      
        }
    }
}
