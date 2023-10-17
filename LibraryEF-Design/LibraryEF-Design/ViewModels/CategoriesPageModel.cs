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
    public class CategoriesPageModel
    {
        public RelayCommand SaveChangesCommand { get; set; }
        public List<Category> Categories { get; set; } = new();
        public Repository<Category> CategoryRepository { get; set; } = new();

        public void SaveChanges(object? param)
        {
            try
            {
                if (CategoryRepository.GetAll() != null && CategoryRepository.GetAll().Count!=0) CategoryRepository.RemoveRange(CategoryRepository.GetAll());
                CategoryRepository.AddRange(Categories);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public CategoriesPageModel()
        {
            
            Categories = CategoryRepository.GetAll().ToList();
            SaveChangesCommand = new RelayCommand(SaveChanges);
        }
    }
}
