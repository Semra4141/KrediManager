using System;
using System.Collections.Generic;

namespace OOP3
{
    // interfaceleri birbirinin alternefi olan ama kod içerikleri farklı olan durumlar için kullanırız.
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();   //1
            IKrediManager ihtiyacKrediManagerr = new IhtiyacKrediManager();        //2     // 1. ve 2. satırda aynı görevi görüyor.
            KonutKredisiManager konutKredisiManager = new KonutKredisiManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            BireyselKrediManager bireyselKrediManager = new BireyselKrediManager();


            BasvuruManager basvuruManager = new BasvuruManager();

            basvuruManager.BasvuruYap(bireyselKrediManager);
            basvuruManager.BasvuruYap(ihtiyacKrediManagerr);
            basvuruManager.BasvuruYap(konutKredisiManager);
            basvuruManager.BasvuruYap(tasitKrediManager);

            Console.WriteLine("-----------------------------------");

            List<IKrediManager> krediler = new List<IKrediManager>() 
            { ihtiyacKrediManagerr,bireyselKrediManager, konutKredisiManager,tasitKrediManager };

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}
