using Library.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Entity.Concrete
{
    public class Category:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

       

        
    }
}
