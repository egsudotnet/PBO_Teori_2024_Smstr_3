using System;

namespace MyApplication
{
  class Kubus : Bentuk
  {
    private double Sisi;

    public Kubus(double sisi)
    {
      Sisi = sisi;
    }

    public override double HitungVolume()
    {
      return Math.Pow(Sisi, 3);
    }
  }

}
