using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;

namespace BotonesSQL
{
    internal class ConnectionSQL
    {
        string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=DBFREST;Integrated Security=True;";
        //string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=DBFREST;User ID=sa;Password=masterkey;";
        public SqlConnection connectionDB = new SqlConnection();

        public ConnectionSQL ()
        {
           connectionDB.ConnectionString = connectionString ;
        }

        public void open()
        {
            try
            {
                connectionDB.Open();
            }
            catch (Exception ex) {
                MessageBox.Show("Error al intentar conectar con la base de datos" + ex.Message);
            }
        }

        public void close()
        {
            connectionDB?.Close();
        }

        internal SqlConnection getConnection()
        {
            return connectionDB;
        }
    }
}
