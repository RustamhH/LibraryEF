using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEF_Context.Entitys
{
    public class Student : BaseEntity
    {
        public string ?FirstName { get; set; }
        public string ?LastName { get; set; }
        public int Id_Group { get; set; }
        public string? Term { get; set; }

        public ICollection<S_Card> S_Cards { get; set; }

        public Group Group { get; set; }

    }
}
