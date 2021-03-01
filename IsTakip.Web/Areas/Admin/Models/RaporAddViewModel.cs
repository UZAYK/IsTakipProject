using IsTakip.Entities.Concrete;
using System.ComponentModel.DataAnnotations;

namespace IsTakip.Web.Areas.Admin.Models
{
    public class RaporAddViewModel
    {
        public int GorevId { get; set; }

        [Required(ErrorMessage ="Tanım alanı boş geçilemez")]
        [Display(Name="Tanım")]
        public string Tanim { get; set; }

        [Required(ErrorMessage ="Detay alanı boş geçilemez")]
        [Display(Name="Detay")]
        public string Detay { get; set; }

        public Gorev Gorev { get; set; }
    }
}
