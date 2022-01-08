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
    public class KasaValidator : AbstractValidator<Kasa>
    {
        public KasaValidator()
        {
            RuleFor(p => p.KasaKodu).NotEmpty().WithMessage("Kasa Kodu alanı boş geçilemez.");
            RuleFor(p => p.KasaAdi).NotEmpty().WithMessage("Kasa adı alanı boş geçilemez.");
            RuleFor(p => p.KasaKodu).isUnique();
        }
    }
}
