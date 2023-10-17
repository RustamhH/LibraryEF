using LibraryEF_Context.Contexts;
using LibraryEF_Context.Entitys;
using LibraryEF_Design.Commands;
using LibraryEF_Design.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace LibraryEF_Design.ViewModels
{
    public class AuthorsPageModel
    {
        public RelayCommand SaveChangesCommand { get; set; }
        public List<Author> Authors { get; set; } = new();
        public Repository<Author> AuthorRepository { get; set; } = new();

        public void SaveChanges(object? param)
        {
            try
            {
                if(AuthorRepository.GetAll() != null && AuthorRepository.GetAll().Count != 0) AuthorRepository.RemoveRange(AuthorRepository.GetAll());
                AuthorRepository.AddRange(Authors);
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        public AuthorsPageModel()
        {
            Authors = AuthorRepository.GetAll().ToList();
            SaveChangesCommand = new RelayCommand(SaveChanges);
        }
    }
}
