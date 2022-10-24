using Library.Core.DataAccess.EntityFrameworkCore;
using Library.DataAccess.Abstract;
using Library.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfBookDal : EfEntityRepositoryBase<Book , LibraryDbContext> , IBookDal
    {
    }
}
