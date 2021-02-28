using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IsTakip.Web.Areas.Admin.Models
{
    public class GorevAddViewModel
    {
        [Required(ErrorMessage ="Ad alanı gereklidir.")]
        public string Ad { get; set; }
        [Display(Name ="Açıklama:")]
        public string Aciklama { get; set; }

        [Range(0,int.MaxValue,ErrorMessage ="Lütfen bir aciliyet durumu seçiniz.")]
        public int AciliyetId { get; set; }
        public SelectList Aciliyetler { get; set; }
    }
}
