using System;

namespace MyApplication
{
  class PersegiPanjangDenganConstructor
  {
    public double panjang;
    public double lebar;
    
    public PersegiPanjangDenganConstructor(double panjangPersegi, double lebarLebar){
      panjang = panjangPersegi;
      lebar = lebarLebar;
    }

    public double HitungLuas()
    {
      return panjang * lebar;
    }
  }
}
