using LibraryEF_Context.Contexts;
using LibraryEF_Context.Entitys;
using LibraryEF_Design.Commands;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LibraryEF_Design.ViewModels
{
    public class AuthorsPageModel
    {
        public RelayCommand AddCommand { get; set; }
        public List<Author> Authors { get; set; }

        public void Add(object? param)
        {
            foreach (var item in Authors)
            {
                cont.dbContext.Add(item);
            }
            cont.dbContext.SaveChanges();
            MessageBox.Show(cont.dbContext.Authors.ToList().Count.ToString());
        }

        public AuthorsPageModel(DbSet<Author> authors)
        {
            Authors = authors.ToList();
            AddCommand = new RelayCommand(Add);
        }
    }
}
