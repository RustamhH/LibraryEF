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
    public class T_CardsPageModel
    {
        public RelayCommand SaveChangesCommand { get; set; }
        public List<T_Card> T_Cards { get; set; } = new();
        public Repository<T_Card> T_CardsRepository { get; set; } = new();

        public void SaveChanges(object? param)
        {
            try
            {
                if (T_CardsRepository.GetAll() != null && T_CardsRepository.GetAll().Count != 0) T_CardsRepository.RemoveRange(T_CardsRepository.GetAll());
                T_CardsRepository.AddRange(T_Cards);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public T_CardsPageModel()
        {

            T_Cards = T_CardsRepository.GetAll().ToList();
            SaveChangesCommand = new RelayCommand(SaveChanges);
        }
    }
}
