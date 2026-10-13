using Assignment_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    public class CarController : Controller
    {
        private static List<Car> availableCars=new List<Car> { new Car(1, "Alto", 3000), new Car(2, "Corolla", 6000), new Car(3, "Civic", 8000) };
        private static List<Car> bookedCars=new List<Car>();
        [HttpGet]
        public  IActionResult Index()
        { 
            return View(availableCars);
        }
        [HttpPost]
        public IActionResult Book(int id)
        {
            if(id==null)
            {
                return RedirectToAction("Index");
            }
            Car c=availableCars.Find(c  => c.Id == id);
            if(c==null)
            {
                return RedirectToAction("Index");
            }
            availableCars.Remove(c);
            bookedCars.Add(c);
            return RedirectToAction("Booked");
        }

        [HttpGet]
        public IActionResult Booked()
        {
            return View(bookedCars);
        }
    }
}




