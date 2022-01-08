using FluentValidation;
using NetSatis.Entities.Extensions.FluentValidation;
using NetSatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Validations
{
    public class KullaniciValidator:AbstractValidator<Kullanici>
    {
        public KullaniciValidator()
        {
            //RuleFor(p => p.KullaniciAdi).isUnique();
            RuleFor(p => p.KullaniciAdi).NotEmpty().WithMessage("Kullanıcı Adı alanı boş geçilemez.");
            RuleFor(p => p.Adi).NotEmpty().WithMessage("Adi alanı boş geçilemez.");
            RuleFor(p => p.Soyadi).NotEmpty().WithMessage("Soyadi alanı boş geçilemez.");
            RuleFor(p => p.Gorevi).NotEmpty().WithMessage("Gorevi alanı boş geçilemez.");
            RuleFor(p => p.Parola).NotEmpty().WithMessage("Parola alanı boş geçilemez.");
            RuleFor(p => p.HatirlatmaSorusu).NotEmpty().WithMessage("Hatirlatma Sorusu alanı boş geçilemez.");
            RuleFor(p => p.Cevap).NotEmpty().WithMessage("Cevap alanı boş geçilemez.");
        }
    }
}
