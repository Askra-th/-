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

namespace Курсовая
{
    /// <summary>
    /// Логика взаимодействия для Итоги.xaml
    /// </summary>
    public partial class Итоги : Window
    {
        public Итоги(int miss, string time)
        {
            InitializeComponent();
            res1.Text = Convert.ToString(miss);
            res2.Text = Convert.ToString(time);
        }
        public Итоги(int miss, string time,int time1)
        {
            InitializeComponent();
            if (miss !> 100 || time1 !>= 1000)
            {
                res1.Text = Convert.ToString(miss);
                res2.Text = Convert.ToString(time);
            }
            else
            {
                res1.Text = ("Stop");
                res2.Text = ("Stop");
            }
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WindowCollection windows = Application.Current.Windows; //доступ ко всем окнам
            foreach (Window window in windows)
            {
                window.Close();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }
    }
}
