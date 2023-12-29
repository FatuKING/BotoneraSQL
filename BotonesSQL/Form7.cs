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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numeroCIF = textBox1.Text;
            string regimenFacturacion = textBox2.Text;

            ConnectionSQL connection = new ConnectionSQL();
            connection.open();

            string query = $"update CLIENTES set REGIMFACT = {regimenFacturacion} where CIF = '{numeroCIF}'";

            using (SqlCommand cmd = new SqlCommand(query, connection.getConnection()))
            {
                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se actualizaron " + rowsAffected + " fila(s) correctamente.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron filas para actualizar.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
                    this.Close();
                }
                finally
                {
                    connection.close();
                }
            }
        }
    }
}
