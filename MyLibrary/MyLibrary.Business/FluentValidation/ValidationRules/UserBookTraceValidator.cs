using FluentValidation;
using MyLibrary.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Business.FluentValidation.ValidationRules
{
   public  class UserBookTraceValidator:AbstractValidator<UserBookTrace>
    {
        public UserBookTraceValidator()
        {
            RuleFor(p => p.TakenDate).NotEmpty().WithMessage("Alış tarihi boş bırakılamaz.").LessThan(p => DateTime.Now).WithMessage("Alış tarihi geçmiş zaman olamaz");
            RuleFor(p => p.ReturnDate).LessThan(p => p.TakenDate).WithMessage("Veriş tarihi alış tarihinden önce olamaz");
            RuleFor(p => p.Book).NotEmpty().WithMessage("Kitap boş bırakılamaz.");
            RuleFor(p => p.User).NotEmpty().WithMessage("Alıcı boş bırakılamaz");
            
        }

    }
}
