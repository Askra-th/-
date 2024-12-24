using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Threading;

namespace Курсовая.ModelView
{


    class Out_
    {

        Conection conection = new Conection();
        Сarrier сarrier = new Сarrier();

        public Сarrier END()
        {
            using (conection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM Trainer ORDER BY id DESC", conection.GetConnection());
                conection.OpenConnection();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    сarrier.Time = reader["Time1"].ToString();
                    сarrier.Miss = Convert.ToInt32(reader["Missed1"]);
                    сarrier.Right = Convert.ToInt32(reader["Right1"]);
                }
                return сarrier;
            }

        }

    }
}
