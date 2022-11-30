using KatBarberShop.ApplocationData;
using KatBarberShop.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
        int id1 = 0;
        public EntryPage(Worker worker)
        {
            InitializeComponent();
            AppConnect.model1db = new БарберШоп_KatEntities5();
            if (worker != null ) 
            {
                worker = worker;
                DataContext = worker;
                id1 = worker.Number;
            }
        }

        private void AddBt_Click(object sender, RoutedEventArgs e)
        {
            if(NameTb.Text == "" || SurnameTb.Text == "" || DataTb.Text == "" || PaulTb.Text == "")
            {
                MessageBox.Show("Поля пусты");


            }
            else
            {
                DateTime abc = Convert.ToDateTime(DataTb.Text);
                Worker worker = new Worker()
                {
                    Name = NameTb.Text,
                    Surname = SurnameTb.Text,
                    Data = abc,
                    Paul= PaulTb.Text,
                };
                Worker zzz = AppConnect.model1db.Worker.Find(id1);
                try
                {
                    if (zzz != null )
                    {
                        AppConnect.model1db.Worker.AddOrUpdate(worker);
                        
                    }
                    else
                    {
                        AppConnect.model1db.Worker.Add(worker);
                    }
                    AppConnect.model1db.SaveChanges();
                    MessageBox.Show("Сохранено");

                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
