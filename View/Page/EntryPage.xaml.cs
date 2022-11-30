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
    public partial class EntryPage
    {
        public EntryPage(Worker worker)
        {
            InitializeComponent();
            AppConnect.model1db = new БарберШоп_KatEntities5();
        }

        private void AddBt_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
