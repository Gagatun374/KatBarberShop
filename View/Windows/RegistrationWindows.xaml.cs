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
using System.Windows.Shapes;

namespace KatBarberShop.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindows.xaml
    /// </summary>
    public partial class RegistrationWindows : Window
    {
       public RegistrationWindows()
        {
            InitializeComponent();
            AppConnect.model1db = new БарберШоп_KatEntities5();
        }

        private void InputTb_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                int PasswordInt = Convert.ToInt32(Passpb.Password);
                var user0bj = AppConnect.model1db.Clients.FirstOrDefault(x => x.Name == LoginTb.Text && x.Id == PasswordInt);
                if (user0bj == null)
                {
                    MessageBox.Show("Такого пользователя нету", "Ошибка при авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                else
                {
                   switch (user0bj.Id)
                    {
                        case 1:MessageBox.Show("HELLO " + user0bj.Name + "!", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                            MainWindows mainWindows = new MainWindows();
                            mainWindows.Show();
                            this.Close();
                            break;
                        default: MessageBox.Show("Данные не обнаружены", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                            break;
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error" + Ex.Message.ToString() + "Critical Error!", "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
