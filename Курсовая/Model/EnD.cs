using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсовая.ModelView;

namespace Курсовая.Model
{
    class EnD
    {
        public EnD()
        {

        }
        public void Show(Сarrier сarrier)
        {

            сarrier.Miss = 0;
            сarrier.Limit = 100;
            сarrier.Miss = 0;
            сarrier.Time = "00:00:00";

        }
        public void Restart(Stopwatch sw)
        {
            sw.Start();
        }
    }
}
