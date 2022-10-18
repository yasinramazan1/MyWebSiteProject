using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        // bir ctor metot oluşturulur ve içerisine kurallar atanır.
        // name, description gibi özellikler AbstractValidator kalıtımında generic verilen yapıdan çekilir.
        public CategoryValidator()
        {
            RuleFor(x => x.name).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz!");
            RuleFor(x => x.description).NotEmpty().WithMessage("Kategori açıklamasını boş geçemezsiniz!");
            RuleFor(x => x.name).MinimumLength(3).WithMessage("Lütfen en az 3 karakterlik kategori adı giriniz!");
            RuleFor(x => x.name).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakterlik kategori adı giriniz!");
        }
    }
}
