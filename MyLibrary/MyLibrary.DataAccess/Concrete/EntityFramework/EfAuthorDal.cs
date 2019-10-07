using MyLibrary.DataAccess.Abstract;
using MyLibrary.DataAccess.Concrete;
using MyLibrary.Entities.Concrete;

namespace  MyLibrary.DataAccess.Concrete.EntityFramework
{
   public class EfAuthorDal:EntityRepositoryBase<Author, DatabaseContext>,IAuthorDal
    {

    }
}
