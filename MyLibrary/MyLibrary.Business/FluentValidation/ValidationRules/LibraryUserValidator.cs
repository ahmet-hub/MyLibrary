using FluentValidation;
using MyLibrary.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.DataAccess;
using MyLibrary.DataAccess.Concrete.EntityFramework;

namespace MyLibrary.Business.FluentValidation.ValidationRules
{
   public class LibraryUserValidator:AbstractValidator<LibraryUser>
   {
       private EntityRepositoryBase<LibraryUser,DatabaseContext> user=new EntityRepositoryBase<LibraryUser, DatabaseContext>();
        
        public LibraryUserValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Kullanıcı adı boş olamaz.").Length(3, 20).WithMessage("Kullanıcı Adı 3 ile 20 karakter arasında olmalıdır.");
            RuleFor(p => p.LastName).NotEmpty().WithMessage("Kullanıcı soyadı boş olamaz.").Length(2, 20).WithMessage("Kullanıcı soyadı 2 ile 20 karakter arasında olmalıdır.");
            RuleFor(p => p.Email).NotEmpty().WithMessage("Mail boş bırakılamaz.").EmailAddress().WithMessage("Geçerli bir mail adress giriniz.");
            RuleFor(p=>p.Phone).NotEmpty().WithMessage("Telefon boş bırakılamaz.").Length(11,11).WithMessage("Geçerli bir numara giriniz.");
           // RuleFor(p => p.Name == user.Name);
        }

       
    }
}
