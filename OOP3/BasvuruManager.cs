using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
     class BasvuruManager
    {
        public void BasvuruYap(IKrediManager a, ILoggerService b)
        {
            
            a.Hesapla();
            b.Log();

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)

        {
            foreach (var kredi in krediler)

            {
                kredi.Hesapla();
            }
        }
    }
}
