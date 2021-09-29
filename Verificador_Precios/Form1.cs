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
            label4.ForeColor = ColorTranslator.FromHtml("#FFD859");
            label5.ForeColor = ColorTranslator.FromHtml("#FFD859");

            pictureBox1.Location = new Point(this.Width / 2 - pictureBox1.Width / 2, this.Height / 4 - pictureBox1.Height);
            label1.Location = new Point(this.Width / 2 - label1.Width / 2, this.Height / 3 - pictureBox1.Height / 3);
            label3.Location = new Point(this.Width / 2 - label3.Width / 2, this.Height / 3 - pictureBox1.Height / 3 + label1.Height);
            pictureBox2.Location = new Point(this.Width / 2 - pictureBox2.Width / 2, this.Height / 2 + pictureBox1.Height);
            pictureBox3.Location = new Point(this.Width / 5 - pictureBox3.Width / 2, this.Height / 2 - pictureBox3.Height / 2);
            label4.Location = new Point(this.Width / 2 - pictureBox3.Width / 2 - 30, this.Height / 2 - pictureBox3.Height / 2 - 60);
            label2.Location = new Point(this.Width / 2 - pictureBox3.Width / 2 - 30, this.Height / 2 - label4.Height);

            PriceWindowVisible(false);
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
                        MainWindowVisible(false);
                        PriceWindowVisible(true);

                        label2.Text = $"{result.GetString(0)}\n" +
                            $"Precio: ${result.GetString(1)}";
                        pictureBox3.ImageLocation = result.GetString(2);
                        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

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
                MainWindowVisible(true);
                PriceWindowVisible(false);
            }
        }

        private void MainWindowVisible(bool option)
        {
            pictureBox1.Visible = option;
            label1.Visible = option;
            label3.Visible = option;
            pictureBox2.Visible = option;
        }

        private void PriceWindowVisible(bool option)
        {
            pictureBox3.Visible = option;
            label4.Visible = option;
            label2.Visible = option;
            label5.Visible = option;
        }
    }
}