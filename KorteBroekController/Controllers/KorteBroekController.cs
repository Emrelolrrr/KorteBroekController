using Microsoft.AspNetCore.Mvc;

namespace KorteBroekController.Controllers
{
    public class KorteBroekController : Controller
    {
       
        public IActionResult Index()
        {
            ViewData["Title"] = "Korte Broek?";
            return View();
        }

   
        public IActionResult Weer()
        {

            var temperatuur = 23; 
            var regenKans = 10;  
            var korteBroekAan = temperatuur >= 20 && regenKans < 40;

            ViewData["Title"] = "Weer Vandaag";
            ViewData["Temperatuur"] = temperatuur;
            ViewData["RegenKans"] = regenKans;
            ViewData["KorteBroek"] = korteBroekAan ? "Ja, korte broek kan aan! 😎" : "Nee, beter lange broek. 🧥";
            ViewData["Afbeelding"] = korteBroekAan ? "/images/sunny.png" : "/images/rainy.png";

            return View();
        }
    }
}
