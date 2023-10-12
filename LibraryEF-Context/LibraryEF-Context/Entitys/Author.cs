using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEF_Context.Entitys
{
    public class Author : BaseEntity
    {
        public string ?FirstName { get; set; }
        public string? LastName { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
