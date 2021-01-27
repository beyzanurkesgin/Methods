using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        { 
        
        IKrediManager ihtiyacKrediManager= new İhtiyacKrediManager();
       
        IKrediManager tasitKrediManager = new TasitKrediManager();
         
        IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, databaseLoggerService);
           // basvuruManager.BasvuruYap(ihtiyacKrediManager);


            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,tasitKrediManager};

           /// basvuruManager.KrediOnBilgilendiremesiYap(krediler);





        }
    }

}
