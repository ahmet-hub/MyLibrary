using FluentValidation;
using MyLibrary.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Business.FluentValidation.ValidationRules
{
   public class TraceValidator:AbstractValidator<Trace>
    {
        public TraceValidator()
        {
            RuleFor(p => p.ColumnNo).NotEmpty().WithMessage("Kolon numarası boş bırakılamaz.");
            RuleFor(p => p.RowNo).NotEmpty().WithMessage("Sıra numarası boş bırakılamaz.");
            RuleFor(p => p.ShelfNo).NotEmpty().WithMessage("Raf numarası boş bırakılamaz.");
        }
    }
}
