
namespace MVCinventario
{
    partial class DevoPresta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ViewPrestamo = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.VistaDevolucion = new System.Windows.Forms.DataGridView();
            this.txtName = new MVCinventario.Style.TxtBox();
            this.txtDevolverCant = new MVCinventario.Style.TxtBox();
            this.txtCantidad = new MVCinventario.Style.TxtBox();
            this.txtnameP = new MVCinventario.Style.TxtBox();
            this.txtCode = new MVCinventario.Style.TxtBox();
            this.txtCc = new MVCinventario.Style.TxtBox();
            this.txtBuscar = new MVCinventario.Style.TxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VistaDevolucion)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewPrestamo
            // 
            this.ViewPrestamo.AllowUserToAddRows = false;
            this.ViewPrestamo.AllowUserToDeleteRows = false;
            this.ViewPrestamo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.ViewPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewPrestamo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.ViewPrestamo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ViewPrestamo.Location = new System.Drawing.Point(0, 0);
            this.ViewPrestamo.Name = "ViewPrestamo";
            this.ViewPrestamo.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.ViewPrestamo.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ViewPrestamo.RowTemplate.Height = 24;
            this.ViewPrestamo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ViewPrestamo.Size = new System.Drawing.Size(885, 223);
            this.ViewPrestamo.TabIndex = 7;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 64;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(621, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 41);
            this.button1.TabIndex = 76;
            this.button1.Text = "Devolver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VistaDevolucion
            // 
            this.VistaDevolucion.AllowUserToAddRows = false;
            this.VistaDevolucion.AllowUserToDeleteRows = false;
            this.VistaDevolucion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.VistaDevolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VistaDevolucion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.VistaDevolucion.Location = new System.Drawing.Point(0, 526);
            this.VistaDevolucion.Name = "VistaDevolucion";
            this.VistaDevolucion.ReadOnly = true;
            this.VistaDevolucion.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.VistaDevolucion.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.VistaDevolucion.RowTemplate.Height = 24;
            this.VistaDevolucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.VistaDevolucion.Size = new System.Drawing.Size(885, 151);
            this.VistaDevolucion.TabIndex = 77;
            this.VistaDevolucion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VistaDevolucion_CellContentClick);
            this.VistaDevolucion.SelectionChanged += new System.EventHandler(this.VistaDevolucion_SelectionChanged);
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
            this.txtName.Location = new System.Drawing.Point(231, 397);
            this.txtName.Maxlenght = 32767;
            this.txtName.MultiLine = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(7);
            this.txtName.PassWordChar = false;
            this.txtName.Size = new System.Drawing.Size(153, 34);
            this.txtName.TabIndex = 75;
            this.txtName.Texts = "Nombre";
            this.txtName.UnderLineStyle = true;
            // 
            // txtDevolverCant
            // 
            this.txtDevolverCant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.txtDevolverCant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtDevolverCant.BorderColor = System.Drawing.Color.Aqua;
            this.txtDevolverCant.BorderFocusColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDevolverCant.Bordersize = 3;
            this.txtDevolverCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDevolverCant.ForeColor = System.Drawing.Color.White;
            this.txtDevolverCant.Location = new System.Drawing.Point(656, 452);
            this.txtDevolverCant.Maxlenght = 2;
            this.txtDevolverCant.MultiLine = false;
            this.txtDevolverCant.Name = "txtDevolverCant";
            this.txtDevolverCant.Padding = new System.Windows.Forms.Padding(7);
            this.txtDevolverCant.PassWordChar = false;
            this.txtDevolverCant.Size = new System.Drawing.Size(157, 35);
            this.txtDevolverCant.TabIndex = 74;
            this.txtDevolverCant.Texts = "Cantidad Devolver";
            this.txtDevolverCant.UnderLineStyle = true;
            this.txtDevolverCant.Enter += new System.EventHandler(this.txtDevolverCant_Enter);
            this.txtDevolverCant.Leave += new System.EventHandler(this.txtDevolverCant_Leave);
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
            this.txtCantidad.Location = new System.Drawing.Point(422, 452);
            this.txtCantidad.Maxlenght = 2;
            this.txtCantidad.MultiLine = false;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Padding = new System.Windows.Forms.Padding(7);
            this.txtCantidad.PassWordChar = false;
            this.txtCantidad.Size = new System.Drawing.Size(157, 35);
            this.txtCantidad.TabIndex = 72;
            this.txtCantidad.Texts = "Cantidad Prestada";
            this.txtCantidad.UnderLineStyle = true;
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
            this.txtnameP.Location = new System.Drawing.Point(231, 452);
            this.txtnameP.Maxlenght = 32767;
            this.txtnameP.MultiLine = false;
            this.txtnameP.Name = "txtnameP";
            this.txtnameP.Padding = new System.Windows.Forms.Padding(7);
            this.txtnameP.PassWordChar = false;
            this.txtnameP.Size = new System.Drawing.Size(159, 35);
            this.txtnameP.TabIndex = 71;
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
            this.txtCode.Location = new System.Drawing.Point(18, 452);
            this.txtCode.Maxlenght = 32767;
            this.txtCode.MultiLine = false;
            this.txtCode.Name = "txtCode";
            this.txtCode.Padding = new System.Windows.Forms.Padding(7);
            this.txtCode.PassWordChar = false;
            this.txtCode.Size = new System.Drawing.Size(159, 35);
            this.txtCode.TabIndex = 70;
            this.txtCode.Texts = "Codigo";
            this.txtCode.UnderLineStyle = true;
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
            this.txtCc.Location = new System.Drawing.Point(18, 397);
            this.txtCc.Maxlenght = 32767;
            this.txtCc.MultiLine = false;
            this.txtCc.Name = "txtCc";
            this.txtCc.Padding = new System.Windows.Forms.Padding(7);
            this.txtCc.PassWordChar = false;
            this.txtCc.Size = new System.Drawing.Size(159, 34);
            this.txtCc.TabIndex = 69;
            this.txtCc.Texts = "Cedula";
            this.txtCc.UnderLineStyle = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscar.BorderColor = System.Drawing.Color.Aqua;
            this.txtBuscar.BorderFocusColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBuscar.Bordersize = 3;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar.Location = new System.Drawing.Point(354, 249);
            this.txtBuscar.Maxlenght = 32767;
            this.txtBuscar.MultiLine = false;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Padding = new System.Windows.Forms.Padding(7);
            this.txtBuscar.PassWordChar = false;
            this.txtBuscar.Size = new System.Drawing.Size(145, 35);
            this.txtBuscar.TabIndex = 68;
            this.txtBuscar.Texts = "Buscar";
            this.txtBuscar.UnderLineStyle = true;
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // DevoPresta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(885, 677);
            this.Controls.Add(this.VistaDevolucion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDevolverCant);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtnameP);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtCc);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.ViewPrestamo);
            this.Name = "DevoPresta";
            this.Text = "DevoPresta";
            this.Load += new System.EventHandler(this.DevoPresta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewPrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VistaDevolucion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewPrestamo;
        private Style.TxtBox txtBuscar;
        private Style.TxtBox txtCc;
        private Style.TxtBox txtCode;
        private Style.TxtBox txtnameP;
        private Style.TxtBox txtCantidad;
        private Style.TxtBox txtDevolverCant;
        private Style.TxtBox txtName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView VistaDevolucion;
    }
}