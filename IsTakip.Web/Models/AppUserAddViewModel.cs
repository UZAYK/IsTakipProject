using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IsTakip.Web.Models
{
    public class AppUserAddViewModal
    {
        [Required(ErrorMessage = "Kullanıcı Adı boş geçilemez")]
        [Display(Name = "Kullanıcı Adı:")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "İsim alanı boş geçilemez.")]
        [Display(Name = "İsim:")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyisim alanı boş geçilemez.")]
        [Display(Name = "Soyisim:")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Parola alanı boş geçilemez.")]
        [Display(Name = "Parola:")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Parolalar eşleşmiyor.")]
        [Display(Name = "Parolanızı Tekrar giriniz:")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "E-mail alanı boş geçilemez. ")]
        [Display(Name = "E-mail:")]
        public string Email { get; set; }
    }
}
