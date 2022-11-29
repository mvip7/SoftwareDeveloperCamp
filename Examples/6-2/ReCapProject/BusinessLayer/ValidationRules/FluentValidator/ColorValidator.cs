using EntitiesLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules.FluentValidator
{
    public class ColorValidator : AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(b => b.Id).NotEmpty();
            RuleFor(b => b.Id).GreaterThan(0).WithMessage("Renk Id Numarası 0'dan büyük olmalı!");
            RuleFor(b => b.ColorName).NotEmpty().WithMessage("Renk Adı Boş Olmamalıdır!");
            RuleFor(b => b.ColorName.Length).LessThan(15).WithMessage("Renk Adı Uzunluğu En Fazla 15 Karakter Olmalıdır!");
        }
    }

}
