using LibraryEF_Context.Entitys;
using LibraryEF_Design.Commands;
using LibraryEF_Design.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LibraryEF_Design.ViewModels
{
    public class BooksPageModel
    {
        public RelayCommand SaveChangesCommand { get; set; }
        public List<Book> Books { get; set; } = new();
        public Repository<Book> BookRepository { get; set; } = new();

        public void SaveChanges(object? param)
        {
            try
            {
                if (BookRepository.GetAll() != null && BookRepository.GetAll().Count != 0) BookRepository.RemoveRange(BookRepository.GetAll());
                BookRepository.AddRange(Books);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public BooksPageModel()
        {
            Books = BookRepository.GetAll().ToList();
            SaveChangesCommand = new RelayCommand(SaveChanges);
        }
    }
}
