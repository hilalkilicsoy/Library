using Library.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Entity.Concrete
{
    public class Book:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        public bool IsActive { get; set; }
    
    }
}
