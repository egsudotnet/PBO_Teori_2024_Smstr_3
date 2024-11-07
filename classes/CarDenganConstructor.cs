using System;

namespace MyApplication
{
  class CarDenganConstructor
  {
    public string model;
    public string color;
    public int year;
    
    public CarDenganConstructor(string modelName, string modelColor, int modelYear)
    {
      model = modelName;
      color = modelColor;
      year = modelYear;
    }  
  }
}
