using MyLibrary.Business.Abstract;
using MyLibrary.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Entities.Concrete;

namespace MyLibrary.Business.Concrete
{
    public class UserBookTraceManager:IUserBookTraceService
    {
        private IUserBookTraceDal _userBookTraceDal;
        public UserBookTraceManager(IUserBookTraceDal userBookTraceDal)
        {
            _userBookTraceDal = userBookTraceDal;
        }

        public List<UserBookTrace> GetAll()
        {
           return _userBookTraceDal.GetAll();
        }

        public void Add(UserBookTrace userBookTrace)
        {
            _userBookTraceDal.Add(userBookTrace);
        }
    }
}
