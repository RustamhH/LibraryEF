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
    public class MainViewModel
    {
        // frame
        private Frame currentFrame;
        
        // commands
        public RelayCommand? CloseAppCommand { get; set; }
        public RelayCommand? OpenAuthorsTableCommand { get; set; }
        public RelayCommand? OpenBooksTableCommand { get; set; }
        public RelayCommand? OpenCategoriesTableCommand { get; set; }
        public RelayCommand? OpenDepartmentsTableCommand { get; set; }
        public RelayCommand? OpenFacultiesTableCommand { get; set; }
        public RelayCommand? OpenGroupsTableCommand { get; set; }
        public RelayCommand? OpenLibsTableCommand { get; set; }
        public RelayCommand? OpenPressTableCommand { get; set; }
        public RelayCommand? OpenS_CardsTableCommand { get; set; }
        public RelayCommand? OpenStudentsTableCommand { get; set; }
        public RelayCommand? OpenT_CardsTableCommand { get; set; }
        public RelayCommand? OpenTeachersTableCommand { get; set; }
        public RelayCommand? OpenThemesTableCommand { get; set; }
        

        // functions

        public void CloseCommand(object? param)
        {
            App.Current.MainWindow.Close();
        }
        public void OpenAuthorsTable(object?param)
        {
            currentFrame.Content = new AuthorsPage();
        }

        public void OpenBooksTable(object? param)
        {
            currentFrame.Content = new BooksPage();
        }

        public void OpenCategoriesTable(object? param)
        {
            currentFrame.Content = new CategoriesPage();
        }

        public void OpenDepartmentsTable(object? param)
        {
            currentFrame.Content = new DepartmentsPage();
        }
        public void OpenFacultiesTable(object? param)
        {
            currentFrame.Content = new FacultiesPage();
        }
        public void OpenGroupsTable(object? param)
        {
            currentFrame.Content = new GroupsPage();
        }
        public void OpenLibsTable(object? param)
        {
            currentFrame.Content = new LibsPage();
        }
        public void OpenPressTable(object? param)
        {
            currentFrame.Content = new PressPage();
        }
        public void OpenS_CardsTable(object? param)
        {
            currentFrame.Content = new S_CardsPage();
        }
        public void OpenStudentsTable(object? param)
        {
            currentFrame.Content = new StudentsPage();
        }
        public void OpenT_CardsTable(object? param)
        {
            currentFrame.Content = new T_CardsPage();
        }
        public void OpenTeachersTable(object? param)
        {
            currentFrame.Content = new TeachersPage();
        }
        public void OpenThemesTable(object? param)
        {
            currentFrame.Content = new ThemesPage();
        }



        public MainViewModel(Frame frame)
        {
            currentFrame = frame;
            CloseAppCommand = new(CloseCommand);
            OpenAuthorsTableCommand = new(OpenAuthorsTable);
            OpenBooksTableCommand = new(OpenBooksTable);
            OpenCategoriesTableCommand = new(OpenCategoriesTable);
            OpenDepartmentsTableCommand = new(OpenDepartmentsTable);
            OpenFacultiesTableCommand = new(OpenFacultiesTable);
            OpenGroupsTableCommand = new(OpenGroupsTable);
            OpenLibsTableCommand = new(OpenLibsTable);
            OpenPressTableCommand = new(OpenPressTable);
            OpenS_CardsTableCommand = new(OpenS_CardsTable);
            OpenStudentsTableCommand = new(OpenStudentsTable);
            OpenT_CardsTableCommand = new(OpenT_CardsTable);
            OpenTeachersTableCommand = new(OpenTeachersTable);
            OpenThemesTableCommand = new(OpenThemesTable);
            
        }
    }
}
