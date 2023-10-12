using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEF_Context.Entitys
{
    public class Teacher : BaseEntity
    {
        public string ?FirstName { get; set; }
        public string ?LastName { get; set; }
        public int Id_Dep { get; set; }

        public ICollection<T_Card> T_Cards { get; set; }

        public Department Department { get; set; }
    }
}
