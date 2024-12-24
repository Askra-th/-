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

        Сarrier сarrier = new Сarrier();
        Check check = new Check();
        public Transshipment_point()
        {
            //Start();
            Window1 window = new Window1("Тренажёр");
            сarrier.CarrierWin(window);
            window.ShowDialog();

        }
        public void Start()
        {
            check.Symbols(сarrier);
        }

    }
}
