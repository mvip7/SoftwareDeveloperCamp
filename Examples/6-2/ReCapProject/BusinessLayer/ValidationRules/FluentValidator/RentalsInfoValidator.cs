using EntitiesLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules.FluentValidator
{
    public class RentalsInfoValidator : AbstractValidator<RentalsInfo>
    {
        public RentalsInfoValidator()
        {
            RuleFor(b => b.CarId).NotEmpty();
            RuleFor(b => b.CustomerId).NotEmpty();
            RuleFor(b => b.CarId).GreaterThan(0).WithMessage("Araç Id Numarası 0'dan büyük olmalı!");
            RuleFor(b => b.CustomerId).GreaterThan(0).WithMessage("Müşteri Id Numarası 0'dan büyük olmalı!");
            RuleFor(b => b.RentDate).NotEmpty().WithMessage("Kiralama Tarihi Boş Bırakılamaz");
            RuleFor(b => b.ReturnDate.DayOfYear).GreaterThan(b => b.RentDate.DayOfYear);
        }
    }

}
