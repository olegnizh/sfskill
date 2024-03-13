using System;
using NLog;


namespace ConsoleAppNlog
{
    class Program
    {

        // create a static logger field
        // Singelton
        private static Logger logger = LogManager.GetCurrentClassLogger();
       

        static void Main(string[] args)
        {

            
            // create 2 persons
            var person1 = new Person("Jonh", "Gold");
            var person2 = new Person("James", "Miller");
            // create 2 cars
            var car1 = new Car("Tesla Model S", 2020, person1);
            var car2 = new Car("Tesla Model X", 2020, person2);
            // logging
            logger.Trace("Some verbose log");
            logger.Debug("Some debug log");
            logger.Info("Person1: {@person}", person1);
            logger.Info("Car2: {@car}", car2);
            logger.Warn("Warning accrued at {now}", DateTime.Now);
            logger.Error("Error accrued at {now}", DateTime.Now);
            logger.Fatal("Serious problem with car {@car} accrued at {now}", car1, DateTime.Now);
            

            /*
            Logger log = LogManager.GetCurrentClassLogger();

            log.Debug("This is a debug message");
            log.Error(new Exception(), "This is an error message");
            log.Fatal("This is a fatal message");

            Console.ReadKey();
            */


        }


    }

}
