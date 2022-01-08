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
    public class OdemeTuruValidator : AbstractValidator<OdemeTuru>
    {
        public OdemeTuruValidator()
        {
            RuleFor(p => p.OdemeTuruKodu).NotEmpty().WithMessage("Ödeme Türü Kodu alanı boş geçilemez.");
            RuleFor(p => p.OdemeTuruAdi).NotEmpty().WithMessage("Ödeme Türü adı alanı boş geçilemez.");
            RuleFor(p => p.OdemeTuruKodu).isUnique();
        }
    }
}
