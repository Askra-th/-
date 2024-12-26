using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using Курсовая.ModelView;

namespace Курсовая
{
    public partial class Window1 : Window
    {

    Сarrier сarrier3 = new Сarrier();
    public Window1(string title)
        {    
            InitializeComponent();
            Miss.Text = "0";
            Title = title;
            this.DataContext = this;
        }
        public void Start_1( Сarrier carrier)
        {
            OUT.Text = carrier.Inspector;
            timer.Text = carrier.Time;
            сarrier3.Inspector = carrier.Inspector;
        }
         public void Out_Time(Сarrier str, Stopwatch sw)
        {
            timer.Text = str.Time;
            сarrier3.Time = str.Time;
            if (сarrier3.Limit == 4)
            {
                sw.Stop();
                End();
                sw.Restart();
            }
                
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (INPUT.Text.Length == 4)
            {
                Check();
                this.Symbols();
                OUT.Text = сarrier3.Inspector;
                INPUT.Clear();
                End();
            }

        }
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Итоги window = new Итоги(сarrier3.Miss, сarrier3.Time);
            Restart();
        }
        private void Symbols()
        {
            сarrier3.Inspector = "";
            Random rand = new Random();
            int n = 4;
            char[] a = new char[4];

            for (int i = 0; i < n; i++)
            {
                a[i] = (char)rand.Next(0x0410, 0x44F);
                сarrier3.Inspector += a[i] + " ";
            }

        }
        private void Origin()
        {
            сarrier3.Miss = 0;
            сarrier3.Limit = 104;
            Miss.Text = "0";
            timer.Text= "00:00:00";
            OUT.Text="";
        }
        private void Restart()
        {
            this.Symbols();
            OUT.Text = сarrier3.Inspector;
        }
        private void End() 
        {
            сarrier3.Limit -= 4;
            if (сarrier3.Limit == 0)
            {
                Итоги window = new Итоги(сarrier3.Miss, timer.Text);
                Origin();
                window.ShowDialog();
                Restart();
            }
         

        }
        private void End(int time)
        {
                Итоги window = new Итоги(сarrier3.Miss, timer.Text,time);
                Origin();
                window.ShowDialog();
                Restart();
        }
        private void Check()
        {
            string inspector = сarrier3.Inspector.Replace(" ", "");
            string checking = INPUT.Text;
            for (int i = 0; i < 4; i++)
            {
                if (inspector[i] != checking[i])
                {
                    сarrier3.Miss++;
                }
            }
            Miss.Text=Convert.ToString(сarrier3.Miss);
        }
        
       
    }
}

    

