using System.ComponentModel.DataAnnotations;

namespace OtobusBilet.Models
{
    public class Bilet
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime KalkisZamani { get; set; }
        [Required]
        public DateTime VarisZamani { get; set; }
        public int Fiyat { get; set; }
    }
}
