using System.ComponentModel.DataAnnotations;

namespace OtobusBilet.Models
{
    public class Otobus
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Plaka { get; set; }
        [Required]
        public int KoltukNumarasi { get; set; }
    }
}
