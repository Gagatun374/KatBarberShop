using KatBarberShop.ApplocationData;
using KatBarberShop.Model;
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

namespace KatBarberShop.View.Page
{
    /// <summary>
    /// Логика взаимодействия для EmployeesPage.xaml
    /// </summary>
    public partial class EmployeesPage
    {
        public EmployeesPage()
        {
            InitializeComponent();
            customersList.ItemsSource = AppConnect.model1db.Worker.ToList();


        }

        private void SearchBt_Click(object sender, RoutedEventArgs e)
        {
            MiniEmployees1 MiniEmployees1 = new MiniEmployees1();
            MiniEmployees1. Show();
            
        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
           

        }
    }
}
