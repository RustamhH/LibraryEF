using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEF_Context.Entitys
{
    public class S_Card : BaseEntity
    {
        public int Id_Student { get; set; }

        public int Id_Book { get; set; }

        public int Id_Lib { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime? DateIn { get; set; }





        public Book Book { get; set; }
        public Lib Lib { get; set; }
        public Student Student { get; set; }


    }
}
