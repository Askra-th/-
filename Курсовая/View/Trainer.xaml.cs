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
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        DispatcherTimer dt = new DispatcherTimer(); // класс для создание таймера
        Stopwatch sw = new Stopwatch(); //класс для получение прошедшего времени
        string currentTime = string.Empty;

        


    public Window1(string title, Сarrier carrier)
        {   
  
            InitializeComponent();

            Symbols();
            dt.Start();
            sw.Start();
            //dt.Tick += new EventHandler(dt_Tick);
            dt.Interval = new TimeSpan(0, 0, 0, 0, 1);
            OUT.Text = carrier.Inspector; 
            Miss.Text = "0";
            Title = title;
            timer.Text = carrier.Time;
            
            this.DataContext = this;
           

        }
        //void dt_Tick(object sender, EventArgs e)
        //{
        //    if (sw.IsRunning) //свойство, если таймер идёт
        //    {
        //        TimeSpan ts = sw.Elapsed;
        //        currentTime = String.Format("{0:00}:{1:00}:{2:00}",
        //        ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
        //        if (ts.Minutes >= 1000)
        //        {

        //            End(ts.Minutes);
        //        }
        //        Time= currentTime;
        //        timer.Text = сarrier.Time;

        //    }
        //}

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (INPUT.Text.Length == 4)
            {
                Check();
                this.Symbols();
                OUT.Text = Code;
                INPUT.Clear();
                End();
            }

        }
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Итоги window = new Итоги(Mistakes, timer.Text);

            Restart();
        }
        private string Code { get; set; }
        private static int Mistakes { get; set; } = 0;
        private static int Limit { get; set; } = 100;
        private void Symbols()
        {
            Code = "";
            Random rand = new Random();
            int n = 4;
            char[] a = new char[4];

            for (int i = 0; i < n; i++)
            {
                a[i] = (char)rand.Next(0x0410, 0x44F);
                Code += a[i] + " ";
            }

        }
        private void Origin()
        {
            sw.Stop();
            
            Mistakes = 0;
            Limit = 100;
            Miss.Text = "0";
            timer.Text= "00:00:00";
            OUT.Text="";
        }
        private void Restart()
        {
            this.Symbols();
            OUT.Text = Code;
            sw.Restart();
        }
        private void End() 
        {
            Limit -= 4;
            if (Limit == 0)
            {
                Итоги window = new Итоги(Mistakes,timer.Text);
                Origin();
                window.ShowDialog();
                Restart();
                
            }
         

        }
        private void End(int time)
        {
            
                Итоги window = new Итоги(Mistakes,timer.Text,time);
                Origin();
                window.ShowDialog();
                Restart();

            


        }
        private void Check()
        {
            string inspector = Code.Replace(" ", "");
            string checking = INPUT.Text;

            for (int i = 0; i < 4; i++)
            {
                if (inspector[i] != checking[i])
                {
                    Mistakes++;
                }
            }
            Miss.Text=Convert.ToString(Mistakes);

        }
        
       
    }
}

    

