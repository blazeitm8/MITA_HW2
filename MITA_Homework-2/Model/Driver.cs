using System;

namespace Model
{
    public class Driver
    {
        private DateTime _experience;

        public DateTime LicenseDate { get;  }

        public string Name { get; }

        public TimeSpan Experience
        {
            get
            {
                TimeSpan _experinece = DateTime.Now - LicenseDate;
                return new TimeSpan(_experinece.Days);
            }
            
        }

        public string Category { get; set; }

        public Car Car { get; private set; }

        public Driver (DateTime licensedate, string name)
        {
            LicenseDate = licensedate;

            Name = name;
        }

        

        public void OwnCar(Car car)
        {
            if (Category.Contains(car.Category))
            {
                Car = car;
            }
            else
            {
                throw new Exception("Нет категории!");
            }
        }
    }
}
