using MyLibrary.Business.Abstract;
using MyLibrary.DataAccess.Abstract;
using MyLibrary.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Business.FluentValidation.ValidationRules;
using MyLibrary.Business.Utilities;
using MyLibrary.DataAccess;
using MyLibrary.DataAccess.Concrete.EntityFramework;

namespace MyLibrary.Business.Concrete
{
   public class LibraryUserManager:ILibraryUserService
    {
       // private EntityRepositoryBase<LibraryUser,DatabaseContext> repo_user=new EntityRepositoryBase<LibraryUser, DatabaseContext>();
        private readonly ILibraryUserDal _libraryUserDal;
        public LibraryUserManager(ILibraryUserDal libraryUserDal)
        {
            _libraryUserDal = libraryUserDal;
        }

        public List<LibraryUser> GetAll()
        {
           return _libraryUserDal.GetAll();
        }

        public void Add(LibraryUser libraryUser)
        {
            ValidationTool.Validate(new LibraryUserValidator(), libraryUser);
            _libraryUserDal.Add(libraryUser);
        }

        public void Update(LibraryUser libraryUser)
        {
           _libraryUserDal.Update(libraryUser);
        }

        public void Delete(LibraryUser libraryUser)
        {
            _libraryUserDal.Delete(libraryUser);
        }
    }
}
