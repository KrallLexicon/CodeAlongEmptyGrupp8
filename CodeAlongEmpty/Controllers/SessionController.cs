using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeAlongEmpty.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SetSession()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SetSession(string input, int numericInput)
        {
            HttpContext.Session.SetString("textSession", input);
            HttpContext.Session.SetInt32("numSession", numericInput);
            ViewBag.Message = "Session has been set!";
            return View();
        }
        public IActionResult GetSession()
        {
            int num = (int)HttpContext.Session.GetInt32("numSession"); 
            ViewBag.SessionText= HttpContext.Session.GetString("textSession");
            ViewBag.SessionNum = HttpContext.Session.GetInt32("numSession");
            ViewBag.Calculation = num + num;
            return View(); 
        }
    }
}
