using FluentValidation;
using IsTakip.DTO.DTOs.AciliyetDTOs;

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
