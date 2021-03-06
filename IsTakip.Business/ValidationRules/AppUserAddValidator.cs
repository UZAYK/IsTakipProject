using FluentValidation;
using IsTakip.Web.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsTakip.Business.ValidationRules.FluentValidation
{
    public class AppUserAddValidator : AbstractValidator<AppUserAddDto>
    {
        public AppUserAddValidator()
        {
            RuleFor(I => I.UserName).NotNull().WithMessage("Kullanıcı Adı boş geçilemez");

            RuleFor(I => I.Password).NotNull().WithMessage("Parola alanı boş geçilemez");

            RuleFor(I => I.ConfirmPassword).NotNull().WithMessage("Parola onay alanı boş geçilemez");

            RuleFor(I => I.ConfirmPassword).Equal(I => I.Password).WithMessage("Parolalarınız eşleşmiyor");

            RuleFor(I => I.Email).NotNull().WithMessage("Email alanı boş geçilemez").EmailAddress().WithMessage("Ge.ersiz email adresi");

            RuleFor(I => I.UserName).NotNull().WithMessage("Ad alanı boş geçilemez");

            RuleFor(I => I.SurName).NotNull().WithMessage("Soyad alanı boş geçilemez");

        }
    }
}
