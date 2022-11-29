using EntitiesLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ValidationRules.FluentValidator
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.ID).NotEmpty();
            RuleFor(c => c.ID).GreaterThan(0);
            RuleFor(c => c.BrandID).NotEmpty();
            RuleFor(c => c.ColorID).NotEmpty();
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(100);
            RuleFor(c => c.Description).NotEmpty();
            RuleFor(c => c.Description.Length).LessThan(50);
        }
    }
}
