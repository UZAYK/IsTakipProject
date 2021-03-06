using FluentValidation;
using IsTakip.Web.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsTakip.Business.ValidationRules.FluentValidation
{
    public class AppUserSingInValidator : AbstractValidator<AppUserSignInDto>
    {
        public AppUserSingInValidator()
        {
            RuleFor(I => I.UserName).NotNull().WithMessage("Kullanıcı Adı boş geçilemez");

            RuleFor(I => I.Password).NotNull().WithMessage("Parola alanı boş geçilemez");
        }
    }
}
