using LibraryEF_Context.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEF_Design.ViewModels
{
    public class AuthorsPageModel
    {
        public List<Author> Authors { get; set; } = new();
        public AuthorsPageModel(List<Author> authors)
        {
            Authors=authors;
        }
    }
}
