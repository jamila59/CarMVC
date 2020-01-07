using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;  
using Automobile.Models;

namespace Automobile.Controllers
{
  public class HomeController : Controller
  {
      [Route("/")]//First main user page;
      public ActionResult Template() { return View(); }

      [Route("/new")]//
      public ActionResult WorthBuying()
      {
        Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
        Car yugo = new Car("1980 Yugo Koral", 700, 56000);
        Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
        Car amc = new Car("1976 AMC Pacer", 400, 198000);
          
          List<Car> newCar = new List<Car>() { volkswagen, yugo, ford, amc };
          //You can instantiate classes here to have them render on
         // your last page

           return View(newCar); 

    }
  }
}