using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using Курсовая.Model;


namespace Курсовая.ModelView
{
    class Transshipment_point
    {
        DispatcherTimer dt = new DispatcherTimer(); // класс для создание таймера
        Stopwatch sw = new Stopwatch(); //класс для получение прошедшего времени
        string currentTime = string.Empty;
        Сarrier сarrier = new Сarrier();
        Check check = new Check();
        Window1 window = new Window1("Тренажёр");
        public Transshipment_point()
        {
            Start();
           
            window.ShowDialog();
            
        }
      
        public void Start()
        {
            check.Symbols(сarrier);
            sw.Start();
            dt.Start();
            dt.Tick += new EventHandler(dt_Tick);
            dt.Interval = new TimeSpan(0, 0, 0, 0, 1);
            window.Start_1(сarrier);
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
                сarrier.Time = currentTime;
                window.Out_Time(сarrier);


            }
        }
    }


}
