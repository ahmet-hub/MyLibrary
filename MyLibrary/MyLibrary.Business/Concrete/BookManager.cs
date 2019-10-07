using MyLibrary.Business.Abstract;
using MyLibrary.DataAccess.Abstract;
using MyLibrary.Entities.Concrete;
using MyLibrary.Business.Utilities;
using System.Collections.Generic;
using FluentValidation;
using MyLibrary.Business.FluentValidation.ValidationRules;

namespace MyLibrary.Business.Concrete
{
    public class BookManager:IBookService
    {
        private IBookDal _bookDal;
        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }
       

        public void Add(Book book)
        {
           ValidationTool.Validate(new BookValidator(), book);
            _bookDal.Add(book);
        }

        public void Delete(Book book)
        {
            _bookDal.Delete(book);
        }

        public Book Get()
        {
            return _bookDal.Get(filter: p => p.Category.Id>2); //for now 
        }

        public List<Book> GetAll()
        {
            return _bookDal.GetAll();
        }

        public void Update(Book book)
        {
            ValidationTool.Validate(new BookValidator(), book);
            _bookDal.Update(book);
        }
    }
}
