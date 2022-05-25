using CodeAlongEmpty.Data;
using CodeAlongEmpty.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CodeAlongEmpty.Controllers
{
    public class CarOwnerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CarOwnerController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddOwnerToCar()
        {
            ViewBag.People = new SelectList(_context.People, "SSN", "SSN");
            ViewBag.Cars = new SelectList(_context.Cars, "RegNumber", "RegNumber");
            return View();
        }
        [HttpPost]
        public IActionResult AddOwnerToCar(string ssn, string regnumber)
        {
            CarOwner model = new CarOwner();
            model.RegNumber = regnumber;
            model.SSN = ssn;
            _context.CarOwners.Add(model);
            _context.SaveChanges(); 
            return View();
        }
    }
}
