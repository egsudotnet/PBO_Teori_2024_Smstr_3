using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            // Tanpa Contructor

            Console.WriteLine("Tanpa Contructor");
            CarTanpaConstructor Ford = new CarTanpaConstructor();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;

            CarTanpaConstructor Opel = new CarTanpaConstructor();
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);


            // Dengan Constructor
            Console.WriteLine("Dengan Contructor");
            CarDenganConstructor carDenganConstructor1 = new CarDenganConstructor("Mustang", "red", 1969);
            CarDenganConstructor carDenganConstructor2 = new CarDenganConstructor("Astra", "white", 2005);

            Console.WriteLine(carDenganConstructor1.model);
            Console.WriteLine(carDenganConstructor2.model);

        }
    }
}