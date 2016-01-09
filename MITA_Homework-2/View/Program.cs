using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Model;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            var  car = new Car("Lada","D");
            car.Color = Color.BlueViolet;

            try
            {
                Console.WriteLine("Владелец машины - " + car.CarPassport.Owner.Name);
            }
            catch (Exception)
            {
                Console.WriteLine("Вы не ввели имя владельца!");
            }

            var driver = new Driver(new DateTime(2014,2,1), "Вальдемар");

            driver.Category = "BC";

            try
            {
                car.ChangeOwner(driver, "o777oo");
            }
            catch (Exception)
            {

                Console.WriteLine("Error!");
            }

            
            driver.Category += "D";
            car.ChangeOwner(driver, "o777oo");
            

            Console.WriteLine("Номер машины: " + driver.Car.CarNumber);

            Console.WriteLine("Владелец машины: " + car.CarPassport.Owner.Name);


            Console.ReadKey();
        }
    }
}
