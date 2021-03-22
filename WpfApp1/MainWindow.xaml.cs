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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Database1Entities db;
        public MainWindow()
        {
            InitializeComponent();
        }
        public int a;

        private void Password_Click(object sender, RoutedEventArgs e)
        {
  
            new Window1().ShowDialog();
            string x = Window1.pass;
            MessageBox.Show("Ваш пароль сгенерирован  " + x );
            Pasword.Password = x;
        }
        Window1 win = new Window1();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            db = new Database1Entities();
            Table ta = new Table();
            ta.Login = Login.Text;
            ta.Pasword = Pasword.Password;
            MessageBox.Show("Пользователь зарегистрирован");
            db.Table.Add(ta);
            db.SaveChanges();
        }
    }
}
