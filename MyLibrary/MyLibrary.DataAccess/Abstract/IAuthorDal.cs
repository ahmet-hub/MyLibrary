using MyLibrary.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.DataAccess.Concrete.EntityFramework;

namespace MyLibrary.DataAccess.Abstract
{
   public interface IAuthorDal:IEntityRepository<Author>
    {

    }
}
