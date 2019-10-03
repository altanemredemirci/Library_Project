using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Model.ORM.Entity
{
    public class Book:BaseEntity
    {
        public string BookName { get; set; }
        public string BookDescription { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public int AppUserID { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
