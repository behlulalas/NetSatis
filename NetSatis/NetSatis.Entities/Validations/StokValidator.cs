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
    public class StokValidator:AbstractValidator<Stok>
    {
        public StokValidator()
        {
            RuleFor(p => p.StokKodu).isUnique();
            RuleFor(p => p.StokKodu).NotEmpty().WithMessage("Stok Kodu alanı boş geçilemez.");
            RuleFor(p => p.StokAdi).NotEmpty().WithMessage("Stok Adı alanı boş geçilemez.").Length(5,50)
                .WithMessage("Stok Adı alanı 5 ile 50 karakter arasında olabilir.");
            RuleFor(p => p.Barkod).NotEmpty().WithMessage("Barkod alanı boş geçilemez.");
            RuleFor(p => p.AlisFiyati1).GreaterThanOrEqualTo(0).WithMessage("Alış fiyatı - 1 alanı 0'dan küçük olamaz.");
            RuleFor(p => p.AlisFiyati2).GreaterThanOrEqualTo(0).WithMessage("Alış fiyatı - 2 alanı 0'dan küçük olamaz.");
            RuleFor(p => p.AlisFiyati3).GreaterThanOrEqualTo(0).WithMessage("Alış fiyatı - 3 alanı 0'dan küçük olamaz.");
            RuleFor(p => p.SatisFiyati1).GreaterThanOrEqualTo(0).WithMessage("Satış fiyatı - 1 alanı 0'dan küçük olamaz.");
            RuleFor(p => p.SatisFiyati2).GreaterThanOrEqualTo(0).WithMessage("Satış fiyatı - 2 alanı 0'dan küçük olamaz.");
            RuleFor(p => p.SatisFiyati3).GreaterThanOrEqualTo(0).WithMessage("Satış fiyatı - 3 alanı 0'dan küçük olamaz.");

        }
    }
}
