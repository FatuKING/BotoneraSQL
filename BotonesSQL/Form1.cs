using System.Data.SqlClient;
using static BotonesSQL.Form1;

namespace BotonesSQL
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username == "admin" & password == "hoguera")
            {
                this.Hide();

                Form2 form2 = new Form2();
                form2.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta");
            }

        }
    }
}

