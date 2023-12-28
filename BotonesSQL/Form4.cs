using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotonesSQL
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numeroTicket = textBox1.Text;
            string nombreCliente = textBox2.Text;

            ConnectionSQL connection = new ConnectionSQL();
            connection.open();

            string query = $"update CLIENTES set NOMBRECLIENTE = '{nombreCliente}' where CODCLIENTE = (select CODCLIENTE from TIQUETSCAB where NUMERO = {numeroTicket})";

            using (SqlCommand cmd = new SqlCommand(query, connection.getConnection()))
            {
                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se actualizaron " + rowsAffected + " fila(s) correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron filas para actualizar.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
                }
                finally
                {
                    connection.close();
                }
            }
        }
    }
}
