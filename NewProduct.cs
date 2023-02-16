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
    public partial class NewProduct : Form
    {
        ConnexionSql BD = new ConnexionSql();
        ClassGlobal Global = new ClassGlobal();

        public NewProduct()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ValidarCamp();
            BorrarMensaje();
            if (ValidarCamp() == true)
            {
                if (categoria.Text == "Tipo" || categoria.Text == "")
                {
                    MessageBox.Show("Por favor eliga entre (Entregable - No Entregable)");
                }
                else
                {
                    int existencia = BD.ExistenciaProducto(txtCode.Texts);
                    if (existencia >= 1)
                    {
                        MessageBox.Show("El codigo ya ha sido utilizado anteriormente");
                    }
                    else
                    {
                        int intAfectados = BD.InsertProducto(txtCode.Texts, txtnameP.Texts, txtCant.Texts, categoria.Text);
                        if (intAfectados >= 1)
                        {
                            MessageBox.Show("Registrado con exito :)");
                            limpiar();
                        }
                        else
                        {
                            MessageBox.Show("Error en el registro del producto :)");
                        }
                    }
                }
            }           
        }
        private void txtCode_Enter(object sender, EventArgs e)
        {
            if (txtCode.Texts == "Codigo")
            {
                txtCode.Texts = "";
            }
        }
        private void txtCode_Leave(object sender, EventArgs e)
        {
            if (txtCode.Texts == "")
            {
                txtCode.Texts = "Codigo";
            }
        }
        private void txtnameP_Enter(object sender, EventArgs e)
        {
            if(txtnameP.Texts=="Nombre Producto")
            {
                txtnameP.Texts = "";
            }
        }
        private void txtnameP_Leave(object sender, EventArgs e)
        {
            if(txtnameP.Texts=="")
            {
                txtnameP.Texts = "Nombre Producto";
            }
        }
        private void categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(categoria.Text== "No Entregable" )
            {
                txtCant.Enabled = true;
            }
            if (categoria.Text == "Entregable" || categoria.Text == "Tipo")
            {
                txtCant.Enabled = false;
                txtCant.Texts = "1";                 
            }
        }
        private void txtCant_Enter(object sender, EventArgs e)
        {
            if (txtCant.Texts == "Cantidad")
            {
                txtCant.Texts = "";
            }
        }
        private void txtCant_Leave(object sender, EventArgs e)
        {
            if (txtCant.Texts == "")
            {
                txtCant.Texts = "Cantidad";
            }
        }
        public bool ValidarCamp()
        {
            bool ok = true;
            if (txtCode.Texts == "Codigo")
            {
                ok = false;
                errorProvider1.SetError(txtCode, "Campo obligatorio");
            }
            if (txtnameP.Texts == "Nombre Producto")
            {
                ok = false;
                errorProvider1.SetError(txtnameP, "Campo obligatorio");
            }
            if (txtCant.Texts == "Cantidad")
            {
                ok = false;
                errorProvider1.SetError(txtCant, "Campo obligatorio");
            }
            if (txtCant.Texts == "0")
            {
                ok = false;
                errorProvider1.SetError(txtCant, "La cantidad no puede ser (0)");
            }
            return ok;
        }
        public void BorrarMensaje()
        {
            errorProvider1.SetError(txtCode, "");
            errorProvider1.SetError(txtCant, "");
            errorProvider1.SetError(txtnameP, "");
        }
        public void limpiar()
        {
            txtCode.Texts ="Codigo";
            txtnameP.Texts = "Nombre Producto";
            txtCant.Texts = "Cantidad";
            categoria.Text = "Tipo";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult clear = MessageBox.Show("Seguro de borrar los datos ingresados","Alerta",MessageBoxButtons.YesNo);
            if (clear == DialogResult.Yes)
            {
               limpiar();
            }
            
        }
        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validar = Global.SoloNumeros(e);
            if (validar)
            {
                errorProvider1.SetError(txtCode, "Solo Numeros y sin espacio");
            }
            else
            {
                errorProvider1.SetError(txtCode, "");
            }
        }
        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validar = Global.SoloNumeros(e);
            if (validar)
            {
                errorProvider1.SetError(txtCant, "Solo Numeros y sin espacio");
            }
            else
            {
                errorProvider1.SetError(txtCant, "");
            }
        }
        private void txtnameP_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validar = Global.SoloLetras(e);
            if (validar)
            {
                errorProvider1.SetError(txtnameP, "Solo Letras");
            }
            else
            {
                errorProvider1.SetError(txtnameP, "");
            }
        }
    }
}
