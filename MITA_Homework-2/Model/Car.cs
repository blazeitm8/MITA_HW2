using System.Drawing;

namespace Model
{
    public class Car
    {
       public string Model { get; }

        public Color Color { get; set; } = Color.Blue;

        public string CarNumber { get; private set; }

        public string Category { get; }

        public CarPassport CarPassport { get; }

        public Car(string model, string category)
        {
            Model = model;
            Category = category;
            CarPassport = new CarPassport(this);
        }

        public void ChangeOwner(Driver driver, string carnumber)
        {
            driver.OwnCar(this);

            CarPassport.Owner = driver;
            CarNumber = carnumber;
            
        }
    }
}
