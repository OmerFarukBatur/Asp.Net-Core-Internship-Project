using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ProjectValidator : AbstractValidator<Proje>
    {
        public ProjectValidator()
        {
            RuleFor(x => x.projeAdi).NotEmpty().WithMessage("Project name cannot be blank");
            RuleFor(x => x.projeAdi).MaximumLength(50).WithMessage("Please do not enter more than fifty characters in the name of the project.");
            RuleFor(x => x.projeAdi).MinimumLength(10).WithMessage("Please do not enter less than ten characters in the name of the project.");
            RuleFor(x => x.kategoriID).NotEmpty().WithMessage("Please select a category.");
            RuleFor(x => x.projeDetaylari).NotEmpty().WithMessage("Project details cannot be left blank.");
            RuleFor(x => x.projeDetaylari).MaximumLength(100).WithMessage("Please do not enter more than hundred characters in the details of the project.");
            RuleFor(x => x.projeDetaylari).MinimumLength(30).WithMessage("Please do not enter less than thirty characters in the name of the project.");

        }
    }
}
