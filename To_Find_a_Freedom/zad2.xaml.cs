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

namespace To_Find_a_Freedom
{
    /// <summary>
    /// Логика взаимодействия для zad2.xaml
    /// </summary>
    public partial class zad2 : Window
    {
        public zad2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (otvet.Text == "18")
            {
                zad1 zad1 = new zad1();
                zad1.salary = 5000;
                zad1.schet = 2;
                MessageBox.Show("Вы получили 5000 рублей");
                listzadaniy listzadaniy = new listzadaniy();
                listzadaniy.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверные данные");
            }
        }
    }
}
