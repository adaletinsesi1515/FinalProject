using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty(); //boş olamaz
            RuleFor(p => p.UnitPrice).GreaterThan(0); //ürün fiyatı 0'dan büyük olmalı
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);    //ürünün fiyatı 10 ve 10 büyük olup category ıd si 1 olan ürünler için geçerli olacak
            // olmayan bir kuralı yazmak için
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı");



        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
