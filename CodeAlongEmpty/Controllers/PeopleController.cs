using Microsoft.AspNetCore.Mvc;
using CodeAlongEmpty.Models;


namespace CodeAlongEmpty.Controllers
{
    public class PeopleController : Controller
    {
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

        

    }
}
