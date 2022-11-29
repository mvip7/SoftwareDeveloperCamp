using EntitiesLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules.FluentValidator
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(b => b.Id).NotEmpty();
            RuleFor(b => b.FirstName).NotEmpty();
            RuleFor(b => b.FirstName.Length).GreaterThan(2).WithMessage("Kullanıcı Adı En Az 3 Karakter Olmalı!");
            RuleFor(b => b.LastName).NotEmpty();
            RuleFor(b => b.LastName.Length).GreaterThanOrEqualTo(2).WithMessage("Kullanıcı Soyadı En Az 2 Karakter Olmalı!");
            RuleFor(b => b.Email).NotNull();
            RuleFor(b => b.Email).Must(b => b.EndsWith("@gmail.com") && b.EndsWith("@outlook.com"));
            RuleFor(b => b.Password).Matches("[0-9]").WithMessage("Şifreniz Sayısal Bir Değer İçermeli");
            RuleFor(b => b.Password).NotNull();
        }
    }

}
