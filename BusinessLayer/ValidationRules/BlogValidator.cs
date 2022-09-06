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
            RuleFor(x => x.title).NotEmpty().WithMessage("Blog başlığını boş geçemezsiniz!");
            RuleFor(x => x.content).NotEmpty().WithMessage("Blog içeriğini boş geçemezsiniz!");
            RuleFor(x => x.title).MinimumLength(3).WithMessage("Lütfen en az 3 karakterlik blog başlığı giriniz!");
            RuleFor(x => x.title).MaximumLength(200).WithMessage("Lütfen en fazla 200 karakterlik blog başlığı giriniz!");
        }
    }
}
