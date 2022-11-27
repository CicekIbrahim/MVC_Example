using System.ComponentModel.DataAnnotations;

namespace YazilimGerceklemeTest.Models
{
    public class Arac
    {
        [Key]
        public int AracId { get; set; }
        [Required]
        public string AracMarka { get; set; }
        [Required]
        public string AracModel { get; set; }
        public int Yil { get; set; }
        public float Motor { get; set; }
    }
}