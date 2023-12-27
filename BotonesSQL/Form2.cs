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
using System.Data.SqlClient;

namespace BotonesSQL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionSQL connection = new ConnectionSQL();
            connection.open();

            string query = "DELETE FROM SETUP WHERE TREE IS NOT NULL";

            using (SqlCommand cmd = new SqlCommand(query, connection.getConnection()))
            {
                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se eliminaron " + rowsAffected + " fila(s) correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron filas para eliminar.");
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConnectionSQL connection = new ConnectionSQL();
            connection.open();

            string query = "update TIQUETSCAB set NUMEROFISCAL = -1 where NUMEROFISCAL = 0 and N = 'B'";

            using (SqlCommand cmd = new SqlCommand(query, connection.getConnection()))
            {
                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se eliminaron " + rowsAffected + " fila(s) correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron filas para eliminar.");
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

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.ShowDialog();
        }
    }
}
