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
    public class FisValidator : AbstractValidator<Fis>
    {
        public FisValidator()
        {
            RuleFor(p => p.FisKodu).isUnique();
        }
    }
}
