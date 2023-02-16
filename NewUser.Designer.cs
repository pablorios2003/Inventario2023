
namespace MVCinventario
{
    partial class NewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmail = new MVCinventario.Style.TxtBox();
            this.txtCelular = new MVCinventario.Style.TxtBox();
            this.txtApellido = new MVCinventario.Style.TxtBox();
            this.txtName = new MVCinventario.Style.TxtBox();
            this.txtCc = new MVCinventario.Style.TxtBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.rol = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtCelular);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtCc);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.rol);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 677);
            this.panel1.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtEmail.BorderColor = System.Drawing.Color.Black;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.txtEmail.Bordersize = 3;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(479, 291);
            this.txtEmail.Maxlenght = 30;
            this.txtEmail.MultiLine = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmail.PassWordChar = false;
            this.txtEmail.Size = new System.Drawing.Size(191, 35);
            this.txtEmail.TabIndex = 37;
            this.txtEmail.Texts = "Correo Electronico";
            this.txtEmail.UnderLineStyle = true;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.Color.White;
            this.txtCelular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtCelular.BorderColor = System.Drawing.Color.Black;
            this.txtCelular.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.txtCelular.Bordersize = 3;
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.ForeColor = System.Drawing.Color.Black;
            this.txtCelular.Location = new System.Drawing.Point(479, 223);
            this.txtCelular.Maxlenght = 15;
            this.txtCelular.MultiLine = false;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Padding = new System.Windows.Forms.Padding(7);
            this.txtCelular.PassWordChar = false;
            this.txtCelular.Size = new System.Drawing.Size(191, 35);
            this.txtCelular.TabIndex = 36;
            this.txtCelular.Texts = "Celular";
            this.txtCelular.UnderLineStyle = true;
            this.txtCelular.Enter += new System.EventHandler(this.txtCelular_Enter);
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            this.txtCelular.Leave += new System.EventHandler(this.txtCelular_Leave);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.White;
            this.txtApellido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtApellido.BorderColor = System.Drawing.Color.Black;
            this.txtApellido.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.txtApellido.Bordersize = 3;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.Black;
            this.txtApellido.Location = new System.Drawing.Point(116, 375);
            this.txtApellido.Maxlenght = 20;
            this.txtApellido.MultiLine = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Padding = new System.Windows.Forms.Padding(7);
            this.txtApellido.PassWordChar = false;
            this.txtApellido.Size = new System.Drawing.Size(191, 35);
            this.txtApellido.TabIndex = 35;
            this.txtApellido.Texts = "Apellido";
            this.txtApellido.UnderLineStyle = true;
            this.txtApellido.Enter += new System.EventHandler(this.txtApellido_Enter);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            this.txtApellido.Leave += new System.EventHandler(this.txtApellido_Leave);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtName.BorderColor = System.Drawing.Color.Black;
            this.txtName.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.txtName.Bordersize = 3;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(116, 291);
            this.txtName.Maxlenght = 20;
            this.txtName.MultiLine = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(7);
            this.txtName.PassWordChar = false;
            this.txtName.Size = new System.Drawing.Size(191, 35);
            this.txtName.TabIndex = 34;
            this.txtName.Texts = "Nombre";
            this.txtName.UnderLineStyle = true;
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // txtCc
            // 
            this.txtCc.BackColor = System.Drawing.Color.White;
            this.txtCc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtCc.BorderColor = System.Drawing.Color.Black;
            this.txtCc.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.txtCc.Bordersize = 3;
            this.txtCc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCc.ForeColor = System.Drawing.Color.Black;
            this.txtCc.Location = new System.Drawing.Point(116, 223);
            this.txtCc.Maxlenght = 20;
            this.txtCc.MultiLine = false;
            this.txtCc.Name = "txtCc";
            this.txtCc.Padding = new System.Windows.Forms.Padding(7);
            this.txtCc.PassWordChar = false;
            this.txtCc.Size = new System.Drawing.Size(191, 35);
            this.txtCc.TabIndex = 33;
            this.txtCc.Texts = "Cedula";
            this.txtCc.UnderLineStyle = true;
            this.txtCc.Enter += new System.EventHandler(this.txtCc_Enter);
            this.txtCc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCc_KeyPress);
            this.txtCc.Leave += new System.EventHandler(this.txtCc_Leave);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(389, 569);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 49);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrar.BackColor = System.Drawing.Color.White;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(387, 503);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(133, 49);
            this.btnRegistrar.TabIndex = 15;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // rol
            // 
            this.rol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rol.CausesValidation = false;
            this.rol.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rol.FormattingEnabled = true;
            this.rol.Items.AddRange(new object[] {
            "Rol",
            "Aprendiz",
            "Instructor",
            "Practicante"});
            this.rol.Location = new System.Drawing.Point(528, 414);
            this.rol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rol.Name = "rol";
            this.rol.Size = new System.Drawing.Size(191, 28);
            this.rol.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 155);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.label1.Font = new System.Drawing.Font("MS PGothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(257, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 48);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nuevo Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(766, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 155);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 677);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "NewUser";
            this.Text = "NewUser";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox rol;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Style.TxtBox txtEmail;
        private Style.TxtBox txtCelular;
        private Style.TxtBox txtApellido;
        private Style.TxtBox txtName;
        private Style.TxtBox txtCc;
    }
}