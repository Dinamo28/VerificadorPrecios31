
namespace VerificadorPrecios31
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Demo = new System.Windows.Forms.PictureBox();
            this.Cargar = new System.Windows.Forms.PictureBox();
            this.Aviso = new System.Windows.Forms.Label();
            this.Datos = new System.Windows.Forms.Label();
            this.AvisoError = new System.Windows.Forms.Label();
            this.Lector = new System.Windows.Forms.PictureBox();
            this.ErrorImg = new System.Windows.Forms.PictureBox();
            this.ImagenP = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Demo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cargar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenP)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Location = new System.Drawing.Point(51, 45);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(100, 50);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // Demo
            // 
            this.Demo.BackColor = System.Drawing.Color.Transparent;
            this.Demo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Demo.BackgroundImage")));
            this.Demo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Demo.Location = new System.Drawing.Point(51, 101);
            this.Demo.Name = "Demo";
            this.Demo.Size = new System.Drawing.Size(100, 50);
            this.Demo.TabIndex = 1;
            this.Demo.TabStop = false;
            // 
            // Cargar
            // 
            this.Cargar.BackColor = System.Drawing.Color.Transparent;
            this.Cargar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cargar.BackgroundImage")));
            this.Cargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cargar.Location = new System.Drawing.Point(51, 158);
            this.Cargar.Name = "Cargar";
            this.Cargar.Size = new System.Drawing.Size(100, 50);
            this.Cargar.TabIndex = 2;
            this.Cargar.TabStop = false;
            // 
            // Aviso
            // 
            this.Aviso.AutoSize = true;
            this.Aviso.BackColor = System.Drawing.Color.Transparent;
            this.Aviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Aviso.Location = new System.Drawing.Point(187, 45);
            this.Aviso.Name = "Aviso";
            this.Aviso.Size = new System.Drawing.Size(332, 33);
            this.Aviso.TabIndex = 3;
            this.Aviso.Text = "Esperando por articulo...";
            this.Aviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Datos
            // 
            this.Datos.AutoSize = true;
            this.Datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Datos.Location = new System.Drawing.Point(187, 101);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(99, 33);
            this.Datos.TabIndex = 4;
            this.Datos.Text = "label1";
            this.Datos.Visible = false;
            // 
            // AvisoError
            // 
            this.AvisoError.AutoSize = true;
            this.AvisoError.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AvisoError.Location = new System.Drawing.Point(187, 158);
            this.AvisoError.Name = "AvisoError";
            this.AvisoError.Size = new System.Drawing.Size(99, 33);
            this.AvisoError.TabIndex = 6;
            this.AvisoError.Text = "label2";
            this.AvisoError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lector
            // 
            this.Lector.BackColor = System.Drawing.Color.Transparent;
            this.Lector.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Lector.BackgroundImage")));
            this.Lector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Lector.Location = new System.Drawing.Point(51, 214);
            this.Lector.Name = "Lector";
            this.Lector.Size = new System.Drawing.Size(100, 50);
            this.Lector.TabIndex = 7;
            this.Lector.TabStop = false;
            // 
            // ErrorImg
            // 
            this.ErrorImg.BackColor = System.Drawing.Color.Transparent;
            this.ErrorImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ErrorImg.BackgroundImage")));
            this.ErrorImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ErrorImg.Location = new System.Drawing.Point(51, 271);
            this.ErrorImg.Name = "ErrorImg";
            this.ErrorImg.Size = new System.Drawing.Size(100, 50);
            this.ErrorImg.TabIndex = 8;
            this.ErrorImg.TabStop = false;
            // 
            // ImagenP
            // 
            this.ImagenP.BackColor = System.Drawing.Color.Transparent;
            this.ImagenP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImagenP.Location = new System.Drawing.Point(51, 327);
            this.ImagenP.Name = "ImagenP";
            this.ImagenP.Size = new System.Drawing.Size(100, 50);
            this.ImagenP.TabIndex = 9;
            this.ImagenP.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ImagenP);
            this.Controls.Add(this.ErrorImg);
            this.Controls.Add(this.Lector);
            this.Controls.Add(this.AvisoError);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.Aviso);
            this.Controls.Add(this.Cargar);
            this.Controls.Add(this.Demo);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Demo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cargar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox Demo;
        private System.Windows.Forms.PictureBox Cargar;
        private System.Windows.Forms.Label Aviso;
        private System.Windows.Forms.Label Datos;
        private System.Windows.Forms.Label AvisoError;
        private System.Windows.Forms.PictureBox Lector;
        private System.Windows.Forms.PictureBox ErrorImg;
        private System.Windows.Forms.PictureBox ImagenP;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

