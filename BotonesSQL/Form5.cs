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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numeroTicket = textBox1.Text;

            ConnectionSQL connection = new ConnectionSQL();
            connection.open();

            string query = $"select CIF from CLIENTES where CODCLIENTE = (select CODCLIENTE from TIQUETSCAB where NUMERO = {numeroTicket})";

            using (SqlCommand cmd = new SqlCommand(query, connection.getConnection()))
            {
                try
                {
                    object result = cmd.ExecuteScalar();

                    MessageBox.Show("Numero de DNI actual: " + result.ToString());


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

        private void button2_Click(object sender, EventArgs e)
        {
            string numeroTicket = textBox1.Text;
            string numeroDNI = textBox2.Text;

            ConnectionSQL connection = new ConnectionSQL();
            connection.open();

            string query = $"update CLIENTES set CIF = '{numeroDNI}' where CODCLIENTE = (select CODCLIENTE from TIQUETSCAB where NUMERO = {numeroTicket})";

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

