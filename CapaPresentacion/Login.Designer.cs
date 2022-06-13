namespace CapaPresentacion
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.IBTNIngresar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTBDocumento = new System.Windows.Forms.TextBox();
            this.TXTBClave = new System.Windows.Forms.TextBox();
            this.IBTNCanselar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 191);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sistema de Ventas 2022";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 180;
            this.iconPictureBox1.Location = new System.Drawing.Point(12, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(182, 139);
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            // 
            // IBTNIngresar
            // 
            this.IBTNIngresar.AutoSize = true;
            this.IBTNIngresar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.IBTNIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBTNIngresar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.IBTNIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBTNIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBTNIngresar.ForeColor = System.Drawing.Color.White;
            this.IBTNIngresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.IBTNIngresar.IconColor = System.Drawing.Color.White;
            this.IBTNIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBTNIngresar.IconSize = 25;
            this.IBTNIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBTNIngresar.Location = new System.Drawing.Point(218, 142);
            this.IBTNIngresar.Name = "IBTNIngresar";
            this.IBTNIngresar.Size = new System.Drawing.Size(114, 34);
            this.IBTNIngresar.TabIndex = 5;
            this.IBTNIngresar.Text = "Ingresar";
            this.IBTNIngresar.UseVisualStyleBackColor = false;
            this.IBTNIngresar.Click += new System.EventHandler(this.IBTNIngresar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Documento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Clave:";
            // 
            // TXTBDocumento
            // 
            this.TXTBDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBDocumento.Location = new System.Drawing.Point(210, 41);
            this.TXTBDocumento.Multiline = true;
            this.TXTBDocumento.Name = "TXTBDocumento";
            this.TXTBDocumento.Size = new System.Drawing.Size(246, 26);
            this.TXTBDocumento.TabIndex = 9;
            // 
            // TXTBClave
            // 
            this.TXTBClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBClave.Location = new System.Drawing.Point(210, 96);
            this.TXTBClave.Multiline = true;
            this.TXTBClave.Name = "TXTBClave";
            this.TXTBClave.PasswordChar = '*';
            this.TXTBClave.Size = new System.Drawing.Size(246, 26);
            this.TXTBClave.TabIndex = 10;
            // 
            // IBTNCanselar
            // 
            this.IBTNCanselar.BackColor = System.Drawing.Color.OrangeRed;
            this.IBTNCanselar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBTNCanselar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.IBTNCanselar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBTNCanselar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBTNCanselar.ForeColor = System.Drawing.Color.White;
            this.IBTNCanselar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.IBTNCanselar.IconColor = System.Drawing.Color.White;
            this.IBTNCanselar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBTNCanselar.IconSize = 25;
            this.IBTNCanselar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.IBTNCanselar.Location = new System.Drawing.Point(340, 142);
            this.IBTNCanselar.Name = "IBTNCanselar";
            this.IBTNCanselar.Size = new System.Drawing.Size(114, 34);
            this.IBTNCanselar.TabIndex = 11;
            this.IBTNCanselar.Text = "Canselar";
            this.IBTNCanselar.UseVisualStyleBackColor = false;
            this.IBTNCanselar.Click += new System.EventHandler(this.IBTNCanselar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 191);
            this.Controls.Add(this.IBTNCanselar);
            this.Controls.Add(this.TXTBClave);
            this.Controls.Add(this.TXTBDocumento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IBTNIngresar);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton IBTNIngresar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTBDocumento;
        private System.Windows.Forms.TextBox TXTBClave;
        private FontAwesome.Sharp.IconButton IBTNCanselar;
    }
}