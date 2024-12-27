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
        SqlConnection sqlConnection1 = new SqlConnection(@"Data Source=dbsrv\YAR2024;Initial Catalog=1111;Integrated Security=True;Trust Server Certificate=True");
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
            return sqlConnection1;
        }
    }
}
