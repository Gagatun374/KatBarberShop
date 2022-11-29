using KatBarberShop.View.Page;
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
using System.Windows.Shapes;

namespace KatBarberShop.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindows.xaml
    /// </summary>
    public partial class MainWindows : Window
    {
        public MainWindows()
        {
            InitializeComponent();
        }

       

        private void ExitTb_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindows registrationwindows = new RegistrationWindows();
            registrationwindows.Show();
            this.Close();
        }

        private void ServiceTb_Click(object sender, RoutedEventArgs e)
        {
            ServicePage servicePage = new ServicePage();
            MainFrame.Navigate(servicePage);
        }

        private void EmployeesTb_Click(object sender, RoutedEventArgs e)
        {
            EmployeesPage employeesPage = new EmployeesPage();
            MainFrame.Navigate(employeesPage);
        }

        private void EntryTb_Click(object sender, RoutedEventArgs e)
        {
            EntryPage entryPage = new EntryPage();
            MainFrame.Navigate(entryPage);
        }

        private void ServiceTb_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
