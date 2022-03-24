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
    /// Логика взаимодействия для safe.xaml
    /// </summary>
    public partial class safe : Window
    {
        public safe()
        {
            InitializeComponent();
            
        }
        int a;
        
        private void n1_Click(object sender, RoutedEventArgs e)
        {
            a = 1;
        }

        private void n9_Click(object sender, RoutedEventArgs e)
        {
            if (a == 1)
            {
                a = 2;
            }
            
        }

        private void n4_Click(object sender, RoutedEventArgs e)
        {
            if (a == 2)
            {
                a = 3;
            }
        }

        private void n7_Click(object sender, RoutedEventArgs e)
        {
            if (a == 3)
            {
                a = 4;
                open();
            }
        }

        public void open()
        {
            if (a == 4)
            {
                end end = new end();
                end.Show();
                this.Close();
            }
        }

        
    }
}
