using FluentValidation;
using IsTakip.DTO.DTOs.GorevDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsTakip.Business.ValidationRules.FluentValidation
{
    public class GorevAddValidator : AbstractValidator<GorevAddDto>
    {
        public GorevAddValidator()
        {
            RuleFor(I => I.Ad).NotNull().WithMessage("Kullanıcı Adı boş geçilemez");

            RuleFor(I => I.AciliyetId).ExclusiveBetween(1, int.MaxValue).WithMessage("Kullanıcı Adı boş geçilemez");
        }
    }
}
