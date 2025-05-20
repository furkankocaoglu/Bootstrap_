using mvcVeBootstrap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcVeBootstrap.Controllers
{
    public class UyeController : Controller
    {

        public ActionResult Index()
        {
            List<Uye> uyeler = new List<Uye>
            {
                new Uye { Id = 1, Isim = "Murtaza", Soyisim = "Şuayipoğlu", Telefon = "530 111 11 11", Durum = true },
                new Uye { Id = 2, Isim = "Ali", Soyisim = "Veli", Telefon = "531 222 22 22", Durum = false },
                new Uye { Id = 3, Isim = "Ayşe", Soyisim = "Yılmaz", Telefon = "532 333 33 33", Durum = true },
                new Uye { Id = 4, Isim = "Elif", Soyisim = "Kara", Telefon = "533 444 44 44", Durum = true },
                new Uye { Id = 5, Isim = "Mehmet", Soyisim = "Demir", Telefon = "534 555 55 55", Durum = false },
                new Uye { Id = 6, Isim = "Zeynep", Soyisim = "Çelik", Telefon = "535 666 66 66", Durum = true },
                new Uye { Id = 7, Isim = "Burak", Soyisim = "Aydın", Telefon = "536 777 77 77", Durum = false },
                new Uye { Id = 8, Isim = "Fatma", Soyisim = "Şahin", Telefon = "537 888 88 88", Durum = true },
                new Uye { Id = 9, Isim = "Ahmet", Soyisim = "Kılıç", Telefon = "538 999 99 99", Durum = false },
                new Uye { Id = 10, Isim = "Derya", Soyisim = "Taş", Telefon = "539 000 00 00", Durum = true },
                new Uye { Id = 11, Isim = "Can", Soyisim = "Güneş", Telefon = "540 101 01 01", Durum = true },
                new Uye { Id = 12, Isim = "Naz", Soyisim = "Balcı", Telefon = "541 202 02 02", Durum = false },
                new Uye { Id = 13, Isim = "Yusuf", Soyisim = "Koç", Telefon = "542 303 03 03", Durum = true }
             };

            return View(uyeler);
        }
    }
}