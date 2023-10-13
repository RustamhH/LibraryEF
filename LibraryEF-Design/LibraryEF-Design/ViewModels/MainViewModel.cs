using LibraryEF_Context.Contexts;
using LibraryEF_Design.Commands;
using LibraryEF_Design.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace LibraryEF_Design.ViewModels
{
    public static class cont
    { 
       public static LibraryDbContext dbContext { get; set; } = new();
    }
    public class MainViewModel
    {
        public RelayCommand? CloseAppCommand { get; set; }



        public RelayCommand? OpenAuthorsTableCommand { get; set; }


        private Frame currentFrame;


        public void CloseCommand(object? param)
        {
            App.Current.MainWindow.Close();
        }
        public void OpenAuthorsTable(object?param)
        {
            currentFrame.Content = new AuthorsPage(cont.dbContext.Authors);
        }


        public MainViewModel(Frame frame)
        {
            currentFrame = frame;
            CloseAppCommand = new(CloseCommand);
            OpenAuthorsTableCommand = new(OpenAuthorsTable);
        }
    }
}
