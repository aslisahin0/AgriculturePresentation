using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görsel başlığı boş bırakılamaz.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Görsel açıklaması boş bırakılamaz.");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel yolu boş bırakılamaz.");
            RuleFor(x => x.Title).MaximumLength(30).WithMessage("Lütfen en fazla 20 karakter girişi yapın");
            RuleFor(x => x.Title).MinimumLength(6).WithMessage("Lütfen en az 3 karakter girişi yapın");
            RuleFor(x => x.Description).MaximumLength(70).WithMessage("Lütfen en fazla 50 karakter girişi yapın");
            RuleFor(x => x.Description).MinimumLength(20).WithMessage("Lütfen en az 20 karakter girişi yapın");
        }
    }
}
