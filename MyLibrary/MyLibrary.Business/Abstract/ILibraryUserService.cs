using MyLibrary.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Business.Abstract
{
    public interface ILibraryUserService
    {
        List<LibraryUser> GetAll();
        void Add(LibraryUser libraryUser);
        void Update(LibraryUser libraryUser);
        void Delete(LibraryUser libraryUser);
    }
}
