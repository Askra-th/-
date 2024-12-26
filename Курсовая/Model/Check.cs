using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсовая.ModelView;

namespace Курсовая.Model
{
    class Check
    {
        public Check() { }
        public void Check1(Сarrier carrier)
        {
            carrier.Limit -= 4;
            string Code = carrier.Inspector.Replace(" ", "");
            for (int i = 0; i < 4; i++)
            {
                if (carrier.Inspector[i] != carrier.Cheking[i])
                {
                    carrier.Miss++;
                }
                else
                {
                    carrier.Right++;
                }
            }
           
            Symbols(carrier);

        }
        public void Symbols(Сarrier carrier)
        {
            string str = "";
            Random rand = new Random();
            int n = 4;
            char[] a = new char[4];

            for (int i = 0; i < n; i++)
            {
                a[i] = (char)rand.Next(0x0410, 0x44F);
                str += a[i] + " ";
            }
            carrier.Inspector = str;


        }

    }
}
