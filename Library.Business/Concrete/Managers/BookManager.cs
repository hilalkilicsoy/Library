using Library.Business.Abstract;
using Library.DataAccess.Abstract;
using Library.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Concrete.Managers
{
    public class BookManager : IBookServices

    {

        IBookDal _bookDal;
        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }
        public Book Add(Book book)
        {
            return _bookDal.Add(book);
        }

        public async Task<Book> AddAsync(Book book)
        {
            return await _bookDal.AddAsync(book);
        }

        public void Delete(Book book)
        {
             _bookDal.Delete(book);
        }

        public Book GetById(int id)
        {
            return _bookDal.Get(d => d.Id == id);
        }

        public Book GetByName(string Name)
        {
            return _bookDal.Get(d => d.Name == Name);
        }

        public List<Book> GetList()
        {
            return _bookDal.GetAll();
        }

        public List<Book> GetListCategoryId(int categoryId)
        {
            return _bookDal.GetAll(d => d.CategoryId == categoryId);
        }

        public Book Update(Book book)
        {
            return _bookDal.Update(book);
        }

        public async Task<Book> UpdateAsync(Book book)
        {
            return await _bookDal.UpdateAsync(book);
        }
    }
}
