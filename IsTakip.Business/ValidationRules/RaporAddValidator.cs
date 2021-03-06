using FluentValidation;
using IsTakip.DTO.DTOs.RaporDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsTakip.Business.ValidationRules.FluentValidation
{
    public class RaporAddValidator : AbstractValidator<RaporAddDto>
    {
        public RaporAddValidator()
        {
            RuleFor(I => I.Tanim).NotNull().WithMessage("Tanım alanı boş geçilemez");

            RuleFor(I => I.Detay).NotNull().WithMessage("Tanım alanı boş geçilemez");
        }
    }
}
