using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager x = new IhtıyacKrediManager();
            IKrediManager c = new TasıtKrediManager();
            IKrediManager o = new KonutKrediManager();
            IKrediManager w = new EsnafKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            BasvuruManager a = new BasvuruManager();
            a.BasvuruYap(w,smsLoggerService);


            List<IKrediManager> krediler = new List<IKrediManager>() { x,c,o};

            //a.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}