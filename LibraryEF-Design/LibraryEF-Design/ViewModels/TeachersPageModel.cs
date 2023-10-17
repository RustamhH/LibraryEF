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
    public class TeachersPageModel
    {
        public RelayCommand SaveChangesCommand { get; set; }
        public List<Teacher> Teachers { get; set; } = new();
        public Repository<Teacher> TeacherRepository { get; set; } = new();

        public void SaveChanges(object? param)
        {
            try
            {
                if (TeacherRepository.GetAll() != null && TeacherRepository.GetAll().Count != 0) TeacherRepository.RemoveRange(TeacherRepository.GetAll());
                TeacherRepository.AddRange(Teachers);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public TeachersPageModel()
        {
            Teachers = TeacherRepository.GetAll().ToList();
            SaveChangesCommand = new RelayCommand(SaveChanges);
        }
    }
}
