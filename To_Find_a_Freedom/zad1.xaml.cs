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
    /// Логика взаимодействия для zad1.xaml
    /// </summary>
    public partial class zad1 : Window
    {
        public static int salary = 0;
        public static int schet = 0;
        public zad1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (otvet.Text == "Sam")
            {
                salary = 2000;
                MessageBox.Show("Вы получили 2000 рублей");
                schet = 1;
                listzadaniy listzadaniy = new listzadaniy();
                listzadaniy.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Не правильные данные");
            }
        }
    }
}
