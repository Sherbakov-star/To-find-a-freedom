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
    /// Логика взаимодействия для socseti2.xaml
    /// </summary>
    public partial class socseti2 : Window
    {
        public socseti2()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show("Идите к сейфу и введите код");
        }
    }
}
