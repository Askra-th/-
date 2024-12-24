using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using Курсовая.ModelView;

namespace Курсовая.Model
{
    internal class TIMER
    {
        DispatcherTimer dt = new DispatcherTimer(); // класс для создание таймера
        Stopwatch sw = new Stopwatch(); //класс для получение прошедшего времени
        string currentTime = string.Empty;
        public ref int DDD { get; set; }
        




        public TIMER()
        {
            sw.Start();
            dt.Start();
            dt.Tick += new EventHandler(dt_Tick);
            dt.Interval = new TimeSpan(0, 0, 0, 0, 1);


        }
        public void Stop() 
        {
            sw.Stop();
        }
        public void Start() 
        {
            sw.Start();
        }
        public void Restart()
        {
            sw.Restart();
        }
        void dt_Tick(object sender, EventArgs e)
        {
            if (sw.IsRunning) //свойство, если таймер идёт
            {
                TimeSpan ts = sw.Elapsed;
                currentTime = String.Format("{0:00}:{1:00}:{2:00}",
                ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                if (ts.Minutes >= 1000)
                {
                }
               



            }
        }
       
    }
}
