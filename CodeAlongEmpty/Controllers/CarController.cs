using CodeAlongEmpty.Data;
using CodeAlongEmpty.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CodeAlongEmpty.Controllers
{
    public class CarController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CarController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Car> listOfCars = _context.Cars.ToList();
            return View(listOfCars);
        }
        public IActionResult Create()
        {
            return View(); 
        }
        [HttpPost]
        public IActionResult Create(Car car)
        {
            if(ModelState.IsValid)
            {
                _context.Cars.Add(car);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(); 
        }

        public IActionResult Remove(string regNumber)
        {
            var carToRemove = _context.Cars.Find(regNumber);

            _context.Cars.Remove(carToRemove);
            _context.SaveChanges(); 

            return RedirectToAction("Index");
        }
    }
}
