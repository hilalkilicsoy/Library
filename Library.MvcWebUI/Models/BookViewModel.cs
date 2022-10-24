using Library.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.MvcWebUI.Models
{
    public class BookViewModel
    {
      public Book Book { get; set; }

       public List<Book> Books { get; set; }
    }
}

