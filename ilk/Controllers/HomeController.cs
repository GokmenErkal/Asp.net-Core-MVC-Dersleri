using ilk.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ilk.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult Index3()
        {
            var books = new List<Kitap>()
            {
                new Kitap(){ID=1, KitapAd="80 Günde Devri Alem", Yazar="Jules Verne"},
                new Kitap(){ID=2, KitapAd="Bilinmeyen Bir Kadının Mektubu", Yazar="Zweig"},
                new Kitap(){ID=3, KitapAd= "Bir Noel Hikayesi", Yazar="Charles Dickens"},
                new Kitap(){ID=4, KitapAd= "Şeker Portakalı", Yazar="Vasconceulos"}
            };
            return View(books);
        }
        public IActionResult Index4()
        {
            ViewBag.deger1 = "Merhaba Core Dersleri Devam Ediyor";
            ViewBag.deger2 = "Sizden Bir Ricam Var";
            ViewBag.deger3 = "Bugün 22 Haziran 2024 Cumartesi, Hava Güneşli ve Çok Güzel Tam Denize Girmelik :) ";

            return View();
        }
        public IActionResult Index5()
        {
            return View();
        }
        public IActionResult Index6()
        {
            return View();
        }
        public IActionResult Index7()
        {
            return View();
        }
    }
}
