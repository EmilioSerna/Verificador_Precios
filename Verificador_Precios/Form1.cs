using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        // Muchas gracias Octavio por este trucazo
        private static string connectionString = ConfigurationManager.ConnectionStrings["verificadorPreciosDB"].ConnectionString;
        private static string database = "verificador_precios";
        private static string table = "productos";

    public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#007A29");
            labelTitle.ForeColor = ColorTranslator.FromHtml("#FFD859");
            labelProductName.ForeColor = ColorTranslator.FromHtml("#FFD859");
            labelProductPrice.ForeColor = ColorTranslator.FromHtml("#FFD859");
            labelErrorTitle.ForeColor = ColorTranslator.FromHtml("#FFD859");

            pictureLogo.Location = new Point(this.Width / 2 - pictureLogo.Width / 2, this.Height / 4 - pictureLogo.Height);
            labelTitle.Location = new Point(this.Width / 2 - labelTitle.Width / 2, this.Height / 3 - pictureLogo.Height / 3);
            labelText.Location = new Point(this.Width / 2 - labelText.Width / 2, this.Height / 3 - pictureLogo.Height / 3 + labelTitle.Height);
            pictureCodebar.Location = new Point(this.Width / 2 - pictureCodebar.Width / 2, this.Height / 2 + pictureLogo.Height);
            pictureProduct.Location = new Point(this.Width / 5 - pictureProduct.Width / 2, this.Height / 2 - pictureProduct.Height / 2);
            labelProductName.Location = new Point(this.Width / 2 - pictureProduct.Width / 2 - 30, this.Height / 2 - pictureProduct.Height / 2 - 60);
            labelProductDesc.Location = new Point(this.Width / 2 - pictureProduct.Width / 2 - 30, this.Height / 2 - labelProductName.Height - 80);
            labelProductPrice.Location = new Point(this.Width / 2 - pictureProduct.Width / 2 - 30, this.Height / 2 + pictureProduct.Height / 2);
            labelErrorTitle.Location = new Point(this.Width / 2 - labelErrorTitle.Width / 2, this.Height / 4 - labelErrorTitle.Height);
            labelErrorText.Location = new Point(this.Width / 2 - labelTitle.Width / 2, this.Height / 3 - labelErrorText.Height / 2);

            PriceWindowVisible(false);
            ErrorWindowVisible(false);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    using (MySqlConnection servidor = new MySqlConnection(connectionString))
                    {
                        servidor.Open();

                        string query = "SELECT producto_nombre, producto_precio, producto_imagen FROM " +
                            $"{database}.{table} " +
                            $"WHERE producto_codigo = '{codigo}';";

                        MySqlDataReader result = new MySqlCommand(query, servidor).ExecuteReader();

                        if (result.HasRows)
                        {
                            result.Read();

                            pictureProduct.ImageLocation = result.GetString(2);
                            labelProductDesc.Text = $"{result.GetString(0)}";
                            labelProductPrice.Text = $"Precio: ${result.GetString(1)}";

                            MainWindowVisible(false);
                            ErrorWindowVisible(false);
                            PriceWindowVisible(true);

                            segundos = 0;
                            timer1.Enabled = true;
                        }
                        else
                        {
                            labelErrorText.Text = "Hubo un error al realizar el escaneo\n\n" +
                            "Inténtalo de nuevo o avisa a un\nempleadode la sucursal para\n" +
                            "solicitar ayuda";
                            MainWindowVisible(false);
                            PriceWindowVisible(false);
                            ErrorWindowVisible(true);

                            segundos = 0;
                            timer1.Enabled = true;
                        }
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
                ErrorWindowVisible(false);
            }
        }

        private void MainWindowVisible(bool option)
        {
            pictureLogo.Visible = option;
            labelTitle.Visible = option;
            labelText.Visible = option;
            pictureCodebar.Visible = option;
        }

        private void PriceWindowVisible(bool option)
        {
            pictureProduct.Visible = option;
            pictureProduct.Image = Verificador_Precios.Properties.Resources.image_placeholder;
            labelProductName.Visible = option;
            labelProductDesc.Visible = option;
            labelProductPrice.Visible = option;
        }

        private void ErrorWindowVisible(bool option)
        {
            labelErrorTitle.Visible = option;
            labelErrorText.Visible = option;
        }
    }
}