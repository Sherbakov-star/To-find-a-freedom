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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace To_Find_a_Freedom
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //DoubleAnimation buttonAnimation = new DoubleAnimation();
            //buttonAnimation.From = z1.ActualWidth;
            //buttonAnimation.To = 150;
            //buttonAnimation.Duration = TimeSpan.FromSeconds(3);
            //z1.BeginAnimation(Button.WidthProperty, buttonAnimation);
            
        }
        int a = 1;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           

            if (a == 1)
            {
                dialog dialog = new dialog();
                dialog.ShowDialog();
                sob.Text = "";
                a = 0;
            }
            else
            {
                avtoriz avtoriz = new avtoriz();
                avtoriz.Show();
            }
            

        }


        private void z2_Click(object sender, RoutedEventArgs e)
        {
            call.Text = "";
            listzadaniy listzadaniy = new listzadaniy();
            listzadaniy.Show();
        }

        private void z3_Click(object sender, RoutedEventArgs e)
        {
            rinok rinok = new rinok();
            rinok.Show();
        }

        private void z4_Click(object sender, RoutedEventArgs e)
        {
            safe safe = new safe();
            safe.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("БАН");
            menu menu = new menu();
            menu.Show();
            this.Close();
        }
    }
}
