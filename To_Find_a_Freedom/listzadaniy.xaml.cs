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
    /// Логика взаимодействия для listzadaniy.xaml
    /// </summary>
    public partial class listzadaniy : Window
    {
        
        public listzadaniy()
        {
            InitializeComponent();
            
            balance.Text = zad1.salary.ToString();
            if (zad1.schet == 1 && rinok.pokupka == 0)
            {
                MessageBox.Show("Поздравляю,вы заработали 2000 рублей,давайте перейдем на черный рынок и узнаем какую информацию мы можем купить на эти деньги");
            }
        }
      
        private void zadanie1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            zad1 zad1 = new zad1();
            if (zad1.schet == 0)
            {
                
                zad1.Show();
                this.Close();
               
            }

            if (zad1.schet == 1)
            {
                MessageBox.Show("Вы уже выполнили это задание");
            }

        
        }

        private void zadanie2_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (rinok.sut == 1)
            {
                MessageBox.Show("Загляните в ноутбук");
            }
            else
            {
                if (rinok.pokupka == 0 && zad1.schet == 1)
                {
                    MessageBox.Show("Сначала приобретите информацию на черном рынке");
                }


                if (zad1.schet == 2)
                {
                    MessageBox.Show("Вы уже выполнили это задание");
                }

                if (zad1.schet == 1 && rinok.pokupka == 1)
                {
                    zad2 zad2 = new zad2();
                    zad1.schet = 2;
                    zad2.Show();
                    this.Close();

                }

                if (zad1.schet == 0)
                {
                    MessageBox.Show("Выполните сначала первое задание");
                }
            }

            
            
        }
    }
}
