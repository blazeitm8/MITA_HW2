namespace Model
{
    public class CarPassport 
    {
        public Driver Owner { get; set; }

        public Car Car { get; }

        public CarPassport(Car car)
        {
            Car = car;
        }
    }
}
