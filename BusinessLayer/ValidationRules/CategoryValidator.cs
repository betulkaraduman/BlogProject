using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
  public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(i => i.CategoryName).NotEmpty().WithMessage("Category name cannot be empty");
            RuleFor(i => i.CategoyDescription).NotEmpty().WithMessage("Category description cannot be empty");
        }
    }
}
