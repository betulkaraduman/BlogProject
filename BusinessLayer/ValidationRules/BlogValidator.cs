using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(i => i.BlogTitle).NotEmpty().WithMessage("Please enter blog name");
            RuleFor(i => i.BlogContent).NotEmpty().WithMessage("Please enter blog content");
            RuleFor(i => i.BlogImage).NotEmpty().WithMessage("Please enter blog image");
            RuleFor(i => i.BlogTitle).MaximumLength(100).WithMessage("Please enter blog image");
        }
    }
}
