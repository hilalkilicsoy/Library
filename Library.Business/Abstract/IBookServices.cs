using Library.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Abstract
{
    public interface IBookServices
    {
        Book Add(Book book);
        Task<Book> AddAsync(Book book);

        Book Update(Book book);
        Task<Book> UpdateAsync(Book book);

        void Delete(Book book);
        Book GetById(int id);

        Book GetByName(string Name);
        List<Book> GetList();
        List<Book> GetListCategoryId(int CategoryId);


    }
}
