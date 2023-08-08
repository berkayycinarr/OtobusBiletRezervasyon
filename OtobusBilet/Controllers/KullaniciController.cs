using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;
using OtobusBilet.Models;

namespace OtobusBilet.Controllers
{
    
    public class KullaniciController : Controller
    {
        List<Kullanici> kullanicilar = new List<Kullanici>();
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
        public IActionResult KullaniciKayit(Kullanici k)
        {
            if(!ModelState.IsValid)
            {
                kullanicilar.Add(k);

                return View("KullaniciGiris");
            }
            return View();
        }


    }

 }
