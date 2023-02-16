
namespace MVCinventario
{
    partial class UserView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuscar = new MVCinventario.Style.TxtBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEmail = new MVCinventario.Style.TxtBox();
            this.rol = new System.Windows.Forms.ComboBox();
            this.txtCc = new MVCinventario.Style.TxtBox();
            this.txtApellido = new MVCinventario.Style.TxtBox();
            this.txtName = new MVCinventario.Style.TxtBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.txtCelular = new MVCinventario.Style.TxtBox();
            this.ViewUser = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.Red;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F);
            this.BtnUpdate.Location = new System.Drawing.Point(611, 107);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(102, 33);
            this.BtnUpdate.TabIndex = 1;
            this.BtnUpdate.Text = "Actualizar";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 176);
            this.panel1.TabIndex = 3;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.Azure;
            this.txtBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscar.BorderColor = System.Drawing.Color.Aqua;
            this.txtBuscar.BorderFocusColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtBuscar.Bordersize = 3;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar.Location = new System.Drawing.Point(556, 41);
            this.txtBuscar.Maxlenght = 32767;
            this.txtBuscar.MultiLine = false;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Padding = new System.Windows.Forms.Padding(7);
            this.txtBuscar.PassWordChar = false;
            this.txtBuscar.Size = new System.Drawing.Size(145, 35);
            this.txtBuscar.TabIndex = 58;
            this.txtBuscar.Texts = "Buscar";
            this.txtBuscar.UnderLineStyle = true;
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.rol);
            this.panel2.Controls.Add(this.txtCc);
            this.panel2.Controls.Add(this.txtApellido);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.BtnEliminar);
            this.panel2.Controls.Add(this.BtnUpdate);
            this.panel2.Controls.Add(this.txtCelular);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 507);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 170);
            this.panel2.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Azure;
            this.txtEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.txtEmail.BorderFocusColor = System.Drawing.Color.LawnGreen;
            this.txtEmail.Bordersize = 3;
            this.txtEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(294, 72);
            this.txtEmail.Maxlenght = 30;
            this.txtEmail.MultiLine = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmail.PassWordChar = false;
            this.txtEmail.Size = new System.Drawing.Size(191, 34);
            this.txtEmail.TabIndex = 43;
            this.txtEmail.Texts = "Correo Electronico";
            this.txtEmail.UnderLineStyle = true;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // rol
            // 
            this.rol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rol.BackColor = System.Drawing.Color.Azure;
            this.rol.CausesValidation = false;
            this.rol.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rol.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rol.ForeColor = System.Drawing.Color.Black;
            this.rol.FormattingEnabled = true;
            this.rol.Items.AddRange(new object[] {
            "Rol",
            "Aprendiz",
            "Instructor",
            "Practicante"});
            this.rol.Location = new System.Drawing.Point(294, 124);
            this.rol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rol.Name = "rol";
            this.rol.Size = new System.Drawing.Size(191, 27);
            this.rol.TabIndex = 38;
            // 
            // txtCc
            // 
            this.txtCc.BackColor = System.Drawing.Color.Azure;
            this.txtCc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtCc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.txtCc.BorderFocusColor = System.Drawing.Color.LawnGreen;
            this.txtCc.Bordersize = 3;
            this.txtCc.Enabled = false;
            this.txtCc.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCc.ForeColor = System.Drawing.Color.Black;
            this.txtCc.Location = new System.Drawing.Point(49, 22);
            this.txtCc.Maxlenght = 20;
            this.txtCc.MultiLine = false;
            this.txtCc.Name = "txtCc";
            this.txtCc.Padding = new System.Windows.Forms.Padding(7);
            this.txtCc.PassWordChar = false;
            this.txtCc.Size = new System.Drawing.Size(191, 34);
            this.txtCc.TabIndex = 39;
            this.txtCc.Texts = "Cedula";
            this.txtCc.UnderLineStyle = true;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.Azure;
            this.txtApellido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtApellido.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.txtApellido.BorderFocusColor = System.Drawing.Color.LawnGreen;
            this.txtApellido.Bordersize = 3;
            this.txtApellido.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.Black;
            this.txtApellido.Location = new System.Drawing.Point(49, 126);
            this.txtApellido.Maxlenght = 20;
            this.txtApellido.MultiLine = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Padding = new System.Windows.Forms.Padding(7);
            this.txtApellido.PassWordChar = false;
            this.txtApellido.Size = new System.Drawing.Size(191, 34);
            this.txtApellido.TabIndex = 41;
            this.txtApellido.Texts = "Apellido";
            this.txtApellido.UnderLineStyle = true;
            this.txtApellido.Enter += new System.EventHandler(this.txtApellido_Enter);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            this.txtApellido.Leave += new System.EventHandler(this.txtApellido_Leave);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Azure;
            this.txtName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.txtName.BorderFocusColor = System.Drawing.Color.LawnGreen;
            this.txtName.Bordersize = 3;
            this.txtName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(49, 72);
            this.txtName.Maxlenght = 20;
            this.txtName.MultiLine = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(7);
            this.txtName.PassWordChar = false;
            this.txtName.Size = new System.Drawing.Size(191, 34);
            this.txtName.TabIndex = 40;
            this.txtName.Texts = "Nombre";
            this.txtName.UnderLineStyle = true;
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Green;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(611, 55);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(102, 30);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.Color.Azure;
            this.txtCelular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtCelular.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.txtCelular.BorderFocusColor = System.Drawing.Color.LawnGreen;
            this.txtCelular.Bordersize = 3;
            this.txtCelular.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.ForeColor = System.Drawing.Color.Black;
            this.txtCelular.Location = new System.Drawing.Point(294, 22);
            this.txtCelular.Maxlenght = 15;
            this.txtCelular.MultiLine = false;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Padding = new System.Windows.Forms.Padding(7);
            this.txtCelular.PassWordChar = false;
            this.txtCelular.Size = new System.Drawing.Size(191, 34);
            this.txtCelular.TabIndex = 42;
            this.txtCelular.Texts = "Celular";
            this.txtCelular.UnderLineStyle = true;
            this.txtCelular.Enter += new System.EventHandler(this.txtCelular_Enter);
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            this.txtCelular.Leave += new System.EventHandler(this.txtCelular_Leave);
            // 
            // ViewUser
            // 
            this.ViewUser.AllowUserToAddRows = false;
            this.ViewUser.AllowUserToDeleteRows = false;
            this.ViewUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.ViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewUser.Location = new System.Drawing.Point(0, 176);
            this.ViewUser.Name = "ViewUser";
            this.ViewUser.ReadOnly = true;
            this.ViewUser.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.ViewUser.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ViewUser.RowTemplate.Height = 24;
            this.ViewUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ViewUser.Size = new System.Drawing.Size(885, 331);
            this.ViewUser.TabIndex = 5;
            this.ViewUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewUser_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(885, 677);
            this.Controls.Add(this.ViewUser);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserView";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView ViewUser;
        private Style.TxtBox txtEmail;
        private System.Windows.Forms.ComboBox rol;
        private Style.TxtBox txtApellido;
        private Style.TxtBox txtCelular;
        private Style.TxtBox txtName;
        private Style.TxtBox txtCc;
        private System.Windows.Forms.Button BtnEliminar;
        private Style.TxtBox txtBuscar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

