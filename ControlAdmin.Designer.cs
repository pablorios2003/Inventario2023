
namespace MVCinventario
{
    partial class ControlAdmin
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
            this.ViewUser = new System.Windows.Forms.DataGridView();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TxtName = new MVCinventario.Style.TxtBox();
            this.txtPass = new MVCinventario.Style.TxtBox();
            this.TxtCorreo = new MVCinventario.Style.TxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.ViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewUser
            // 
            this.ViewUser.AllowUserToAddRows = false;
            this.ViewUser.AllowUserToDeleteRows = false;
            this.ViewUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.ViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.ViewUser.Location = new System.Drawing.Point(0, 0);
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
            this.ViewUser.Size = new System.Drawing.Size(699, 183);
            this.ViewUser.TabIndex = 6;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(401, 189);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(86, 39);
            this.BtnUpdate.TabIndex = 7;
            this.BtnUpdate.Text = "Actualizar";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(293, 345);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(86, 40);
            this.BtnInsert.TabIndex = 8;
            this.BtnInsert.Text = "Agregar";
            this.BtnInsert.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(309, 189);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(86, 39);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.TxtName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TxtName.BorderColor = System.Drawing.Color.Aqua;
            this.TxtName.BorderFocusColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtName.Bordersize = 3;
            this.TxtName.Enabled = false;
            this.TxtName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.ForeColor = System.Drawing.Color.White;
            this.TxtName.Location = new System.Drawing.Point(219, 290);
            this.TxtName.Maxlenght = 32767;
            this.TxtName.MultiLine = false;
            this.TxtName.Name = "TxtName";
            this.TxtName.Padding = new System.Windows.Forms.Padding(7);
            this.TxtName.PassWordChar = false;
            this.TxtName.Size = new System.Drawing.Size(160, 34);
            this.TxtName.TabIndex = 78;
            this.TxtName.Texts = "Nombre de Usuario";
            this.TxtName.UnderLineStyle = true;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.txtPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtPass.BorderColor = System.Drawing.Color.Aqua;
            this.txtPass.BorderFocusColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPass.Bordersize = 3;
            this.txtPass.Enabled = false;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.White;
            this.txtPass.Location = new System.Drawing.Point(420, 289);
            this.txtPass.Maxlenght = 32767;
            this.txtPass.MultiLine = false;
            this.txtPass.Name = "txtPass";
            this.txtPass.Padding = new System.Windows.Forms.Padding(7);
            this.txtPass.PassWordChar = false;
            this.txtPass.Size = new System.Drawing.Size(159, 35);
            this.txtPass.TabIndex = 77;
            this.txtPass.Texts = "Contraseña";
            this.txtPass.UnderLineStyle = true;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.TxtCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TxtCorreo.BorderColor = System.Drawing.Color.Aqua;
            this.TxtCorreo.BorderFocusColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtCorreo.Bordersize = 3;
            this.TxtCorreo.Enabled = false;
            this.TxtCorreo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreo.ForeColor = System.Drawing.Color.White;
            this.TxtCorreo.Location = new System.Drawing.Point(21, 290);
            this.TxtCorreo.Maxlenght = 32767;
            this.TxtCorreo.MultiLine = false;
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Padding = new System.Windows.Forms.Padding(7);
            this.TxtCorreo.PassWordChar = false;
            this.TxtCorreo.Size = new System.Drawing.Size(159, 34);
            this.TxtCorreo.TabIndex = 76;
            this.TxtCorreo.Texts = "Email";
            this.TxtCorreo.UnderLineStyle = true;
            // 
            // ControlAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 406);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.ViewUser);
            this.Name = "ControlAdmin";
            this.Text = "ControlAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.ViewUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewUser;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnDelete;
        private Style.TxtBox TxtName;
        private Style.TxtBox txtPass;
        private Style.TxtBox TxtCorreo;
    }
}