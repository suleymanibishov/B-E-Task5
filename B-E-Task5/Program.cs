using System;

namespace B_E_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------Task1-------------------------------------
            //Person person = new Person("Isa", "Quliyev", 7);
            //Person person2 = new Person("Rauf", "Balakisiyev", 23);
            //Console.WriteLine(person.IsAdult);
            //Console.WriteLine(person2.IsAdult);

            //--------------------Task2-------------------------------------
            //Car car = new Car() { Brend = "Mersedes", Model = "S Class", Year = 2024, FuelType = "Benzin", Color = "Blac" };
            //car.PrintInfo();

            //--------------------Task3-------------------------------------
            //TCar tCar = new TCar() { Brend = "Mersedes", Model = "S Class", Year = 2024, MaxSpeed = 300, NumSeats = 4 };
            //if (tCar.MaxSpeed > 110) Console.WriteLine("Suret olduru"); else Console.WriteLine("Bele Davam et");
            //TMotorcycle tMotorcycle = new TMotorcycle() { Brend = "CVN", Model = "FC", Year = 1957, MaxSpeed = 80, HasSidecar = false };
            //if (tMotorcycle.MaxSpeed > 110) Console.WriteLine("Suret olduru"); else Console.WriteLine("Bele Davam et");


            //--------------------Task4-------------------------------------
            User user = new User()
            {
                Name = "Sadiq",
                Password = "alsadiq123"
            };
            Console.WriteLine(user.IsPasswordValid());
        }
    }
}
