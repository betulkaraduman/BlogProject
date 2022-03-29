using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidation : AbstractValidator<Writer>
    {
        public WriterValidation()
        {
            RuleFor(i => i.WriterName).NotEmpty().WithMessage("Writer Name Surname cannot empty");
            RuleFor(i => i.Email).NotEmpty().WithMessage("Email cannot empty");
            RuleFor(i => i.WriterImage).NotEmpty().WithMessage("Image Path cannot empty");
            RuleFor(i => i.Email).EmailAddress().WithMessage("Email is not email format");
            RuleFor(i => i.Password).NotEmpty().WithMessage("Password cannot empty");
            RuleFor(i => i.Password).Length(2, 8).WithMessage("Password must be min 2 and max8 character"); 
            RuleFor(p => p.Password).Matches(@"[a-z]+").WithMessage("Your password must contain at least one lowercase letter.");
            RuleFor(p => p.Password).Matches(@"[0-9]+").WithMessage("Your password must contain at least one number.");
            RuleFor(p => p.Password).Matches(@"[A-Z]+").WithMessage("Your password must contain at least one uppercase letter.");
            RuleFor(p => p.Password).Equal(i => i.ConfirmPassword).WithMessage("Passwords are not matches");

        }
 
    }

}
