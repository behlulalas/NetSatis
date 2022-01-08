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
    public class CariValidator:AbstractValidator<Cari>
    {
        public CariValidator()
        {
            RuleFor(p => p.CariKodu).NotEmpty().WithMessage("Cari Kodu alanı boş geçilemez.");
            RuleFor(p => p.CariKodu).isUnique();
            RuleFor(p => p.CariAdi).NotEmpty().WithMessage("Cari Adı alanı boş geçilemez.");
            RuleFor(p => p.YetkiliKisi).NotEmpty().WithMessage("Yetkili kişi alanı boş geçilemez.");
            RuleFor(p => p.FaturaUnvani).NotEmpty().WithMessage("Fatura Ünvanı Adı alanı boş geçilemez.");
            RuleFor(p => p.EMail).EmailAddress().WithMessage("Girdiğiniz Email geçersiz.");
            RuleFor(p => p.IskontoOrani).GreaterThanOrEqualTo(0).WithMessage("Iskonto oranı 0'dan küçük olamaz.");
            RuleFor(p => p.RiskLimiti).GreaterThanOrEqualTo(0).WithMessage("Risk Limiti oranı 0'dan küçük olamaz.");
        }
    }
}
