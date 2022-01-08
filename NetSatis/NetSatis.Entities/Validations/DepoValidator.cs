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
    public class DepoValidator : AbstractValidator<Depo>
    {
        public DepoValidator()
        {
            RuleFor(p => p.DepoKodu).NotEmpty().WithMessage("Depo Kodu alanı boş geçilemez.");
            RuleFor(p => p.DepoAdi).NotEmpty().WithMessage("Depo adı alanı boş geçilemez.");
            RuleFor(p => p.DepoKodu).isUnique();

        }
    }
}
