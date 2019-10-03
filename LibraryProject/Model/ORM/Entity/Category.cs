using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Model.ORM.Entity
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}
