using Microsoft.AspNetCore.Mvc;
using OtobusBilet.Models;

namespace OtobusBilet.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AdminGiris1()
        {
          return View ("AdminGirisi");
        }

        public IActionResult AdminGiris2()
        {
            if(ModelState.IsValid)
            {
                return View("AdminSayfa");
            }
            return View("AdminGirisi");
        }


    }
}
