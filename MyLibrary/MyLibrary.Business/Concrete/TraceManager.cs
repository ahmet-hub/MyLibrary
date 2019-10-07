using MyLibrary.Business.Abstract;
using MyLibrary.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Business.Concrete
{
   public class TraceManager:ITraceService
    {
        private ITraceDal _traceDal;
        public TraceManager(ITraceDal traceDal)
        {
            _traceDal = traceDal;
        }
    }
}
