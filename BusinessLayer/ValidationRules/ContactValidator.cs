using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator:AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.mail).NotEmpty().WithMessage("Mail adresini boş geçemezsiniz!");
            RuleFor(x => x.name).NotEmpty().WithMessage("Ad kısmını boş geçemezsiniz!");
            RuleFor(x => x.subject).MinimumLength(3).WithMessage("Konuyu boş geçemezsiniz!");
            RuleFor(x => x.message).MaximumLength(200).WithMessage("Mesajı boş geçemezsiniz!");
        }
    }
}
