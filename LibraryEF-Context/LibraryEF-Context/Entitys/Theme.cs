﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEF_Context.Entitys
{
    public class Theme : BaseEntity
    {
        public string ?Name { get; set; }
        public ICollection<Book> Books { get; set; }

    }
}
