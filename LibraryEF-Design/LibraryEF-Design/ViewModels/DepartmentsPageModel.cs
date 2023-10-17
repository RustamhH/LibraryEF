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
    public class DepartmentsPageModel
    {
        public RelayCommand SaveChangesCommand { get; set; }
        public List<Department> Departments { get; set; } = new();
        public Repository<Department> DepartmentRepository { get; set; } = new();

        public void SaveChanges(object? param)
        {
            try
            {
                if (DepartmentRepository.GetAll() != null && DepartmentRepository.GetAll().Count != 0) DepartmentRepository.RemoveRange(DepartmentRepository.GetAll());
                DepartmentRepository.AddRange(Departments);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public DepartmentsPageModel()
        {

            Departments = DepartmentRepository.GetAll().ToList();
            SaveChangesCommand = new RelayCommand(SaveChanges);
        }
    }
}
