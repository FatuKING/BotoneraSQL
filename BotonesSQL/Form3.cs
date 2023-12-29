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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var codigoVendedor = textBox2.Text;

            ConnectionSQL connection = new ConnectionSQL();
            connection.open();

            string query = $"update VENDEDORES set ACTIVO = 'f' where CODVENDEDOR = {codigoVendedor}";

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

        private void button1_Click(object sender, EventArgs e)
        {
            var nombreCorto = textBox1.Text;

            ConnectionSQL connection = new ConnectionSQL();
            connection.open();

            string query = $"select CODVENDEDOR from VENDEDORES where NOMBRECORTO = '{nombreCorto}')";

            using (SqlCommand cmd = new SqlCommand(query, connection.getConnection()))
            {
                try
                {
                    object result = cmd.ExecuteScalar();

                    MessageBox.Show("Numero de vededor: " + result.ToString());


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
