
namespace Verificador_Precios
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelProductDesc = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureProduct = new System.Windows.Forms.PictureBox();
            this.pictureCodebar = new System.Windows.Forms.PictureBox();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.labelText = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelProductPrice = new System.Windows.Forms.Label();
            this.labelErrorTitle = new System.Windows.Forms.Label();
            this.labelErrorText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCodebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Heebo", 120F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Khaki;
            this.labelTitle.Location = new System.Drawing.Point(137, 233);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1214, 235);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Checa el precio";
            // 
            // labelProductDesc
            // 
            this.labelProductDesc.AutoSize = true;
            this.labelProductDesc.Font = new System.Drawing.Font("Heebo", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductDesc.ForeColor = System.Drawing.Color.White;
            this.labelProductDesc.Location = new System.Drawing.Point(563, 751);
            this.labelProductDesc.Name = "labelProductDesc";
            this.labelProductDesc.Size = new System.Drawing.Size(788, 98);
            this.labelProductDesc.TabIndex = 3;
            this.labelProductDesc.Text = "Descripción del producto";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureProduct
            // 
            this.pictureProduct.Image = global::Verificador_Precios.Properties.Resources.image_placeholder;
            this.pictureProduct.Location = new System.Drawing.Point(30, 600);
            this.pictureProduct.Name = "pictureProduct";
            this.pictureProduct.Size = new System.Drawing.Size(527, 479);
            this.pictureProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureProduct.TabIndex = 4;
            this.pictureProduct.TabStop = false;
            // 
            // pictureCodebar
            // 
            this.pictureCodebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureCodebar.Image = ((System.Drawing.Image)(resources.GetObject("pictureCodebar.Image")));
            this.pictureCodebar.Location = new System.Drawing.Point(553, 496);
            this.pictureCodebar.Name = "pictureCodebar";
            this.pictureCodebar.Size = new System.Drawing.Size(288, 252);
            this.pictureCodebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCodebar.TabIndex = 2;
            this.pictureCodebar.TabStop = false;
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackgroundImage = global::Verificador_Precios.Properties.Resources.logo;
            this.pictureLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureLogo.Location = new System.Drawing.Point(313, 84);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(744, 162);
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Heebo", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.ForeColor = System.Drawing.Color.White;
            this.labelText.Location = new System.Drawing.Point(29, 385);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(1592, 118);
            this.labelText.TabIndex = 5;
            this.labelText.Text = "Pasando el código de barras bajo el sensor";
            this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Heebo", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.ForeColor = System.Drawing.Color.Khaki;
            this.labelProductName.Location = new System.Drawing.Point(564, 617);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(809, 118);
            this.labelProductName.TabIndex = 6;
            this.labelProductName.Text = "Nombre del producto";
            // 
            // labelProductPrice
            // 
            this.labelProductPrice.AutoSize = true;
            this.labelProductPrice.Font = new System.Drawing.Font("Heebo", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductPrice.ForeColor = System.Drawing.Color.Khaki;
            this.labelProductPrice.Location = new System.Drawing.Point(564, 898);
            this.labelProductPrice.Name = "labelProductPrice";
            this.labelProductPrice.Size = new System.Drawing.Size(305, 118);
            this.labelProductPrice.TabIndex = 7;
            this.labelProductPrice.Text = "Precio:";
            // 
            // labelErrorTitle
            // 
            this.labelErrorTitle.AutoSize = true;
            this.labelErrorTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelErrorTitle.Font = new System.Drawing.Font("Heebo", 120F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorTitle.ForeColor = System.Drawing.Color.Khaki;
            this.labelErrorTitle.Location = new System.Drawing.Point(1676, 167);
            this.labelErrorTitle.Name = "labelErrorTitle";
            this.labelErrorTitle.Size = new System.Drawing.Size(982, 235);
            this.labelErrorTitle.TabIndex = 8;
            this.labelErrorTitle.Text = "Lo sentimos";
            this.labelErrorTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelErrorText
            // 
            this.labelErrorText.AutoSize = true;
            this.labelErrorText.Font = new System.Drawing.Font("Heebo", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorText.ForeColor = System.Drawing.Color.White;
            this.labelErrorText.Location = new System.Drawing.Point(1874, 385);
            this.labelErrorText.Name = "labelErrorText";
            this.labelErrorText.Size = new System.Drawing.Size(546, 118);
            this.labelErrorText.TabIndex = 9;
            this.labelErrorText.Text = "Hubo un error";
            this.labelErrorText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(2320, 1100);
            this.Controls.Add(this.labelErrorText);
            this.Controls.Add(this.labelErrorTitle);
            this.Controls.Add(this.labelProductPrice);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.pictureProduct);
            this.Controls.Add(this.labelProductDesc);
            this.Controls.Add(this.pictureCodebar);
            this.Controls.Add(this.labelTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCodebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureLogo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureCodebar;
        private System.Windows.Forms.Label labelProductDesc;
        private System.Windows.Forms.PictureBox pictureProduct;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelProductPrice;
        private System.Windows.Forms.Label labelErrorTitle;
        private System.Windows.Forms.Label labelErrorText;
    }
}

