using KatBarberShop.ApplocationData;
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
using KatBarberShop.Model;

namespace KatBarberShop.View.Page
{
    /// <summary>
    /// Логика взаимодействия для ServicePage.xaml
    /// </summary>
    public partial class ServicePage
    {
        public ServicePage()
        {
            InitializeComponent();
            serviceList.ItemsSource = AppConnect.model1db.Service.ToList();
        }
    }
}
