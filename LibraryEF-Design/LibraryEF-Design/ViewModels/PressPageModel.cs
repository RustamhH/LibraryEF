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
    public class PressPageModel
    {
        public RelayCommand SaveChangesCommand { get; set; }
        public List<Press> Press { get; set; } = new();
        public Repository<Press> PressRepository { get; set; } = new();

        public void SaveChanges(object? param)
        {
            try
            {
                if (PressRepository.GetAll() != null && PressRepository.GetAll().Count != 0) PressRepository.RemoveRange(PressRepository.GetAll());
                PressRepository.AddRange(Press);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public PressPageModel()
        {

            Press = PressRepository.GetAll().ToList();
            SaveChangesCommand = new RelayCommand(SaveChanges);
        }
    }
}
