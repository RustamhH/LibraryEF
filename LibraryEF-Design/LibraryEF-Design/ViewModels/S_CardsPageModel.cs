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
    public class S_CardsPageModel
    {
        public RelayCommand SaveChangesCommand { get; set; }
        public List<S_Card> S_Cards { get; set; } = new();
        public Repository<S_Card> S_CardsRepository { get; set; } = new();

        public void SaveChanges(object? param)
        {
            try
            {
                if (S_CardsRepository.GetAll() != null && S_CardsRepository.GetAll().Count != 0) S_CardsRepository.RemoveRange(S_CardsRepository.GetAll());
                S_CardsRepository.AddRange(S_Cards);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public S_CardsPageModel()
        {

            S_Cards = S_CardsRepository.GetAll().ToList();
            SaveChangesCommand = new RelayCommand(SaveChanges);
        }
    }
}
