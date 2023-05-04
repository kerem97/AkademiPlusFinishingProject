using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter giriniz");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen en az 5 karakter giriniz");
        }
    }
}
