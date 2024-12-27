using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая.ModelView
{
    public class Сarrier
    {
        public string Time { get; set; }
        public int Miss { get; set; }
        public int Right { get; set; }
        public string Inspector { get; set; }
        public string Cheking { get; set; }
        public int Limit { get; set; } = 104;
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
    }
}
