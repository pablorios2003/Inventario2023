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
    public partial class UserView : Form
    {
        ConnexionSql BD = new ConnexionSql();
        ClassGlobal Global = new ClassGlobal();


        public UserView()
        {
            InitializeComponent();          
        }

        private void Main_Load(object sender, EventArgs e)
        {
            BD.LIstaUsuarios(ViewUser);           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarCamp() == true)
            {
                if (txtCc.Texts == "Cedula" || txtName.Texts == "Nombre" || txtApellido.Texts == "Apellido"
                    || txtEmail.Texts == "Correo Electronico" || txtCelular.Texts == "Celular" || rol.Text == "" || rol.Text == "Rol")
                {
                    MessageBox.Show("Por favor ingrese Todos los datos :) ");
                }
                else
                {
                    if (ValidarRol())
                    {
                        DialogResult Update = MessageBox.Show("Seguro de actualizar los datos", "Alerta", MessageBoxButtons.YesNo);
                        if (Update == DialogResult.Yes)
                        {
                            BD.UpdateUser(txtName.Texts, txtApellido.Texts, txtCelular.Texts, txtEmail.Texts, rol.Text, txtCc.Texts);
                            MessageBox.Show("Actualizado correctamente");
                            BD.LIstaUsuarios(ViewUser);
                            BorrarMensaje();
                            limpiarCampo();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor digite un rol");
                    }
                }
            }
        }
        public void limpiarCampo()
        {
            txtCc.Texts = "Cedula";
            txtName.Texts = "Nombre";
            txtApellido.Texts = "Apellido";
            txtCelular.Texts = "Celular";
            txtEmail.Texts = "Correo Electronico";
            rol.Text = "Rol";
        }
        private void ViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
              txtCc.Texts = ViewUser.SelectedCells[0].Value.ToString();
              txtName.Texts = ViewUser.SelectedCells[1].Value.ToString();
              txtApellido.Texts = ViewUser.SelectedCells[2].Value.ToString();
              txtCelular.Texts = ViewUser.SelectedCells[3].Value.ToString();
              txtEmail.Texts = ViewUser.SelectedCells[4].Value.ToString();
              rol.Text = ViewUser.SelectedCells[5].Value.ToString();
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCc.Texts == "Cedula")
            {
                MessageBox.Show("Por favor ingrese la cedula del usuario a eliminar");
            }
            else
            {
                DialogResult delete = MessageBox.Show("¿Seguro de eliminar el registro? \n Se perdera para siempre", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delete == DialogResult.Yes)
                {
                    BD.DeleteUser(txtCc.Texts);
                    MessageBox.Show("Borrado exitosamente");
                    BD.LIstaUsuarios(ViewUser);
                    limpiarCampo();
                }
            }
                    
        }
        private void txtCelular_Enter(object sender, EventArgs e)
        {
            if (txtCelular.Texts == "Celular")
            {
                txtCelular.Texts = "";
            }
        }
        private void txtCelular_Leave(object sender, EventArgs e)
        {
            if (txtCelular.Texts == " "|| txtCelular.Texts=="")
            {
                txtCelular.Texts = "Celular";               
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
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Texts == "Correo Electronico")
            {
                txtEmail.Texts = "";
            }
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Texts =="")
            {
                txtEmail.Texts = "Correo Electronico";
            }
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
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                int resultado = BD.FiltrarUsuario(txtBuscar.Texts, ViewUser);
                if (resultado >= 1)
                {
                    BD.FiltrarUsuario(txtBuscar.Texts, ViewUser);
                }
               else
                {
                    txtBuscar.Texts = "";
                    BD.FiltrarUsuario(txtBuscar.Texts, ViewUser);
                    MessageBox.Show("Cedula '" + txtBuscar.Texts + "' no encontrada: ");
                }
                txtBuscar.Texts = "";
                
            }
        }
        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Texts == "Buscar")
            {
                txtBuscar.Texts = "";
            }
        }
        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Texts == "")
            {
                txtBuscar.Texts = "Buscar";
            }
        }
        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Texts == "")
            {
                txtApellido.Texts = "Apellido";
            }
        }
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
            errorProvider1.SetError(txtCc, "");
            errorProvider1.SetError(txtName, "");
            errorProvider1.SetError(txtApellido, "");
            errorProvider1.SetError(txtCelular, "");
            errorProvider1.SetError(txtEmail, "");
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
        private bool ValidarRol()
        {
            if (rol.Text == "1")
            {
                rol.Text = "Aprendiz";
                return true;
            }
            else if (rol.Text == "2")
            {
                rol.Text = "Instructor";
                return true;
            }
            else if (rol.Text == "3")
            {
                rol.Text = "Practicante";
                return true;
            }
            else  if (rol.Text == "Aprendiz" || rol.Text == "Instructor" || rol.Text == "Practicante")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
