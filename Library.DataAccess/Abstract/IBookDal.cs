using Library.Core.DataAccess;
using Library.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.DataAccess.Abstract
{
    public interface IBookDal: IEntityRepository<Book>
    {
    }
}
