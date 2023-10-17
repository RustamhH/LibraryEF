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
    public class GroupsPageModel
    {
        public RelayCommand SaveChangesCommand { get; set; }
        public List<Group> Groups { get; set; } = new();
        public Repository<Group> GroupRepository { get; set; } = new();

        public void SaveChanges(object? param)
        {
            try
            {
                if (GroupRepository.GetAll() != null && GroupRepository.GetAll().Count != 0) GroupRepository.RemoveRange(GroupRepository.GetAll());
                GroupRepository.AddRange(Groups);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public GroupsPageModel()
        {

            Groups = GroupRepository.GetAll().ToList();
            SaveChangesCommand = new RelayCommand(SaveChanges);
        }
    }
}
