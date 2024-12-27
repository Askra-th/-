using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//нужно
using System.Data;

namespace Курсовая.ModelView
{
    class Conection
    {
        SqlConnection sqlConnection1 = new SqlConnection(@"Data Source=DESKTOP-F61KJS2;Initial Catalog=CourseWork;Integrated Security=True;Trust Server Certificate=True");
        public void OpenConnection()
        {
            if (sqlConnection1.State == ConnectionState.Closed)
            {
                sqlConnection1.Open();
            }
        }
        public void ClosedConnection()
        {
            if (sqlConnection1.State == ConnectionState.Open)
            {
                sqlConnection1.Close();
            }
        }
        public SqlConnection GetConnection()
        {
            
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //DataTable table = new DataTable();
            //string SqlQuareString = $"insert into Trainer(Time1, Missed1, Right1) values ('',5,6)";// тут нужно в скобках values переменные
            //SqlCommand command = new SqlCommand(SqlQuareString,GetConnection());
            //conection.OpenConnection();
            return sqlConnection1;

        }
    }
}
