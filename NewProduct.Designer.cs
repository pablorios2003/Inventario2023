
namespace MVCinventario
{
    partial class NewProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProduct));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtCant = new MVCinventario.Style.TxtBox();
            this.txtnameP = new MVCinventario.Style.TxtBox();
            this.txtCode = new MVCinventario.Style.TxtBox();
            this.categoria = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 155);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(211, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 48);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nuevo Producto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(755, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 155);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.txtCant);
            this.panel1.Controls.Add(this.txtnameP);
            this.panel1.Controls.Add(this.txtCode);
            this.panel1.Controls.Add(this.categoria);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 677);
            this.panel1.TabIndex = 10;
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
            this.btnClear.Location = new System.Drawing.Point(219, 481);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 49);
            this.btnClear.TabIndex = 42;
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
            this.btnRegistrar.Location = new System.Drawing.Point(568, 481);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(133, 49);
            this.btnRegistrar.TabIndex = 41;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtCant
            // 
            this.txtCant.BackColor = System.Drawing.Color.White;
            this.txtCant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtCant.BorderColor = System.Drawing.Color.Black;
            this.txtCant.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.txtCant.Bordersize = 3;
            this.txtCant.Enabled = false;
            this.txtCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCant.ForeColor = System.Drawing.Color.Black;
            this.txtCant.Location = new System.Drawing.Point(479, 209);
            this.txtCant.Maxlenght = 4;
            this.txtCant.MultiLine = false;
            this.txtCant.Name = "txtCant";
            this.txtCant.Padding = new System.Windows.Forms.Padding(7);
            this.txtCant.PassWordChar = false;
            this.txtCant.Size = new System.Drawing.Size(191, 35);
            this.txtCant.TabIndex = 40;
            this.txtCant.Texts = "Cantidad";
            this.txtCant.UnderLineStyle = true;
            this.txtCant.Enter += new System.EventHandler(this.txtCant_Enter);
            this.txtCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCant_KeyPress);
            this.txtCant.Leave += new System.EventHandler(this.txtCant_Leave);
            // 
            // txtnameP
            // 
            this.txtnameP.BackColor = System.Drawing.Color.White;
            this.txtnameP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtnameP.BorderColor = System.Drawing.Color.Black;
            this.txtnameP.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.txtnameP.Bordersize = 3;
            this.txtnameP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnameP.ForeColor = System.Drawing.Color.Black;
            this.txtnameP.Location = new System.Drawing.Point(116, 322);
            this.txtnameP.Maxlenght = 15;
            this.txtnameP.MultiLine = false;
            this.txtnameP.Name = "txtnameP";
            this.txtnameP.Padding = new System.Windows.Forms.Padding(7);
            this.txtnameP.PassWordChar = false;
            this.txtnameP.Size = new System.Drawing.Size(191, 35);
            this.txtnameP.TabIndex = 39;
            this.txtnameP.Texts = "Nombre Producto";
            this.txtnameP.UnderLineStyle = true;
            this.txtnameP.Enter += new System.EventHandler(this.txtnameP_Enter);
            this.txtnameP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnameP_KeyPress);
            this.txtnameP.Leave += new System.EventHandler(this.txtnameP_Leave);
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.White;
            this.txtCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtCode.BorderColor = System.Drawing.Color.Black;
            this.txtCode.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.txtCode.Bordersize = 3;
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.Color.Black;
            this.txtCode.Location = new System.Drawing.Point(116, 209);
            this.txtCode.Maxlenght = 12;
            this.txtCode.MultiLine = false;
            this.txtCode.Name = "txtCode";
            this.txtCode.Padding = new System.Windows.Forms.Padding(7);
            this.txtCode.PassWordChar = false;
            this.txtCode.Size = new System.Drawing.Size(191, 35);
            this.txtCode.TabIndex = 38;
            this.txtCode.Texts = "Codigo";
            this.txtCode.UnderLineStyle = true;
            this.txtCode.Enter += new System.EventHandler(this.txtCode_Enter);
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCode_KeyPress);
            this.txtCode.Leave += new System.EventHandler(this.txtCode_Leave);
            // 
            // categoria
            // 
            this.categoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoria.CausesValidation = false;
            this.categoria.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoria.FormattingEnabled = true;
            this.categoria.Items.AddRange(new object[] {
            "Tipo",
            "Entregable",
            "No Entregable"});
            this.categoria.Location = new System.Drawing.Point(528, 368);
            this.categoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(191, 28);
            this.categoria.TabIndex = 37;
            this.categoria.SelectedIndexChanged += new System.EventHandler(this.categoria_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 677);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "NewProduct";
            this.Text = "NewProduct";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Style.TxtBox txtCant;
        private Style.TxtBox txtnameP;
        private Style.TxtBox txtCode;
        private System.Windows.Forms.ComboBox categoria;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}