
namespace MVCinventario
{
    partial class Viewproduc
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
            this.ViewProdu = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCant = new MVCinventario.Style.TxtBox();
            this.txtnameP = new MVCinventario.Style.TxtBox();
            this.txtCode = new MVCinventario.Style.TxtBox();
            this.categoria = new System.Windows.Forms.ComboBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ViewProdu)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewProdu
            // 
            this.ViewProdu.AllowUserToAddRows = false;
            this.ViewProdu.AllowUserToDeleteRows = false;
            this.ViewProdu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.ViewProdu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewProdu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewProdu.Location = new System.Drawing.Point(0, 93);
            this.ViewProdu.Name = "ViewProdu";
            this.ViewProdu.ReadOnly = true;
            this.ViewProdu.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.ViewProdu.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ViewProdu.RowTemplate.Height = 24;
            this.ViewProdu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ViewProdu.Size = new System.Drawing.Size(885, 401);
            this.ViewProdu.TabIndex = 8;
            this.ViewProdu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewProdu_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.txtCant);
            this.panel2.Controls.Add(this.txtnameP);
            this.panel2.Controls.Add(this.txtCode);
            this.panel2.Controls.Add(this.categoria);
            this.panel2.Controls.Add(this.BtnEliminar);
            this.panel2.Controls.Add(this.BtnUpdate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 494);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 183);
            this.panel2.TabIndex = 7;
            // 
            // txtCant
            // 
            this.txtCant.BackColor = System.Drawing.Color.Azure;
            this.txtCant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtCant.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.txtCant.BorderFocusColor = System.Drawing.Color.Fuchsia;
            this.txtCant.Bordersize = 3;
            this.txtCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCant.ForeColor = System.Drawing.Color.Black;
            this.txtCant.Location = new System.Drawing.Point(337, 41);
            this.txtCant.Maxlenght = 4;
            this.txtCant.MultiLine = false;
            this.txtCant.Name = "txtCant";
            this.txtCant.Padding = new System.Windows.Forms.Padding(7);
            this.txtCant.PassWordChar = false;
            this.txtCant.Size = new System.Drawing.Size(191, 35);
            this.txtCant.TabIndex = 44;
            this.txtCant.Texts = "Cantidad";
            this.txtCant.UnderLineStyle = true;
            this.txtCant.Enter += new System.EventHandler(this.txtCant_Enter);
            this.txtCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCant_KeyPress);
            this.txtCant.Leave += new System.EventHandler(this.txtCant_Leave);
            // 
            // txtnameP
            // 
            this.txtnameP.BackColor = System.Drawing.Color.Azure;
            this.txtnameP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtnameP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.txtnameP.BorderFocusColor = System.Drawing.Color.Fuchsia;
            this.txtnameP.Bordersize = 3;
            this.txtnameP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnameP.ForeColor = System.Drawing.Color.Black;
            this.txtnameP.Location = new System.Drawing.Point(53, 112);
            this.txtnameP.Maxlenght = 15;
            this.txtnameP.MultiLine = false;
            this.txtnameP.Name = "txtnameP";
            this.txtnameP.Padding = new System.Windows.Forms.Padding(7);
            this.txtnameP.PassWordChar = false;
            this.txtnameP.Size = new System.Drawing.Size(191, 35);
            this.txtnameP.TabIndex = 43;
            this.txtnameP.Texts = "Nombre Producto";
            this.txtnameP.UnderLineStyle = true;
            this.txtnameP.Enter += new System.EventHandler(this.txtnameP_Enter);
            this.txtnameP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnameP_KeyPress);
            this.txtnameP.Leave += new System.EventHandler(this.txtnameP_Leave);
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.Azure;
            this.txtCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.txtCode.BorderFocusColor = System.Drawing.Color.Fuchsia;
            this.txtCode.Bordersize = 3;
            this.txtCode.Enabled = false;
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.Color.Black;
            this.txtCode.Location = new System.Drawing.Point(53, 41);
            this.txtCode.Maxlenght = 12;
            this.txtCode.MultiLine = false;
            this.txtCode.Name = "txtCode";
            this.txtCode.Padding = new System.Windows.Forms.Padding(7);
            this.txtCode.PassWordChar = false;
            this.txtCode.Size = new System.Drawing.Size(191, 35);
            this.txtCode.TabIndex = 42;
            this.txtCode.Texts = "Codigo";
            this.txtCode.UnderLineStyle = true;
            this.txtCode.Enter += new System.EventHandler(this.txtCode_Enter);
            this.txtCode.Leave += new System.EventHandler(this.txtCode_Leave);
            // 
            // categoria
            // 
            this.categoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoria.BackColor = System.Drawing.Color.Azure;
            this.categoria.CausesValidation = false;
            this.categoria.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoria.FormattingEnabled = true;
            this.categoria.Items.AddRange(new object[] {
            "Tipo",
            "Entregable",
            "No Entregable"});
            this.categoria.Location = new System.Drawing.Point(337, 116);
            this.categoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(191, 28);
            this.categoria.TabIndex = 41;
            this.categoria.SelectedIndexChanged += new System.EventHandler(this.categoria_SelectedIndexChanged);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(591, 41);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(102, 30);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.Green;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F);
            this.BtnUpdate.Location = new System.Drawing.Point(591, 112);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(102, 33);
            this.BtnUpdate.TabIndex = 1;
            this.BtnUpdate.Text = "Actualizar";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 93);
            this.panel1.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Viewproduc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 677);
            this.Controls.Add(this.ViewProdu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Viewproduc";
            this.Text = "Viewproduc";
            this.Load += new System.EventHandler(this.Viewproduc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewProdu)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewProdu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Panel panel1;
        private Style.TxtBox txtCant;
        private Style.TxtBox txtnameP;
        private Style.TxtBox txtCode;
        private System.Windows.Forms.ComboBox categoria;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}