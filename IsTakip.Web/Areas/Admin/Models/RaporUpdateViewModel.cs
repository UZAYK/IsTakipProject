using IsTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IsTakip.Web.Areas.Admin.Models
{
    public class RaporUpdateViewModel
    {
        public int Id { get; set; }

        public int GorevId { get; set; }

        [Required(ErrorMessage = "Tanım alanı boş geçilemez")]
        [Display(Name = "Tanım :")]
        public string Tanim { get; set; }

        [Required(ErrorMessage = "Detay alanı boş geçilemez")]
        [Display(Name = "Detay :")]
        public string Detay { get; set; }

        public Gorev Gorev { get; set; }
    }
}
