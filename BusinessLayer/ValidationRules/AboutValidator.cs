using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x=>x.Description).NotEmpty().WithMessage("Açıklama Kısmı boş geçilemez...!");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen görsel seçiniz");
            RuleFor(x => x.Description).MinimumLength(20).WithMessage("Lütfen en az 20 karakterlik açıklama bilgisi giriniz");


            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Lütfen en fazla 1500 karakterlik açıklama girilebilir...!");


        }
    }
}
