using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcVeBootstrap.Models
{
    public class Uye
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Telefon { get; set; }
        public bool Durum { get; set; } 
    }
}