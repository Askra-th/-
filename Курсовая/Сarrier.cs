using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая.ModelView
{
    public class Сarrier/*: INotifyPropertyChanged*/
    {
        //public event PropertyChangedEventHandler PropertyChanged;
        //private void OnPropertyChanged(string propertyName)
        //{
        //    if (PropertyChanged != null)
        //    {
        //        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}
        //private string _Time;
        //public string ImageFullPath
        //{
        //    get { return _Time; }
        //    set
        //    {
        //        _Time = value;
        //        OnPropertyChanged("Time");
        //    }
        //}
        public Window1 Window { get; set; }

        public string Time { get; set; }
        public int Miss { get; set; }
        public int Right { get; set; }
        public string Inspector { get; set; }
        public string Cheking { get; set; }
        public int Limit { get; set; }
        public void Carrier(string time, int miss, int right, int limit)
        {
            Time = time;
            Miss = miss;
            Right = right;
            Limit = limit;
        }
        public void CarrierCheck(string inspector, string cheking)
        {
            Inspector = inspector;
            Cheking = cheking;
        }
        public void CarrierWin(Window1 window)
        {
            Window = window;
        }
    }
}
