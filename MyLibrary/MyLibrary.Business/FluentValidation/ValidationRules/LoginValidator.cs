using FluentValidation;
using MyLibrary.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyLibrary.Business.FluentValidation.ValidationRules
{
    public class LoginValidator: AbstractValidator<LibraryUser>
    {
        private LibraryUser _user=new LibraryUser();

        public LoginValidator( )
        {
            //RuleFor(p => p.Name == _user.Name || p.Password == _user.Password);
        }   
    }
}
