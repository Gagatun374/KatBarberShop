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
    public partial class EmployeesPage
    {
        public EmployeesPage()
        {
            InitializeComponent();
            AppConnect.model1db = new БарберШоп_KatEntities5();
            customersList.ItemsSource = AppConnect.model1db.Worker.ToList();


        }

        private void SearchBt_Click(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Удалить?","Удаление",MessageBoxButton.YesNo,MessageBoxImage.Question)==MessageBoxResult.Yes)
            {
                var worker = customersList.SelectedItem as Worker;
                AppConnect.model1db.Worker.Remove(worker);
                AppConnect.model1db.SaveChanges();
                customersList.ItemsSource = AppConnect.model1db.Worker.ToList();
            }
            
            
        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
           if(SearchTb.Text.Length == 0)
            {
                customersList.ItemsSource = AppConnect.model1db.Worker.ToList(); 

            }
            else
            {
                QQQ();
            }


        }
        private void QQQ()
        {
            var Bloody = AppConnect.model1db.Worker.ToList();
            Bloody = Bloody.Where(A => A.Name.ToLower().Contains(SearchTb.Text.ToLower())).ToList();
            customersList.ItemsSource = Bloody.OrderBy(B => B.Number).ToList();
        }

        private void EditBt_Click(object sender, RoutedEventArgs e)
        {
            Worker worker = (Worker)customersList.SelectedItem;
            FrameClass.SweepFrame.Navigate(new EntryPage(worker));
        }
    }
}
