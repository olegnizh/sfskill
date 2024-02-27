namespace GroupByExample.Models
{
    public class Car
    {
        public string Manufacturer { get; set; }
        public string CountryCode { get; set; }
 
        public Car(string manufacturer, string countryCode)
        {
            Manufacturer = manufacturer;
            CountryCode = countryCode;
        }
    }
}