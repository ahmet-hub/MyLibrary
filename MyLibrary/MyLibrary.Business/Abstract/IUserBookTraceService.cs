using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Entities.Concrete;

namespace MyLibrary.Business.Abstract
{
    public interface IUserBookTraceService
    {
        List<UserBookTrace> GetAll();
        void Add(UserBookTrace userBookTrace);
    }
}
