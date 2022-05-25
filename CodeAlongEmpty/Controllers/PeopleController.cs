using Microsoft.AspNetCore.Mvc;
using CodeAlongEmpty.Models;
using CodeAlongEmpty.Data;
using System.Linq;

namespace CodeAlongEmpty.Controllers
{
    public class PeopleController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PeopleController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetInfo()
        {
            ViewBag.Message = PersonModel.WriteMessage();
            return View(); 
        }
        [HttpPost]
        public IActionResult GetInfo(string name, int age)
        {
            PersonModel model = new PersonModel();
            ViewBag.Name = name;
            ViewBag.Message = model.CheckAge(age); 
            return View(); 
        }
        public IActionResult People()
        {
            return View(_context.People.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Person person)
        {
            if(ModelState.IsValid)
            {
                _context.People.Add(person);
                _context.SaveChanges();
                return RedirectToAction("People");
            }
            return View(); 
        }

        public IActionResult Remove(string SSN)
        {
            var personToRemove = _context.People.Find(SSN);

            _context.People.Remove(personToRemove);
            _context.SaveChanges();

            return RedirectToAction("People");
        }


    }
}
