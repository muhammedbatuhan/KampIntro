using System;

namespace OOP2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Muhammed Batuhan Gültekin            
            Individual musteri1 = new Individual();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Muhammed Batuhan";
            musteri1.SoyAdi = "Gültekin";
            musteri1.TcNo = "12345678910";


            
            

            //Gerçek Müşteri - Tüzel Müşteri


            Coorporate musteri2 = new Coorporate();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            /////////////////////////////////////
            
            Customer musteri3 = new Individual();
            Customer musteri4 = new Coorporate();


            CustomerManeger customerManager = new CustomerManeger();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);




        }
    }
}
