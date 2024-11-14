using System;

namespace MyApplication
{
  class PersegiPanjangDenganConstructor
  {
    private double panjang;
    private double lebar;
    
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
