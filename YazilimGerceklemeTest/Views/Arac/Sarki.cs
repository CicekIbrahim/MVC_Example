using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MYAZ303_MVC.Models
{
    public class Sarki
    {
        [Key]
        public int sarkiID { get; set; }
        [Required]
        public string sarkiAd { get; set; }
        public float sure { get; set; }
        public string sanatci { get; set; }
        public string album { get; set; }
    }
}
