using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.DataAccess.Abstract;
using MyLibrary.DataAccess.Concrete.EntityFramework;
using MyLibrary.Entities.Concrete;

namespace MyLibrary.DataAccess.Concrete.NhTest
{
   public class NhBookDal: EntityRepositoryBase<Book, DatabaseContext>, IBookDal
    {

    }
}
