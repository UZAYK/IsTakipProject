using FluentValidation;
using IsTakip.DTO.DTOs.AciliyetDTOs;


namespace IsTakip.Business.ValidationRules.FluentValidation
{
    public class AciliyetAddValidator : AbstractValidator<AciliyetAddDto>
    {
        public AciliyetAddValidator()
        {
            RuleFor(I => I.Tanim).NotNull().WithMessage("Tanım alanı boş geçilemez");
        }
    }
}
