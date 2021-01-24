using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WpfAbsenceApp
{
    class ADO
    {
        // Declaration des objets sql

        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();

        // Declaration de la methode connecter

        public void CONNECTER()
        {
            if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
            {
                con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=ExportDatabase;Integrated Security=True";
                con.Open();
            }
        }


        // Declaration de la methode deconnecter


        public void DECONNECTER()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

    }
}
