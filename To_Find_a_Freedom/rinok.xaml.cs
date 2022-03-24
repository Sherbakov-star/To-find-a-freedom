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
    /// Логика взаимодействия для rinok.xaml
    /// </summary>
    public partial class rinok : Window
    {
        public static int pokupka = 0;
        public static int sut = 0;
        public rinok()
        {
            InitializeComponent();
            //string a = logandpass.Text;
            //string a1 = two.Text;
            //int b = 1;
            //kup1.Opacity = b;

            //string c = desh.Text;
            //string c1 = k5.Text;
            //int d = 1;
            //kup2.Opacity = d;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (zad1.salary == 2000)
            {
                zad1.salary = 0;
                pokupka = 1;
                MessageBox.Show("Логин:Freedom Пароль:seeyou01");
                logandpass.Text = "";
                two.Text = "";
                kup1.Opacity = 0;
                MessageBox.Show("Загляните в ноутбук и найдите следы своего брата");
                sut = 1;
            }
            else
            {
                MessageBox.Show("Недостаточно средств");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (zad1.salary == 5000)
            {
                zad1.salary = 0;
                socseti2 socseti2 = new socseti2();
                socseti2.Show();
                this.Close();
                desh.Text = "";
                k5.Text = "";
                kup2.Opacity = 0;

            }
            else
            {
                MessageBox.Show("Недостаточно средств");
            }
        }
    }
}
