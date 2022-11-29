using EntitiesLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules.FluentValidator
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(b => b.Id).NotEmpty();
            RuleFor(b => b.Id).GreaterThan(0).WithMessage("Şirket Id Numarası 0'dan büyük olmalı!");
            RuleFor(b => b.CompanyName).NotEmpty().WithMessage("Şirket Adı Boş Olmamalıdır!");
            RuleFor(b => b.CompanyName.Length).LessThan(20).WithMessage("Renk Adı Uzunluğu En Fazla 20 Karakter Olmalıdır!");
        }
    }

}
