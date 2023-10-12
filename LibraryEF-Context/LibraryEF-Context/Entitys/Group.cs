using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEF_Context.Entitys
{
    public class Group : BaseEntity
    {
        public string ?Name { get; set; }
        public int Id_Faculty { get; set; }

        public ICollection<Student> Students { get; set; }
        public Faculty Faculty { get; set; }
    }
}
