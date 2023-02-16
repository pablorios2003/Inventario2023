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
    public partial class Viewproduc : Form
    {
        ConnexionSql BD = new ConnexionSql();
        ClassGlobal Global = new ClassGlobal();
        public Viewproduc()
        {
            InitializeComponent();
        }

        private void Viewproduc_Load(object sender, EventArgs e)
        {
            BD.LIstaProducto(ViewProdu);
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidarCamp() == true)
            {
                if (categoria.Text == "" || categoria.Text == "Tipo")
                {
                    MessageBox.Show("Por favor ingrese una categoria entre (Entregable - No Entregable)");
                }
                else
                {
                    DialogResult UPDATE = MessageBox.Show("¿Seguro que desea actualizar el registro?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (UPDATE == DialogResult.Yes)
                    {
                        BD.UpdateProducto(txtCode.Texts, txtnameP.Texts, txtCant.Texts, categoria.Text);
                        MessageBox.Show("Actualizado con exito");
                        limpiar();
                        BorrarMensaje();
                        BD.LIstaProducto(ViewProdu);
                    }
                }
            }
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult Delete = MessageBox.Show("¿Seguro de eliminar el registro? \n se perdera para siempre","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);          
            if(Delete == DialogResult.Yes)
            {
                BD.DeleteProdu(txtCode.Texts);
                MessageBox.Show("Borrado exitosamente");
                BD.LIstaProducto(ViewProdu);
                limpiar();
            }           
        }
        public void limpiar()
        {
            txtCode.Texts = "Codigo";
            txtnameP.Texts = "Nombre Producto";
            txtCant.Texts = "Cantidad";
            categoria.Text = "Tipo";
        }
        private void ViewProdu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Texts = ViewProdu.SelectedCells[0].Value.ToString();
            txtnameP.Texts = ViewProdu.SelectedCells[1].Value.ToString();
            txtCant.Texts = ViewProdu.SelectedCells[2].Value.ToString();
            categoria.Text = ViewProdu.SelectedCells[3].Value.ToString();
        }
        private void categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoria.Text == "Entregable")
            {
                txtCant.Texts = "1";
                txtCant.Enabled = false;
            }
            else
                txtCant.Enabled = true;
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
            if (txtnameP.Texts == "Nombre Producto")
            {
                txtnameP.Texts = "";
            }
        }
        private void txtnameP_Leave(object sender, EventArgs e)
        {
            if (txtnameP.Texts =="")
            {
                txtnameP.Texts = "Nombre Producto";
            }
        }
        private void txtCant_Leave(object sender, EventArgs e)
        {
            if (txtCant.Texts == "")
            {
                txtCant.Texts = "Cantidad";
            }
        }
        private void txtCant_Enter(object sender, EventArgs e)
        {
            if (txtCant.Texts == "Cantidad")
            {
                txtCant.Texts = "";
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
