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
    public class StudentsPageModel
    {
        public RelayCommand SaveChangesCommand { get; set; }
        public List<Student> Students { get; set; } = new();
        public Repository<Student> StudentRepository { get; set; } = new();

        public void SaveChanges(object? param)
        {
            try
            {
                if (StudentRepository.GetAll() != null && StudentRepository.GetAll().Count != 0) StudentRepository.RemoveRange(StudentRepository.GetAll());
                StudentRepository.AddRange(Students);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public StudentsPageModel()
        {
            Students = StudentRepository.GetAll().ToList();
            SaveChangesCommand = new RelayCommand(SaveChanges);
        }
    }
}
