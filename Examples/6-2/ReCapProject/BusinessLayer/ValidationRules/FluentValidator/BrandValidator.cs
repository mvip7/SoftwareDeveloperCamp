using EntitiesLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ValidationRules.FluentValidator
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b => b.Id).NotEmpty().WithMessage("Marka Id Numarası Boş Olmamalı!");
            RuleFor(b => b.Id).GreaterThan(0).WithMessage("Marka Id Numarası 0'dan büyük olmalı!");
            RuleFor(b => b.BrandName).NotEmpty();
            RuleFor(b => b.BrandName.Length).LessThan(15).WithMessage("Marka Adı Uzunluğu En Fazla 15 Karakter Olmalıdır!");
        }
    }

}
