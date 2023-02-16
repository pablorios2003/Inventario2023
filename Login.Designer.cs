
namespace MVCinventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PictureError = new System.Windows.Forms.PictureBox();
            this.labelError = new System.Windows.Forms.Label();
            this.ocultar = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkRecuperar = new System.Windows.Forms.LinkLabel();
            this.ver = new System.Windows.Forms.PictureBox();
            this.txtUsu = new MVCinventario.Style.TxtBox();
            this.txtPass = new MVCinventario.Style.TxtBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ver)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 436);
            this.panel2.TabIndex = 3;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(129, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "CTGI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(97, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Inventario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 86);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 294);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.PictureError);
            this.panel1.Controls.Add(this.labelError);
            this.panel1.Controls.Add(this.ocultar);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.linkRecuperar);
            this.panel1.Controls.Add(this.ver);
            this.panel1.Controls.Add(this.txtUsu);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 436);
            this.panel1.TabIndex = 33;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // PictureError
            // 
            this.PictureError.Image = ((System.Drawing.Image)(resources.GetObject("PictureError.Image")));
            this.PictureError.Location = new System.Drawing.Point(463, 257);
            this.PictureError.Name = "PictureError";
            this.PictureError.Size = new System.Drawing.Size(19, 23);
            this.PictureError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureError.TabIndex = 36;
            this.PictureError.TabStop = false;
            this.PictureError.Visible = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.DarkGray;
            this.labelError.Location = new System.Drawing.Point(488, 264);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(46, 16);
            this.labelError.TabIndex = 35;
            this.labelError.Text = "label1";
            this.labelError.Visible = false;
            // 
            // ocultar
            // 
            this.ocultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.ocultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ocultar.Image = ((System.Drawing.Image)(resources.GetObject("ocultar.Image")));
            this.ocultar.Location = new System.Drawing.Point(689, 199);
            this.ocultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ocultar.Name = "ocultar";
            this.ocultar.Size = new System.Drawing.Size(36, 22);
            this.ocultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ocultar.TabIndex = 22;
            this.ocultar.TabStop = false;
            this.ocultar.Click += new System.EventHandler(this.ocultar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.pictureBox3.Location = new System.Drawing.Point(755, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.pictureBox2.Location = new System.Drawing.Point(781, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(518, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 31);
            this.button1.TabIndex = 34;
            this.button1.Text = "INICIAR SESION";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkRecuperar
            // 
            this.linkRecuperar.ActiveLinkColor = System.Drawing.Color.Fuchsia;
            this.linkRecuperar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkRecuperar.AutoSize = true;
            this.linkRecuperar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkRecuperar.DisabledLinkColor = System.Drawing.Color.FloralWhite;
            this.linkRecuperar.ForeColor = System.Drawing.Color.White;
            this.linkRecuperar.LinkColor = System.Drawing.Color.White;
            this.linkRecuperar.Location = new System.Drawing.Point(488, 373);
            this.linkRecuperar.Name = "linkRecuperar";
            this.linkRecuperar.Size = new System.Drawing.Size(176, 17);
            this.linkRecuperar.TabIndex = 24;
            this.linkRecuperar.TabStop = true;
            this.linkRecuperar.Text = "He olvidado mi contraseña";
            this.linkRecuperar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ver
            // 
            this.ver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.ver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ver.Image = ((System.Drawing.Image)(resources.GetObject("ver.Image")));
            this.ver.Location = new System.Drawing.Point(689, 199);
            this.ver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(36, 22);
            this.ver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ver.TabIndex = 21;
            this.ver.TabStop = false;
            this.ver.Click += new System.EventHandler(this.ver_Click);
            // 
            // txtUsu
            // 
            this.txtUsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.txtUsu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtUsu.BorderColor = System.Drawing.Color.GhostWhite;
            this.txtUsu.BorderFocusColor = System.Drawing.Color.Aqua;
            this.txtUsu.Bordersize = 3;
            this.txtUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsu.ForeColor = System.Drawing.Color.White;
            this.txtUsu.Location = new System.Drawing.Point(475, 86);
            this.txtUsu.Maxlenght = 32767;
            this.txtUsu.MultiLine = false;
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.Padding = new System.Windows.Forms.Padding(7);
            this.txtUsu.PassWordChar = false;
            this.txtUsu.Size = new System.Drawing.Size(250, 35);
            this.txtUsu.TabIndex = 32;
            this.txtUsu.Texts = "USUARIO";
            this.txtUsu.UnderLineStyle = true;
            this.txtUsu.Enter += new System.EventHandler(this.txtUsu_Enter);
            this.txtUsu.Leave += new System.EventHandler(this.txtUsu_Leave);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.txtPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtPass.BorderColor = System.Drawing.Color.GhostWhite;
            this.txtPass.BorderFocusColor = System.Drawing.Color.Aqua;
            this.txtPass.Bordersize = 3;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.White;
            this.txtPass.Location = new System.Drawing.Point(475, 199);
            this.txtPass.Maxlenght = 32767;
            this.txtPass.MultiLine = false;
            this.txtPass.Name = "txtPass";
            this.txtPass.Padding = new System.Windows.Forms.Padding(7);
            this.txtPass.PassWordChar = false;
            this.txtPass.Size = new System.Drawing.Size(250, 35);
            this.txtPass.TabIndex = 33;
            this.txtPass.Texts = "CONTRASEÑA";
            this.txtPass.UnderLineStyle = true;
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 436);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.Text = "INICIO SESION";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ocultar;
        private Style.TxtBox txtUsu;
        private Style.TxtBox txtPass;
        private System.Windows.Forms.LinkLabel linkRecuperar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.PictureBox PictureError;
    }
}