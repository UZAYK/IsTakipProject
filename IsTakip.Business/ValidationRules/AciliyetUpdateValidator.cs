using FluentValidation;
using IsTakip.DTO.DTOs.AciliyetDTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsTakip.Business.ValidationRules.FluentValidation
{
   public class AciliyetUpdateValidator : AbstractValidator<AciliyetUpdateDto>
    {
        public AciliyetUpdateValidator()
        {
            RuleFor(I => I.Tanim).NotNull().WithMessage("Tanım alanı boş geçilemez");
        }
    }
}
