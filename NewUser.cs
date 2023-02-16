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
    public partial class NewUser : Form
    {
        ConnexionSql BD = new ConnexionSql();
        ClassGlobal Global = new ClassGlobal();

        public NewUser()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            ValidarCamp();
            if(ValidarCamp() == true) 
            { 
                if(rol.Text == "Rol" || rol.Text == "")
                {
                    MessageBox.Show("Por favor ingresar un Rol valido...");
                }
                else
                {
                    int Exitencia = BD.ExistenciaUsuario(txtCc.Texts);
                    if(Exitencia >= 1)
                    {
                        MessageBox.Show("Numero de cedula ya registrado","Exitoso");
                    }
                    else
                    {
                        DialogResult registrar = MessageBox.Show("¿Seguro de la informacion ingresada?","Aviso",MessageBoxButtons.YesNo);
                        if (registrar == DialogResult.Yes)
                        {
                            BD.insertUser(txtCc.Texts, txtName.Texts, txtApellido.Texts, txtCelular.Texts, txtEmail.Texts, rol.Text);
                            MessageBox.Show("Registrado con exito");
                            limpiarCampo();
                        }
                    }
                }
            }
        }
        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validar = Global.SoloNumeros(e);
            if (validar)
            {
                errorProvider1.SetError(txtCelular, "Solo Numeros y sin espacio");
            }
            else
            {
                errorProvider1.SetError(txtCelular, "");
            }          
        }
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validar = Global.SoloLetras(e);
            if (validar)
            {               
                errorProvider1.SetError(txtName, "Solo Letras");
                return;
            }
            else
            {
                errorProvider1.SetError(txtName, "");
            }
        }
        private void txtCc_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validar = Global.SoloNumeros(e);
            if (validar)
            {
                errorProvider1.SetError(txtCc, "Solo Numeros ");
            }
            else
            {
                errorProvider1.SetError(txtCc, "");
            }
        }
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validar = Global.SoloLetras(e);
            if (validar)
            {               
                errorProvider1.SetError(txtApellido, "Solo Letras");         
            }
            else
            {
                errorProvider1.SetError(txtApellido, "");
            }
        }
        //Creamos un metodo para limpiar los campos       
        public void limpiarCampo()
        {
            txtCc.Texts = "Cedula";
            txtName.Texts = "Nombre";
            txtApellido.Texts = "Apellido";
            txtCelular.Texts = "Celular";
            txtEmail.Texts = "Correo Electronico";
            rol.Text = "Rol";
        }
        //Validamos que los campos esten rellenos
        public bool ValidarCamp()
        {
            bool ok = true;
            if (txtCc.Texts == "Cedula")
            {
                ok = false;
                errorProvider1.SetError(txtCc, "Campo obligatorio");
            }
            if (txtName.Texts == "Nombre")
            {
                ok = false;
                errorProvider1.SetError(txtName, "Campo obligatorio");
            }
            if (txtApellido.Texts == "Apellido")
            {
                ok = false;
                errorProvider1.SetError(txtApellido, "Campo obligatorio");
            }
            if (txtCelular.Texts == "Celular")
            {
                ok = false;
                errorProvider1.SetError(txtCelular, "Campo obligatorio");
            }
            if (!Global.ValidarEmail(txtEmail.Texts))
            {
                ok = false;
                errorProvider1.SetError(txtEmail, "Formato no valido");
            }

            return ok;
        }
        //Borramos el mensaje de error
        public void BorrarMensaje()
        {
            errorProvider1.SetError(txtCc,"");
            errorProvider1.SetError(txtName,"");
            errorProvider1.SetError(txtApellido,"");
            errorProvider1.SetError(txtCelular,"");
            errorProvider1.SetError(txtEmail,"");
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult limpiar = MessageBox.Show("¿Seguro de eliminar toda la informacion?", "Alerta", MessageBoxButtons.YesNo);
            if (limpiar == DialogResult.Yes)
                limpiarCampo();
        }
        private void txtCelular_Leave(object sender, EventArgs e)
        {
            if (txtCelular.Texts == "")
            {
                txtCelular.Texts = "Celular";
            }
        }
        private void txtCelular_Enter(object sender, EventArgs e)
        {
            if (txtCelular.Texts == "Celular")
            {
                txtCelular.Texts = "";
            }
        }
        private void txtCc_Enter(object sender, EventArgs e)
        {
            if (txtCc.Texts == "Cedula")
            {
                txtCc.Texts = "";
            }
        }
        private void txtCc_Leave(object sender, EventArgs e)
        {
            if (txtCc.Texts == "")
            {
                txtCc.Texts = "Cedula";
            }
        }
        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Texts == "Nombre")
            {
                txtName.Texts = "";
            }
        }
        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Texts == "")
            {
                txtName.Texts = "Nombre";
            }
        }
        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Texts == "Apellido")
            {
                txtApellido.Texts = "";
            }
        }
        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Texts == "")
            {
                txtApellido.Texts = "Apellido";
            }
        }
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Texts == "Correo Electronico")
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
            if (!Global.ValidarEmail(txtEmail.Texts))
            {
                errorProvider1.SetError(txtEmail, "Correo no valido");
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }
        }
    }
}
