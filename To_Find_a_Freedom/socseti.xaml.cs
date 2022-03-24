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
    /// Логика взаимодействия для socseti.xaml
    /// </summary>
    public partial class socseti : Window
    {
        public socseti()
        {
            InitializeComponent();

            
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show("Видимо последнее собщение было зашифрованно,нужно купить дешифратор чтобы узнать дальнейшие действия брата ");
            rinok.sut = 2;
        }
    }
}
