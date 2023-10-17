using LibraryEF_Context.Entitys;
using LibraryEF_Design.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibraryEF_Design.Views
{
    /// <summary>
    /// Interaction logic for AuthorsPage.xaml
    /// </summary>
    public partial class AuthorsPage : Page
    {
        public AuthorsPage()
        {
            InitializeComponent();
            DataContext = new AuthorsPageModel();
            datagrid.Items.Clear();
        }

        
    }
}
