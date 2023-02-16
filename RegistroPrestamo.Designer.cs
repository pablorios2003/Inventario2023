
namespace MVCinventario
{
    partial class RegistroPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroPrestamo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Lupa = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnGuardad = new System.Windows.Forms.Button();
            this.VistaPrestamos = new System.Windows.Forms.DataGridView();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtBuscar = new MVCinventario.Style.TxtBox();
            this.txtState = new MVCinventario.Style.TxtBox();
            this.txtCantidad = new MVCinventario.Style.TxtBox();
            this.txtFecha = new MVCinventario.Style.TxtBox();
            this.txtDispo = new MVCinventario.Style.TxtBox();
            this.txtnameP = new MVCinventario.Style.TxtBox();
            this.txtCode = new MVCinventario.Style.TxtBox();
            this.txtEmail = new MVCinventario.Style.TxtBox();
            this.txtCc = new MVCinventario.Style.TxtBox();
            this.txtApellido = new MVCinventario.Style.TxtBox();
            this.txtName = new MVCinventario.Style.TxtBox();
            this.txtCelular = new MVCinventario.Style.TxtBox();
            this.categoria = new MVCinventario.Style.TxtBox();
            this.rol = new MVCinventario.Style.TxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.Lupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VistaPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lupa
            // 
            this.Lupa.BackColor = System.Drawing.Color.White;
            this.Lupa.Image = ((System.Drawing.Image)(resources.GetObject("Lupa.Image")));
            this.Lupa.Location = new System.Drawing.Point(800, 36);
            this.Lupa.Name = "Lupa";
            this.Lupa.Size = new System.Drawing.Size(28, 24);
            this.Lupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Lupa.TabIndex = 58;
            this.Lupa.TabStop = false;
            this.Lupa.Click += new System.EventHandler(this.Lupa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 31);
            this.label1.TabIndex = 59;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 31);
            this.label2.TabIndex = 60;
            this.label2.Text = "Prestamo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 31);
            this.label3.TabIndex = 61;
            this.label3.Text = "Producto";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.ForeColor = System.Drawing.Color.White;
            this.labelHora.Location = new System.Drawing.Point(21, 9);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(46, 17);
            this.labelHora.TabIndex = 62;
            this.labelHora.Text = "label4";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtnGuardad
            // 
            this.BtnGuardad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.BtnGuardad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.BtnGuardad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnGuardad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardad.ForeColor = System.Drawing.Color.White;
            this.BtnGuardad.Location = new System.Drawing.Point(322, 468);
            this.BtnGuardad.Name = "BtnGuardad";
            this.BtnGuardad.Size = new System.Drawing.Size(153, 41);
            this.BtnGuardad.TabIndex = 63;
            this.BtnGuardad.Text = "Guardar";
            this.BtnGuardad.UseVisualStyleBackColor = false;
            this.BtnGuardad.Click += new System.EventHandler(this.button1_Click);
            // 
            // VistaPrestamos
            // 
            this.VistaPrestamos.AllowUserToAddRows = false;
            this.VistaPrestamos.AllowUserToDeleteRows = false;
            this.VistaPrestamos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.VistaPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VistaPrestamos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.VistaPrestamos.Location = new System.Drawing.Point(0, 526);
            this.VistaPrestamos.Name = "VistaPrestamos";
            this.VistaPrestamos.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.VistaPrestamos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.VistaPrestamos.RowTemplate.Height = 24;
            this.VistaPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VistaPrestamos.Size = new System.Drawing.Size(885, 151);
            this.VistaPrestamos.TabIndex = 66;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(748, 492);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(103, 28);
            this.BtnEliminar.TabIndex = 67;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(158, 232);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.txtBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscar.BorderColor = System.Drawing.Color.Aqua;
            this.txtBuscar.BorderFocusColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBuscar.Bordersize = 3;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(638, 25);
            this.txtBuscar.Maxlenght = 32767;
            this.txtBuscar.MultiLine = false;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Padding = new System.Windows.Forms.Padding(7);
            this.txtBuscar.PassWordChar = false;
            this.txtBuscar.Size = new System.Drawing.Size(145, 35);
            this.txtBuscar.TabIndex = 57;
            this.txtBuscar.Texts = "Buscar";
            this.txtBuscar.UnderLineStyle = true;
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // txtState
            // 
            this.txtState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.txtState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtState.BorderColor = System.Drawing.Color.Aqua;
            this.txtState.BorderFocusColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtState.Bordersize = 3;
            this.txtState.Enabled = false;
            this.txtState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.ForeColor = System.Drawing.Color.White;
            this.txtState.Location = new System.Drawing.Point(467, 142);
            this.txtState.Maxlenght = 32767;
            this.txtState.MultiLine = false;
            this.txtState.Name = "txtState";
            this.txtState.Padding = new System.Windows.Forms.Padding(7);
            this.txtState.PassWordChar = false;
            this.txtState.Size = new System.Drawing.Size(157, 35);
            this.txtState.TabIndex = 56;
            this.txtState.Texts = "Estado";
            this.txtState.UnderLineStyle = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.txtCantidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtCantidad.BorderColor = System.Drawing.Color.Aqua;
            this.txtCantidad.BorderFocusColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCantidad.Bordersize = 3;
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.White;
            this.txtCantidad.Location = new System.Drawing.Point(39, 142);
            this.txtCantidad.Maxlenght = 2;
            this.txtCantidad.MultiLine = false;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Padding = new System.Windows.Forms.Padding(7);
            this.txtCantidad.PassWordChar = false;
            this.txtCantidad.Size = new System.Drawing.Size(157, 35);
            this.txtCantidad.TabIndex = 55;
            this.txtCantidad.Texts = "Cantidad";
            this.txtCantidad.UnderLineStyle = true;
            this.txtCantidad.Enter += new System.EventHandler(this.txtCantidad_Enter);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            this.txtCantidad.Leave += new System.EventHandler(this.txtCantidad_Leave);
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.txtFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtFecha.BorderColor = System.Drawing.Color.Aqua;
            this.txtFecha.BorderFocusColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFecha.Bordersize = 3;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.ForeColor = System.Drawing.Color.White;
            this.txtFecha.Location = new System.Drawing.Point(246, 142);
            this.txtFecha.Maxlenght = 32767;
            this.txtFecha.MultiLine = false;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Padding = new System.Windows.Forms.Padding(7);
            this.txtFecha.PassWordChar = false;
            this.txtFecha.Size = new System.Drawing.Size(157, 35);
            this.txtFecha.TabIndex = 54;
            this.txtFecha.Texts = "Fecha";
            this.txtFecha.UnderLineStyle = true;
            // 
            // txtDispo
            // 
            this.txtDispo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.txtDispo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtDispo.BorderColor = System.Drawing.Color.Aqua;
            this.txtDispo.BorderFocusColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDispo.Bordersize = 3;
            this.txtDispo.Enabled = false;
            this.txtDispo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDispo.ForeColor = System.Drawing.Color.White;
            this.txtDispo.Location = new System.Drawing.Point(473, 281);
            this.txtDispo.Maxlenght = 32767;
            this.txtDispo.MultiLine = false;
            this.txtDispo.Name = "txtDispo";
            this.txtDispo.Padding = new System.Windows.Forms.Padding(7);
            this.txtDispo.PassWordChar = false;
            this.txtDispo.Size = new System.Drawing.Size(159, 35);
            this.txtDispo.TabIndex = 53;
            this.txtDispo.Texts = "Disponible";
            this.txtDispo.UnderLineStyle = true;
            // 
            // txtnameP
            // 
            this.txtnameP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.txtnameP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtnameP.BorderColor = System.Drawing.Color.Aqua;
            this.txtnameP.BorderFocusColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtnameP.Bordersize = 3;
            this.txtnameP.Enabled = false;
            this.txtnameP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnameP.ForeColor = System.Drawing.Color.White;
            this.txtnameP.Location = new System.Drawing.Point(246, 281);
            this.txtnameP.Maxlenght = 32767;
            this.txtnameP.MultiLine = false;
            this.txtnameP.Name = "txtnameP";
            this.txtnameP.Padding = new System.Windows.Forms.Padding(7);
            this.txtnameP.PassWordChar = false;
            this.txtnameP.Size = new System.Drawing.Size(159, 35);
            this.txtnameP.TabIndex = 52;
            this.txtnameP.Texts = "Nombre Producto";
            this.txtnameP.UnderLineStyle = true;
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.txtCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtCode.BorderColor = System.Drawing.Color.Aqua;
            this.txtCode.BorderFocusColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCode.Bordersize = 3;
            this.txtCode.Enabled = false;
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.Color.White;
            this.txtCode.Location = new System.Drawing.Point(33, 281);
            this.txtCode.Maxlenght = 32767;
            this.txtCode.MultiLine = false;
            this.txtCode.Name = "txtCode";
            this.txtCode.Padding = new System.Windows.Forms.Padding(7);
            this.txtCode.PassWordChar = false;
            this.txtCode.Size = new System.Drawing.Size(159, 35);
            this.txtCode.TabIndex = 51;
            this.txtCode.Texts = "Codigo";
            this.txtCode.UnderLineStyle = true;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.txtEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtEmail.BorderColor = System.Drawing.Color.Aqua;
            this.txtEmail.BorderFocusColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtEmail.Bordersize = 3;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(473, 357);
            this.txtEmail.Maxlenght = 32767;
            this.txtEmail.MultiLine = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmail.PassWordChar = false;
            this.txtEmail.Size = new System.Drawing.Size(153, 34);
            this.txtEmail.TabIndex = 49;
            this.txtEmail.Texts = "Correo Electronico";
            this.txtEmail.UnderLineStyle = true;
            // 
            // txtCc
            // 
            this.txtCc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.txtCc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtCc.BorderColor = System.Drawing.Color.Aqua;
            this.txtCc.BorderFocusColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCc.Bordersize = 3;
            this.txtCc.Enabled = false;
            this.txtCc.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCc.ForeColor = System.Drawing.Color.White;
            this.txtCc.Location = new System.Drawing.Point(246, 357);
            this.txtCc.Maxlenght = 32767;
            this.txtCc.MultiLine = false;
            this.txtCc.Name = "txtCc";
            this.txtCc.Padding = new System.Windows.Forms.Padding(7);
            this.txtCc.PassWordChar = false;
            this.txtCc.Size = new System.Drawing.Size(159, 34);
            this.txtCc.TabIndex = 45;
            this.txtCc.Texts = "Cedula";
            this.txtCc.UnderLineStyle = true;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.txtApellido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtApellido.BorderColor = System.Drawing.Color.Aqua;
            this.txtApellido.BorderFocusColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtApellido.Bordersize = 3;
            this.txtApellido.Enabled = false;
            this.txtApellido.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.White;
            this.txtApellido.Location = new System.Drawing.Point(246, 408);
            this.txtApellido.Maxlenght = 32767;
            this.txtApellido.MultiLine = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Padding = new System.Windows.Forms.Padding(7);
            this.txtApellido.PassWordChar = false;
            this.txtApellido.Size = new System.Drawing.Size(159, 34);
            this.txtApellido.TabIndex = 47;
            this.txtApellido.Texts = "Apellido";
            this.txtApellido.UnderLineStyle = true;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.txtName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtName.BorderColor = System.Drawing.Color.Aqua;
            this.txtName.BorderFocusColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtName.Bordersize = 3;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(39, 408);
            this.txtName.Maxlenght = 32767;
            this.txtName.MultiLine = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(7);
            this.txtName.PassWordChar = false;
            this.txtName.Size = new System.Drawing.Size(153, 34);
            this.txtName.TabIndex = 46;
            this.txtName.Texts = "Nombre";
            this.txtName.UnderLineStyle = true;
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.txtCelular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtCelular.BorderColor = System.Drawing.Color.Aqua;
            this.txtCelular.BorderFocusColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCelular.Bordersize = 3;
            this.txtCelular.Enabled = false;
            this.txtCelular.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.ForeColor = System.Drawing.Color.White;
            this.txtCelular.Location = new System.Drawing.Point(467, 408);
            this.txtCelular.Maxlenght = 32767;
            this.txtCelular.MultiLine = false;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Padding = new System.Windows.Forms.Padding(7);
            this.txtCelular.PassWordChar = false;
            this.txtCelular.Size = new System.Drawing.Size(159, 34);
            this.txtCelular.TabIndex = 48;
            this.txtCelular.Texts = "Celular";
            this.txtCelular.UnderLineStyle = true;
            // 
            // categoria
            // 
            this.categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.categoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoria.BorderColor = System.Drawing.Color.Aqua;
            this.categoria.BorderFocusColor = System.Drawing.SystemColors.ButtonHighlight;
            this.categoria.Bordersize = 3;
            this.categoria.Enabled = false;
            this.categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoria.ForeColor = System.Drawing.Color.White;
            this.categoria.Location = new System.Drawing.Point(669, 281);
            this.categoria.Maxlenght = 32767;
            this.categoria.MultiLine = false;
            this.categoria.Name = "categoria";
            this.categoria.Padding = new System.Windows.Forms.Padding(7);
            this.categoria.PassWordChar = false;
            this.categoria.Size = new System.Drawing.Size(159, 35);
            this.categoria.TabIndex = 69;
            this.categoria.Texts = "Categoria";
            this.categoria.UnderLineStyle = true;
            // 
            // rol
            // 
            this.rol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.rol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rol.BorderColor = System.Drawing.Color.Aqua;
            this.rol.BorderFocusColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rol.Bordersize = 3;
            this.rol.Enabled = false;
            this.rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rol.ForeColor = System.Drawing.Color.White;
            this.rol.Location = new System.Drawing.Point(669, 408);
            this.rol.Maxlenght = 32767;
            this.rol.MultiLine = false;
            this.rol.Name = "rol";
            this.rol.Padding = new System.Windows.Forms.Padding(7);
            this.rol.PassWordChar = false;
            this.rol.Size = new System.Drawing.Size(159, 35);
            this.rol.TabIndex = 70;
            this.rol.Texts = "Rol";
            this.rol.UnderLineStyle = true;
            // 
            // RegistroPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(885, 677);
            this.Controls.Add(this.rol);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.VistaPrestamos);
            this.Controls.Add(this.BtnGuardad);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.Lupa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtDispo);
            this.Controls.Add(this.txtnameP);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCc);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCelular);
            this.Name = "RegistroPrestamo";
            this.Text = "RegistroPrestamo";
            this.Load += new System.EventHandler(this.RegistroPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Lupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VistaPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Style.TxtBox txtEmail;
        private Style.TxtBox txtCc;
        private Style.TxtBox txtApellido;
        private Style.TxtBox txtName;
        private Style.TxtBox txtCelular;
        private Style.TxtBox txtDispo;
        private Style.TxtBox txtnameP;
        private Style.TxtBox txtCode;
        private Style.TxtBox txtState;
        private Style.TxtBox txtCantidad;
        private Style.TxtBox txtFecha;
        private Style.TxtBox txtBuscar;
        private System.Windows.Forms.PictureBox Lupa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnGuardad;
        private System.Windows.Forms.DataGridView VistaPrestamos;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Style.TxtBox categoria;
        private Style.TxtBox rol;
    }
}