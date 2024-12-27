using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Threading;
using System.CodeDom;
using System.Data;
namespace Курсовая.ModelView
{


    class Out_
    {

        Conection conection = new Conection();
        Сarrier сarrier = new Сarrier();

        public Сarrier END()
        {

            
                conection.OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM Trainer ORDER BY Tr_ID DESC", conection.GetConnection());
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    сarrier.Time = reader["Time1"].ToString();
                    сarrier.Miss = Convert.ToInt32(reader["Missed1"]);
                    сarrier.Right = Convert.ToInt32(reader["Right1"]);
                }
                conection.ClosedConnection();
            
                return сarrier;
            

        }
        public void INPUT(Сarrier сarrier2)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string time = сarrier2.Time;
            int miss = сarrier2.Miss;
            int right1 = 100 - сarrier2.Miss;
            
                conection.OpenConnection();
                string SqlQuareString = $"insert into Trainer(Time1, Missed1, Right1) values ('{time}',{miss},{right1})";// тут нужно в скобках values переменные
                SqlCommand command = new SqlCommand(SqlQuareString, conection.GetConnection());
                command.Parameters.AddWithValue("Time1", time);
                command.Parameters.AddWithValue("Missed1", miss);
                command.Parameters.AddWithValue("right1", right1);
                command.ExecuteNonQuery();
                conection.ClosedConnection();
           
          
        }


    }
}
