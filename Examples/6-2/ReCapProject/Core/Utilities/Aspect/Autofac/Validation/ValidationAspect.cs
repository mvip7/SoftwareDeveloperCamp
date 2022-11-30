using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Utilities.Aspect.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            // validatorType değişkenine gelen nesnenin bir IValidator olup olmadıgını kontrol etme işlemi+
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Bu Bir Doğrulama Sınıfı Değildir !!! ");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType); 
                              // UserValidator nesnesini, proje çalışırken new() işlemini yapıyoruz yani çalıştırıyoruz
            var entityType = _validatorType.BaseType.GetGenericArguments()[0]; 
                            // UserValidator'ın base type'ı => AbstractValidator ,
                           //  AbstractValidatorun generic argumanlarından 0. elemanı bul yani IEntity(Car Nesnesi) Olanı Gönderiyoruz.
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
                         // IInvocation'a gönderilen Add metodunun parametrelerine bak ve
                         // Validatorun aldıgı generic tipine eşit olan parametreleri bul
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
