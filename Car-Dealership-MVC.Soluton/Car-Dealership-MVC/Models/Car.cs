using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Automobile.Models
{

public class Car
{
  public string MakeModel { get; set; }
  public int Price { get; set; }
  public int Miles { get; set; }

  public Car(string makeModel, int price, int miles)
  {
    MakeModel = makeModel;
    Price = price;
    Miles = miles;
  }
  }
}
