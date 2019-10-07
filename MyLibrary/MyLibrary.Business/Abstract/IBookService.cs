using MyLibrary.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Business.Abstract
{
    public interface IBookService
    {
        List<Book> GetAll();
        Book Get();
        void Add(Book book);
        void Delete(Book book);
        void Update(Book book);
    }
}
