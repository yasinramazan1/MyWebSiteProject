using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.name).NotEmpty().WithMessage("Yazar adı boş bırakılamaz!");
            RuleFor(x => x.job).NotEmpty().WithMessage("Yazar mesleği boş bırakılamaz!");
            RuleFor(x => x.image).NotEmpty().WithMessage("Yazar resmi boş bırakılamaz!");
            RuleFor(x => x.about).NotEmpty().WithMessage("Yazar hakkında kısmı boş bırakılamaz!");
        }
    }
}
