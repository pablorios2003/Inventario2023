using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCinventario
{
    public partial class Recuperar_password : Form
    {
        ConnexionSql conexionSql = new ConnexionSql();

        public Recuperar_password()
        {
            InitializeComponent();
        }

        bool mover = false;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if(txtEmail.Texts=="Correo Electronico")
            {
                txtEmail.Texts = "";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Texts == "")
            {
                txtEmail.Texts = "Correo Electronico";
            }
        }

        private void btnName_Enter(object sender, EventArgs e)
        {
            if(btnName.Texts=="Nombre de Usuario")
            {
                btnName.Texts = "";
            }
        }

        private void btnName_Leave(object sender, EventArgs e)
        {
            if (btnName.Texts == "")
            {
                btnName.Texts = "Nombre de Usuario";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
               WindowState = FormWindowState.Minimized;
        }

        private void PanelRecuperar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelRecuperar_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
        }

        private void PanelRecuperar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void PanelRecuperar_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
          int Resultado = conexionSql.CambioPassword(txtEmail.Texts, btnName.Texts);

            if (Resultado > 0)
            {
                OpenHijoForm(new NewPassword(txtEmail.Texts));
                txtEmail.Enabled = false;
                btnName.Enabled = false;
                btnVerificar.Enabled = false;
                btnVerificar.Visible = false;
            }
            else
            {
                MessageBox.Show("No pudimos encontrar al usuario :(");
            }

        }

        private Form activeForm = null;
        private void OpenHijoForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelHijoPass.Controls.Add(childForm);
            PanelHijoPass.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

    }
}
