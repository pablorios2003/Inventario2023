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
    public partial class NewPassword : Form
    {
        ConnexionSql extencion = new ConnexionSql();
        public NewPassword(string Email)
        {
            InitializeComponent();
            
            label1.Text = Email;
        }


        private void btnListo_Click(object sender, EventArgs e)
        {
            string[] words = { TxtNewPass.Texts };
            int length = words.Min(x => x.Length);
            if (length > 4)
            {

                if (TxtNewPass.Texts == txtConfiPass.Texts)
                {
                    extencion.UpdatePassword(label1.Text, TxtNewPass.Texts);
                    MessageBox.Show("la contreña se guardo exitosamente");
                    using (Login volver = new Login())
                        volver.ShowDialog();
                }
                else
                    MessageBox.Show("La contraseña no coinciden");
            }
            else
                MessageBox.Show("La contraseña debe conter mas de 4 caratecres");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtNewPass_Enter(object sender, EventArgs e)
        {
            if(TxtNewPass.Texts=="Nueva contraseña")
            {
                TxtNewPass.Texts = "";
                TxtNewPass.PassWordChar = true;
            }
        }

        private void TxtNewPass_Leave(object sender, EventArgs e)
        {
            if(TxtNewPass.Texts == "")
            {
                TxtNewPass.Texts = "Nueva contraseña";
                TxtNewPass.PassWordChar = false;
            }
        }

        private void txtConfiPass_Enter(object sender, EventArgs e)
        {
            if (txtConfiPass.Texts == "Confirmar contraseña")
            {
                txtConfiPass.Texts = "";
                txtConfiPass.PassWordChar = true;
            }
        }

        private void txtConfiPass_Leave(object sender, EventArgs e)
        {
            if (txtConfiPass.Texts == "")
            {
                txtConfiPass.Texts = "Confirmar contraseña";
                txtConfiPass.PassWordChar = false; 
            }
        }

        private void ver_Click(object sender, EventArgs e)
        {
            ///imagen ocultar la pasamos al frente
            ocultar.BringToFront();
            //mostramos la contraseña
            TxtNewPass.PassWordChar = true;
        }

        private void ocultar_Click(object sender, EventArgs e)
        {
            //imagen ver la pasamos al frente
            ver.BringToFront();
            //ocultamos la contraseña
            TxtNewPass.PassWordChar = false;
        }
    }
}
