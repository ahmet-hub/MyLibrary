using MyLibrary.DataAccess.Abstract;
using MyLibrary.Entities.Concrete;

namespace MyLibrary.DataAccess.Concrete.EntityFramework
{
    public class EfUserBookTraceDal:EntityRepositoryBase<UserBookTrace, DatabaseContext>,IUserBookTraceDal
    {

    }
}
