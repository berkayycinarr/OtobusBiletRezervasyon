﻿using System.ComponentModel.DataAnnotations;

namespace OtobusBilet.Models
{
    public class Kullanici
    {
        [Key]
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }    
}
