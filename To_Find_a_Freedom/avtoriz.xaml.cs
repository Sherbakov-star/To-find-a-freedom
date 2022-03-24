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
    /// Логика взаимодействия для avtoriz.xaml
    /// </summary>
    public partial class avtoriz : Window
    {
        public avtoriz()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (login.Text == "Freedom" && pass.Password == "seeyou01")
            {
                socseti socseti = new socseti();
                socseti.Show();
                this.Close();
            }
        }
    }
}
