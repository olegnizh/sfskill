using System;
using System.Collections.Generic;
using System.Text;
using NLog;

namespace ConsoleAppNlog
{
    class Car
    {
        // create a static logger field
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public string Model { get; set; }
        public int YearReleased { get; set; }
        public Person Owner { get; set; }

        public Car(string model, int yearReleased, Person owner)
        {
            Model = model;
            YearReleased = yearReleased;
            Owner = owner;

            logger.Debug("Created a car {@person} at {now}", this, DateTime.Now);
        }

    }

}
