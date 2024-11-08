using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Tanpa Constructor"); 
            PersegiPanjangTanpaConstructor myObj = new PersegiPanjangTanpaConstructor(); 
            myObj.lebar = 6;
            myObj.panjang = 8; 
            Console.WriteLine("Luas = " + myObj.HitungLuas()); 


            Console.WriteLine("Dengan Constructor"); 
            PersegiPanjangDenganConstructor myObj1 = new PersegiPanjangDenganConstructor(6,8); 
            Console.WriteLine("Luas = " + myObj.HitungLuas()); 
             
            PersegiPanjangDenganConstructor myObj2 = new PersegiPanjangDenganConstructor(7,9); 
            Console.WriteLine("Luas = " + myObj2.HitungLuas()); 

        }
    }
}