using FluentValidation;
using MyLibrary.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Business.FluentValidation.ValidationRules
{
    public class AuthorValidator:AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Yazar adı boş bırakılamaz.");
           

        }
       
    }
}
