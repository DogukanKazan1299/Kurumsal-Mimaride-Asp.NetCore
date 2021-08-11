using FluentValidation;
using MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.ValidationRules.FluentValidation
{
    public class ShippingDetailValidator : AbstractValidator<ShippingDetail>
    {
        public ShippingDetailValidator()
        {
            RuleFor(s => s.FirstName).NotEmpty().WithMessage("Ad Alanı Boş Geçilemez");
            RuleFor(s => s.LastName).NotEmpty().WithMessage("Soyad Alanı Boş Geçilemez");
            RuleFor(s => s.Age).InclusiveBetween(18, 65);
            RuleFor(s => s.Email).EmailAddress();

        }
    }
}