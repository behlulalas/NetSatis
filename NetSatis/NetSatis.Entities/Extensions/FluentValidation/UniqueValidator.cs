using DevExpress.Data.Linq.Helpers;
using FluentValidation.Resources;
using FluentValidation.Validators;
using NetSatis.Entities.Context;
using NetSatis.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Extensions.FluentValidation
{
    public class UniqueValidator<TEntity> : PropertyValidator
        where TEntity : class, IEntity, new()
    {
        public UniqueValidator() : base("Girdiğiniz {PropertyName} kayıtlarda var.")
        {
        }
        protected override bool IsValid(PropertyValidatorContext context)
        {
            using (var netSatisContext = new NetSatisContext())
            {
                var dataId = context.Instance.GetType().GetProperty("Id").GetValue(context.Instance);
                var result = netSatisContext.Set<TEntity>().Where($"{context.PropertyName}==@0 And Id!=@1", context.PropertyValue,dataId).Any();
                return !result;
            }
        }
    }
}
