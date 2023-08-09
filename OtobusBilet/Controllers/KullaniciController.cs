using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;
using OtobusBilet.Models;
using System.Linq;

namespace OtobusBilet.Controllers
{
    
    public class KullaniciController : Controller
    {

        public OtobusBiletContext context = new OtobusBiletContext();

       

       
        public IActionResult KullaniciGiris()
        {
          return View("KullaniciGiris");
             
        }

        public IActionResult KullaniciGiris2(Kullanici kullanici)
        {

            if (ModelState.IsValid)
            {
              return View("BiletSayfa");
            }
            return View("Index");
        }
        [HttpPost]
        public IActionResult Create(Kullanici kullanici)
        {
            if (ModelState.IsValid)
            {
                context.Kullanicilar.Add(kullanici);
                context.SaveChanges();
                return View ("KullanıcıGirdi");
            }
            return View("Anasayfa");
        }

        public IActionResult KullaniciGirdi()
        {
            var kullanicilar1 = context.Kullanicilar.ToList();
            return View(kullanicilar1);
        }

      




    }

}
