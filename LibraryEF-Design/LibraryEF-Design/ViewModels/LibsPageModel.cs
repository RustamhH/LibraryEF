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
    public class LibsPageModel
    {
        public RelayCommand SaveChangesCommand { get; set; }
        public List<Lib> Libs { get; set; } = new();
        public Repository<Lib> LibRepository { get; set; } = new();

        public void SaveChanges(object? param)
        {
            try
            {
                if (LibRepository.GetAll() != null && LibRepository.GetAll().Count != 0) LibRepository.RemoveRange(LibRepository.GetAll());
                LibRepository.AddRange(Libs);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public LibsPageModel()
        {
            Libs = LibRepository.GetAll().ToList();
            SaveChangesCommand = new RelayCommand(SaveChanges);
        }
    }
}
