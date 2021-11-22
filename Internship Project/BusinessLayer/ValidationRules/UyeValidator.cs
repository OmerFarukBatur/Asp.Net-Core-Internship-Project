using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class UyeValidator: AbstractValidator<Uye>
    {
        public UyeValidator()
        {
            RuleFor(x => x.uyeAdi).NotEmpty().WithMessage("First name cannot be blank");
            RuleFor(x => x.uyeSoyadi).NotEmpty().WithMessage("Last name cannot be blank");
            RuleFor(x => x.email).NotEmpty().WithMessage("Email cannot be blank");
            RuleFor(x => x.parola).NotEmpty().WithMessage("Password cannot be blank");
            RuleFor(x => x.telNo).NotEmpty().WithMessage("Mobile number cannot be blank");
            RuleFor(x => x.telNo).MaximumLength(11).WithMessage("Please do not enter more than 11 digits.");
            RuleFor(x => x.parola).MinimumLength(6).WithMessage("Please do not enter less than six digits.");
        }

        
    }
}
