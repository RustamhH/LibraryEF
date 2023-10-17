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
    public class ThemesPageModel
    {
        public RelayCommand SaveChangesCommand { get; set; }
        public List<Theme> Themes { get; set; } = new();
        public Repository<Theme> ThemeRepository { get; set; } = new();

        public void SaveChanges(object? param)
        {
            try
            {
                if (ThemeRepository.GetAll() != null && ThemeRepository.GetAll().Count != 0) ThemeRepository.RemoveRange(ThemeRepository.GetAll());
                ThemeRepository.AddRange(Themes);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public ThemesPageModel()
        {

            Themes = ThemeRepository.GetAll().ToList();
            SaveChangesCommand = new RelayCommand(SaveChanges);
        }
    }
}
