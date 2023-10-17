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
    public class FacultiesPageModel
    {
        public RelayCommand SaveChangesCommand { get; set; }
        public List<Faculty> Faculties { get; set; } = new();
        public Repository<Faculty> FacultyRepository { get; set; } = new();

        public void SaveChanges(object? param)
        {
            try
            {
                if (FacultyRepository.GetAll() != null && FacultyRepository.GetAll().Count != 0) FacultyRepository.RemoveRange(FacultyRepository.GetAll());
                FacultyRepository.AddRange(Faculties);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public FacultiesPageModel()
        {

            Faculties = FacultyRepository.GetAll().ToList();
            SaveChangesCommand = new RelayCommand(SaveChanges);
        }
    }
}
