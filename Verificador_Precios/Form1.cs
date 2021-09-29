using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Verificador_Precios
{
    public partial class Form1 : Form
    {

        private int segundos = 0;
        private static string codigo = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#007A29");
            label1.ForeColor = ColorTranslator.FromHtml("#FFD859");
            pictureBox1.Location = new Point(this.Width / 2 - pictureBox1.Width / 2, this.Height / 4 - pictureBox1.Height);
            label1.Location = new Point(this.Width / 2 - label1.Width / 2, this.Height / 3 - pictureBox1.Height / 3);
            label3.Location = new Point(this.Width / 2 - label3.Width / 2, this.Height / 3 - pictureBox1.Height / 3 + label1.Height);
            pictureBox2.Location = new Point(this.Width / 2 - pictureBox2.Width / 2, this.Height / 2 + pictureBox1.Height);
            label2.Location = new Point(this.Width / 2 - label2.Width / 2, this.Height / 2 + pictureBox1.Height / 3);
            label2.Visible = false;
            pictureBox3.Location = new Point(label2.Width, this.Height / 2 + pictureBox1.Height / 3 - label2.Height);
            pictureBox3.Visible = false;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    MySqlConnection servidor = new MySqlConnection(
                        "server=localhost;" +
                        "user=root;" +
                        "password=;" +
                        "database=verificador_precios;" +
                        "SSL Mode=None");

                    servidor.Open();

                    string query = "SELECT " +
                        "producto_nombre, producto_precio, producto_imagen " +
                        "FROM " +
                        "verificador_precios.productos " +
                        "WHERE " +
                        $"producto_codigo = '{codigo}';";

                    MySqlCommand commandQuery = new MySqlCommand(query, servidor);
                    MySqlDataReader result = commandQuery.ExecuteReader();

                    if (result.HasRows)
                    {
                        result.Read();
                        pictureBox1.Visible = false;
                        label1.Visible = false;
                        label3.Visible = false;
                        pictureBox2.Visible = false;
                        label2.Visible = true;
                        label2.Text = $"{result.GetString(0)}\n" +
                            $"Precio: ${result.GetString(1)}";
                        pictureBox3.ImageLocation = result.GetString(2);
                        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox3.Visible = true;

                        segundos = 0;
                        timer1.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Consulte con un empleado, el producto solicitado no fue encontrado.");
                    }
                }
                catch (Exception mysql_error)
                {
                    MessageBox.Show(mysql_error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                codigo = "";
            }
            else
            {
                codigo += e.KeyChar;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;
            if (segundos == 4)
            {
                timer1.Enabled = false;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                label1.Visible = true;
                label3.Visible = true;
                pictureBox3.Visible = false;
                label2.Text = "";
            }
        }
    }
}