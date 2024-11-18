using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
 
            // Create instances of different shapes
            Bentuk kubus = new Kubus(3); // Panjang sisi = 3
            Bentuk balok = new Balok(4, 5, 6); // Panjang = 4, Lebar = 5, Tinggi = 6
           
            // Calculate and display the volumes
            Console.WriteLine("Volume kubus: " + kubus.HitungVolume());
            Console.WriteLine("Volume balok: " + balok.HitungVolume());
          
            Console.WriteLine("\nTekan tombol apapun untuk keluar...");
            Console.ReadKey();
        }
    }
}