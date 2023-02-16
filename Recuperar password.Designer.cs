
namespace MVCinventario
{
    partial class Recuperar_password
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
            this.PanelRecuperar = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.PanelHijoPass = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnName = new MVCinventario.Style.TxtBox();
            this.txtEmail = new MVCinventario.Style.TxtBox();
            this.PanelRecuperar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelRecuperar
            // 
            this.PanelRecuperar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.PanelRecuperar.Controls.Add(this.pictureBox3);
            this.PanelRecuperar.Controls.Add(this.pictureBox2);
            this.PanelRecuperar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelRecuperar.Location = new System.Drawing.Point(0, 0);
            this.PanelRecuperar.Name = "PanelRecuperar";
            this.PanelRecuperar.Size = new System.Drawing.Size(745, 36);
            this.PanelRecuperar.TabIndex = 1;
            this.PanelRecuperar.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelRecuperar_Paint);
            this.PanelRecuperar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelRecuperar_MouseDown);
            this.PanelRecuperar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelRecuperar_MouseMove);
            this.PanelRecuperar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelRecuperar_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.pictureBox3.Location = new System.Drawing.Point(687, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.pictureBox2.Location = new System.Drawing.Point(713, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.btnVerificar.FlatAppearance.BorderSize = 0;
            this.btnVerificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.btnVerificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.ForeColor = System.Drawing.Color.White;
            this.btnVerificar.Location = new System.Drawing.Point(309, 109);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(118, 28);
            this.btnVerificar.TabIndex = 39;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // PanelHijoPass
            // 
            this.PanelHijoPass.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelHijoPass.Location = new System.Drawing.Point(0, 221);
            this.PanelHijoPass.Name = "PanelHijoPass";
            this.PanelHijoPass.Size = new System.Drawing.Size(745, 204);
            this.PanelHijoPass.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnVerificar);
            this.panel2.Controls.Add(this.btnName);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 179);
            this.panel2.TabIndex = 2;
            // 
            // btnName
            // 
            this.btnName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.btnName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnName.BorderColor = System.Drawing.Color.MintCream;
            this.btnName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.btnName.Bordersize = 3;
            this.btnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnName.ForeColor = System.Drawing.Color.White;
            this.btnName.Location = new System.Drawing.Point(442, 61);
            this.btnName.MultiLine = false;
            this.btnName.Name = "btnName";
            this.btnName.Padding = new System.Windows.Forms.Padding(7);
            this.btnName.PassWordChar = false;
            this.btnName.Size = new System.Drawing.Size(250, 35);
            this.btnName.TabIndex = 38;
            this.btnName.Texts = "Nombre de Usuario";
            this.btnName.UnderLineStyle = true;
            this.btnName.Enter += new System.EventHandler(this.btnName_Enter);
            this.btnName.Leave += new System.EventHandler(this.btnName_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.txtEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtEmail.BorderColor = System.Drawing.Color.MintCream;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEmail.Bordersize = 3;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(39, 61);
            this.txtEmail.MultiLine = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmail.PassWordChar = false;
            this.txtEmail.Size = new System.Drawing.Size(250, 35);
            this.txtEmail.TabIndex = 37;
            this.txtEmail.Texts = "Correo Electronico";
            this.txtEmail.UnderLineStyle = true;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // Recuperar_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(745, 425);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanelHijoPass);
            this.Controls.Add(this.PanelRecuperar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recuperar_password";
            this.Text = "RECUPERAR CONTRASEÑA";
            this.PanelRecuperar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelRecuperar;
        private System.Windows.Forms.Panel PanelHijoPass;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Style.TxtBox txtEmail;
        private System.Windows.Forms.Button btnVerificar;
        private Style.TxtBox btnName;
        private System.Windows.Forms.Panel panel2;
    }
}