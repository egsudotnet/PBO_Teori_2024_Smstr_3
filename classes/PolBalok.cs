using System;

namespace MyApplication
{
class Balok : Bentuk
{
    private double Panjang;
    private double Lebar;
    private double Tinggi;

    public Balok(double panjang, double lebar, double tinggi)
    {
        Panjang = panjang;
        Lebar = lebar;
        Tinggi = tinggi;
    }

    public override double HitungVolume()
    {
        return Panjang * Lebar * Tinggi;
    }
}


}
