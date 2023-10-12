using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEF_Context.Entitys
{
    public class Book : BaseEntity
    {
        public string? Name { get; set; }
        public int Pages { get; set; }
        public int YearPress { get; set; }
        public int Quantity { get; set; }
        public string ?Comment { get; set; }
        public int Id_Category { get; set; }

        public int Id_Theme { get; set; }

        public int Id_Author { get; set; }

        public int Id_Press { get; set; }


        // nav props


        public Category Category { get; set; }
        public Author Author { get; set; }
        public Press Press { get; set; }
        public Theme Theme { get; set; }
        public ICollection<S_Card> S_Cards { get; set; }
        public ICollection<T_Card> T_Cards { get; set; }

    }
}
