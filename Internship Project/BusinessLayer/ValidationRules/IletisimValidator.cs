using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class IletisimValidator : AbstractValidator<Iletisim>
    {
        public IletisimValidator()
        {
            RuleFor(x => x.ad).NotEmpty().WithMessage("First name cannot be blank");
            RuleFor(x => x.soyad).NotEmpty().WithMessage("Last name cannot be blank");
            RuleFor(x => x.email).NotEmpty().WithMessage("E-mail cannot be blank");
            RuleFor(x => x.mesaj).NotEmpty().WithMessage("Project details cannot be left blank.");
            RuleFor(x => x.mesaj).MaximumLength(100).WithMessage("Please do not enter more than hundred characters in the details of the project.");
            RuleFor(x => x.mesaj).MinimumLength(30).WithMessage("Please do not enter less than thirty characters in the name of the project.");
        }
    }
}
