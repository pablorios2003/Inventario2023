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
    public partial class RegistroPrestamo : Form
    {
        ConnexionSql BD = new ConnexionSql();
        ClassGlobal Global = new ClassGlobal();
        
        public RegistroPrestamo()
        {
            InitializeComponent();
            DatagridConfig();
        }

        public void Buscar()
        {
            //Validando que el campo tenga un dato a buscar
            if (txtBuscar.Texts != "Buscar")
            {     //Validando si existe un Producto con el dato a buscar
                int BuscarProducto = BD.ExistenciaProducto(txtBuscar.Texts);
                if (BuscarProducto >= 1)
                {

                    DataTable dt = BD.TraerProducto(txtBuscar.Texts);
                    txtCode.Texts = dt.Rows[0]["codigoP"].ToString();
                    txtnameP.Texts = dt.Rows[0]["nomP"].ToString();
                    txtDispo.Texts = dt.Rows[0]["stock"].ToString();
                    categoria.Texts = dt.Rows[0]["categoria"].ToString();
                }
                else
                {   //Validando si existe un Usuario con el dato a buscar
                    int buscarUsuario = BD.ExistenciaUsuario(txtBuscar.Texts);
                    if (buscarUsuario >= 1)
                    {
                        DataTable dt = BD.TraerUsuario(txtBuscar.Texts);
                        txtCc.Texts = dt.Rows[0]["Cedula"].ToString();
                        txtName.Texts = dt.Rows[0]["nomU"].ToString();
                        txtApellido.Texts = dt.Rows[0]["apelliU"].ToString();
                        txtCelular.Texts = dt.Rows[0]["celular"].ToString();
                        txtEmail.Texts = dt.Rows[0]["emailU"].ToString();
                        rol.Texts = dt.Rows[0]["id_rol"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se encontro informacion con los datos :" + txtBuscar.Texts);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese el dato a buscar");
            }
            //Validaciones Para la cantidad del producto dependiendo de la categoria
            if (categoria.Text == "No Entregable" || categoria.Text =="" || categoria.Text =="Categoria")
            {
                txtCantidad.Enabled = true;
            }
            else
            {
                txtCantidad.Texts = "1";
                txtCantidad.Enabled = false;

            }
        }
        private void Lupa_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        public void LimpiarPRODUCTO()
        {
            txtCode.Texts = "Codigo";
            txtnameP.Texts = "Nombre Producto";
            txtDispo.Texts = "Disponible";
            categoria.Texts = "Categoria";
        }
        public void LimpiarTODO()
        {
            txtCode.Texts = "Codigo";
            txtnameP.Texts = "Nombre Producto";
            txtDispo.Texts = "Disponible";
            categoria.Texts = "Categoria";
            txtCantidad.Texts = "Cantidad";
            txtCc.Texts = "Cedula";
            txtName.Texts = "Nombre";
            txtApellido.Texts = "Apellido";
            txtCelular.Texts = "Celular";
            txtEmail.Texts = "Correo Electronico";
            rol.Texts = "Rol";
        }
        private void RegistroPrestamo_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            txtState.Texts = "Activo";
            txtState.Enabled = false;         
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
             //Asignando la hora a un label y la fecha actual a un campo de texto
            labelHora.Text = DateTime.Now.ToString("hh:mm:ss");
            txtFecha.Texts = DateTime.Now.ToString("yyyy-MM-dd");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ( txtCantidad.Texts=="Cantidad" || Convert.ToInt32(txtCantidad.Texts) > Convert.ToInt32(txtDispo.Texts))
            {
                MessageBox.Show("No se tiene la cantidad deseada o no es un formato valido...");
            }
            else if (txtCode.Texts != "Codigo" && txtCantidad.Texts != "Cantidad")
            {
                addRow(txtCode.Texts, txtnameP.Texts, txtCantidad.Texts, categoria.Texts);              
                //Validando que los datos esten completos
                if (txtCc.Texts == "Cedula")
                {
                    MessageBox.Show("Todos los datos son necesario \n Por favor llenar todos los campos");
                }
                else
                {
                    //Insertando los datos al prestamo
                    BD.insertPrestamo(txtFecha.Texts, txtCc.Texts, VistaPrestamos);
                    MessageBox.Show("Prestamo realizado con exito");
                    VistaPrestamos.Rows.Clear();
                    LimpiarTODO();
                }
            }
            else if (VistaPrestamos.Rows.Count <= 0)
            {
              //Enviando la informacion al datagridview 
               ValidarCamp();
            }     
        }
        //Asignando los campos de entrada para el datagridview
        private void addRow(string codigo, string nombre,string cantidad,string categoria)
        {
            //Creando una array para guardar informacion en el datagridview
            string[] row = { codigo, nombre, cantidad, categoria };
            VistaPrestamos.Rows.Add(row);
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
        //int total = VistaPrestamos.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells["Eliminar"].Value) == true).Count();
            DialogResult Result = MessageBox.Show("¿Seguro de eliminar?'", "Alerta", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                /*for(int i = VistaPrestamos.RowCount -1; i >= 0; i--)
                {
                    DataGridViewRow row = VistaPrestamos.Rows [i];
                    if (Convert.ToBoolean(row.Cells["Eliminar"].Value) == true)
                    {
                        VistaPrestamos.Rows.RemoveAt(total);
                    }
                }                   
                Eliminando filla del datagridview */
                VistaPrestamos.Rows.RemoveAt(VistaPrestamos.CurrentCell.RowIndex);
            }           
        }
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {           
            if (Global.SoloNumeros(e))
            {
                errorProvider1.SetError(txtBuscar, "Solo Numeros ");
            }
            else
            {
                errorProvider1.SetError(txtBuscar, "");
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Buscar();
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
        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            if (txtCantidad.Texts == "Cantidad")
            {
                txtCantidad.Texts = "";
            }
        }
        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (txtCantidad.Texts == "")
            {
                txtCantidad.Texts = "Cantidad";
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int CantidadProducto = 0;
            //Validando que la cantidad a prestar sea inferior o igual a la disponible
            if (ValidarCamp()==true)
            {                
                int Cant = Convert.ToInt32(txtCantidad.Texts);
                if (Convert.ToInt32(txtDispo.Texts) <Cant)
                {
                    MessageBox.Show("La cantidad deseada es superior a la disponible");
                }
                else
                {
                    if (0 >= Convert.ToInt32(txtCantidad.Texts))
                    {
                        MessageBox.Show("La cantidad no puede ser menor o igual a 0");
                    }
                    else
                    {
                        foreach (DataGridViewRow row in VistaPrestamos.Rows)
                        {
                            if (Convert.ToString(row.Cells["Codigo"].Value) == txtCode.Texts)
                            {
                                CantidadProducto += Convert.ToInt32(row.Cells["Cantidad"].Value);
                            }
                        }
                        int total = Cant + CantidadProducto;
                        if(total > Convert.ToInt32(txtDispo.Texts))
                        {
                            MessageBox.Show("No se puede'"+total+"'");
                        }
                        else
                        {                           
                            addRow(txtCode.Texts, txtnameP.Texts, txtCantidad.Texts, categoria.Texts);
                            LimpiarPRODUCTO();
                            txtCantidad.Texts = "Cantidad";
                        }
                        //Pasando los datos al gridview       
                    }
                }
            }
        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validar = Global.SoloNumeros(e);
            if (validar)
            {
                errorProvider1.SetError(txtCantidad, "Solo Numeros ");
            }
            else
            {
                errorProvider1.SetError(txtCantidad, "");
            }
        }
        public bool ValidarCamp()
        {
            bool ok = true;
            if (txtCantidad.Texts == "Cantidad")
            {
                ok = false;
                errorProvider1.SetError(txtCantidad, "Campo obligatorio");
            }
           else if (txtCantidad.Texts == "")
            {
                ok = false;
                errorProvider1.SetError(txtCantidad, "Campo obligatorio");
            }
           else if (0 >= Convert.ToInt32(txtCantidad.Texts))
            {
                ok = false;
                errorProvider1.SetError(txtCantidad, "La cantidad no puede ser menor o igual a 0");
            }
            if (txtDispo.Texts == "Disponible")
            {
                ok = false;
                errorProvider1.SetError(txtCode, "Dato necesario para agregar");
            }
            return ok;
        }
        public void DatagridConfig()
        {
            //Iniciando el form con columnas predeterminadas y autosize
            VistaPrestamos.ColumnCount = 4;
            VistaPrestamos.Columns[0].Name = "Codigo";
            VistaPrestamos.Columns[1].Name = "Nombre";
            VistaPrestamos.Columns[2].Name = "Cantidad";
            VistaPrestamos.Columns[3].Name = "Categoria";
            VistaPrestamos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VistaPrestamos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VistaPrestamos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VistaPrestamos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
