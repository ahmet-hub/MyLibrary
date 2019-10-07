using FluentValidation;
using MyLibrary.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Business.FluentValidation.ValidationRules
{
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Kitap adı boş bırakılamaz.");
            RuleFor(p => p.AuthorId).NotEmpty().WithMessage("Yazar ekleyiniz");
           // RuleFor(p => p.Category).NotEmpty().WithMessage("")
            RuleFor(p => p.Publisher).NotEmpty();
            RuleFor(p => p.PublishYear).NotEmpty();
            RuleFor(p => p.Name.Length <= 20);
            RuleFor(p => p.Publisher.Length <= 20);
             
            //RuleFor(p => p.Category).NotEmpty();
            //RuleFor(p => p.Author).NotEmpty();

        }

        private void CheckBook()
        {

        }
    }

}
