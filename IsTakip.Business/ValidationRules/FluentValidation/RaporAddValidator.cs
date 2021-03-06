using FluentValidation;
using IsTakip.DTO.DTOs.RaporDtos;

namespace IsTakip.Business.ValidationRules.FluentValidation
{
    public class RaporAddValidator : AbstractValidator<RaporAddDto>
    {
        public RaporAddValidator()
        {
            RuleFor(I => I.Tanim).NotNull().WithMessage("Tanım alanı boş geçilemez");
            RuleFor(I => I.Detay).NotNull().WithMessage("Detay alanı boş geçilemez");
        }

    }
}
