
namespace MVCinventario
{
    partial class NewPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPassword));
            this.txtConfiPass = new MVCinventario.Style.TxtBox();
            this.TxtNewPass = new MVCinventario.Style.TxtBox();
            this.btnListo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ver = new System.Windows.Forms.PictureBox();
            this.ocultar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocultar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConfiPass
            // 
            this.txtConfiPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.txtConfiPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtConfiPass.BorderColor = System.Drawing.Color.MintCream;
            this.txtConfiPass.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtConfiPass.Bordersize = 3;
            this.txtConfiPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfiPass.ForeColor = System.Drawing.Color.White;
            this.txtConfiPass.Location = new System.Drawing.Point(408, 12);
            this.txtConfiPass.MultiLine = false;
            this.txtConfiPass.Name = "txtConfiPass";
            this.txtConfiPass.Padding = new System.Windows.Forms.Padding(7);
            this.txtConfiPass.PassWordChar = false;
            this.txtConfiPass.Size = new System.Drawing.Size(250, 35);
            this.txtConfiPass.TabIndex = 40;
            this.txtConfiPass.Texts = "Confirmar contraseña";
            this.txtConfiPass.UnderLineStyle = true;
            this.txtConfiPass.Enter += new System.EventHandler(this.txtConfiPass_Enter);
            this.txtConfiPass.Leave += new System.EventHandler(this.txtConfiPass_Leave);
            // 
            // TxtNewPass
            // 
            this.TxtNewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.TxtNewPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TxtNewPass.BorderColor = System.Drawing.Color.MintCream;
            this.TxtNewPass.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtNewPass.Bordersize = 3;
            this.TxtNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNewPass.ForeColor = System.Drawing.Color.White;
            this.TxtNewPass.Location = new System.Drawing.Point(66, 12);
            this.TxtNewPass.MultiLine = false;
            this.TxtNewPass.Name = "TxtNewPass";
            this.TxtNewPass.Padding = new System.Windows.Forms.Padding(7);
            this.TxtNewPass.PassWordChar = false;
            this.TxtNewPass.Size = new System.Drawing.Size(250, 35);
            this.TxtNewPass.TabIndex = 39;
            this.TxtNewPass.Texts = "Nueva contraseña";
            this.TxtNewPass.UnderLineStyle = true;
            this.TxtNewPass.Enter += new System.EventHandler(this.TxtNewPass_Enter);
            this.TxtNewPass.Leave += new System.EventHandler(this.TxtNewPass_Leave);
            // 
            // btnListo
            // 
            this.btnListo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.btnListo.FlatAppearance.BorderSize = 0;
            this.btnListo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.btnListo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnListo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListo.ForeColor = System.Drawing.Color.White;
            this.btnListo.Location = new System.Drawing.Point(308, 83);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(118, 28);
            this.btnListo.TabIndex = 41;
            this.btnListo.Text = "Guardar";
            this.btnListo.UseVisualStyleBackColor = false;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.label1.Location = new System.Drawing.Point(669, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ver
            // 
            this.ver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.ver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ver.Image = ((System.Drawing.Image)(resources.GetObject("ver.Image")));
            this.ver.Location = new System.Drawing.Point(280, 11);
            this.ver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(36, 22);
            this.ver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ver.TabIndex = 42;
            this.ver.TabStop = false;
            this.ver.Click += new System.EventHandler(this.ver_Click);
            // 
            // ocultar
            // 
            this.ocultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.ocultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ocultar.Image = ((System.Drawing.Image)(resources.GetObject("ocultar.Image")));
            this.ocultar.Location = new System.Drawing.Point(280, 12);
            this.ocultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ocultar.Name = "ocultar";
            this.ocultar.Size = new System.Drawing.Size(36, 22);
            this.ocultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ocultar.TabIndex = 43;
            this.ocultar.TabStop = false;
            this.ocultar.Click += new System.EventHandler(this.ocultar_Click);
            // 
            // NewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(5)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(727, 157);
            this.Controls.Add(this.ocultar);
            this.Controls.Add(this.ver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListo);
            this.Controls.Add(this.TxtNewPass);
            this.Controls.Add(this.txtConfiPass);
            this.Name = "NewPassword";
            this.Text = "NewPassword";
            ((System.ComponentModel.ISupportInitialize)(this.ver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocultar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Style.TxtBox txtConfiPass;
        private Style.TxtBox TxtNewPass;
        private System.Windows.Forms.Button btnListo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ver;
        private System.Windows.Forms.PictureBox ocultar;
    }
}