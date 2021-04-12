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

namespace WpfApp11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GN.ItemsSource = AppData.db.gender.ToList();
            GN.DisplayMemberPath = "Title";
        }

        private void FN_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void Btn_AddPerson_Click(object sender, RoutedEventArgs e)
        {
            users person = new users()
            {
                FristName = FN.Text,
                LastName = LN.Text,
                Patronimic = PN.Text,
                PhoneNumber = TN.Text
            };
            var personGender = GN.SelectedItem as gender;
            person.gender1 = personGender;
            AppData.db.users.Add(person);
            AppData.db.SaveChanges();
            MessageBox.Show("Success");
        }
    }
}
