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
    public partial class DevoPresta : Form
    {
       ConnexionSql BD = new ConnexionSql();
        string ID;
        public DevoPresta()
        {
            InitializeComponent();
            ConfigDatagridView();
        }

        private void DevoPresta_Load(object sender, EventArgs e)
        {
            BD.LIstaPrestamo(ViewPrestamo);
        }
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
               /* int resultado = BD.BuscarPrestamo(ViewPrestamo, txtBuscar.Texts);
                if(resultado == 1)
                { */
                    DataTable dt = BD.TraerDatos(ViewPrestamo,txtBuscar.Texts);
                    txtCode.Texts = dt.Rows[0]["Codigo"].ToString();
                    txtnameP.Texts = dt.Rows[0]["Producto"].ToString();
                    txtCc.Texts = dt.Rows[0]["Cedula"].ToString();
                    txtCantidad.Texts = dt.Rows[0]["cantidad"].ToString();
                    ID = dt.Rows[0]["ID"].ToString();
                    MessageBox.Show(ID);
                /*}
                else if (resultado > 1)
                {
                    MessageBox.Show("Dos");
                }
                else
                {
                    MessageBox.Show("Ningun registro");
                }*/
            }
        }
        public void LimpiarTODO()
        {
            txtCode.Texts = "Codigo";
            txtnameP.Texts = "Nombre Producto";
            txtCantidad.Texts = "Cantidad";
            txtCc.Texts = "Cedula";
            txtName.Texts = "Nombre";
            txtBuscar.Texts = "Buscar";
            txtDevolverCant.Texts = "Cantidad Devolver";
        }
        private void button1_Click(object sender, EventArgs e)
        {

                if(Convert.ToInt32(txtDevolverCant.Texts) > Convert.ToInt32(txtCantidad.Texts))
                {
                    MessageBox.Show("No se puede devolver mas de la cantidad prestada...");
                }
                else
                {
                    addRow(txtCode.Texts, txtnameP.Texts, txtCantidad.Texts,txtDevolverCant.Texts);
                     //BD.InsertDevolucion(ID, txtDevolverCant.Texts, "2003 - 02 - 04", txtCode.Texts);
                    MessageBox.Show("a");
                    LimpiarTODO();
                }                   
                /*int total = ViewPrestamo.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells["Eliminar"].Value) == true).Count();
                if (total > 0)
                {
                    MessageBox.Show(Convert.ToString(total));
                  for (int i = ViewPrestamo.RowCount -1; i >= 0; i--)
                    {
                        DataGridViewRow row = ViewPrestamo.Rows[i];
                        if (Convert.ToBoolean(row.Cells["Eliminar"].Value) == true)
                        {
                            ViewPrestamo.Rows.Remove(row);
                        }
                    }
                }*/
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
        private void txtDevolverCant_Enter(object sender, EventArgs e)
        {
            if (txtDevolverCant.Texts == "Cantidad Devolver")
            {
                txtDevolverCant.Texts = "";
            }
        }
        private void txtDevolverCant_Leave(object sender, EventArgs e)
        {
            if (txtDevolverCant.Texts == "")
            {
                txtDevolverCant.Texts = "Cantidad Devolver";
            }
        }
        private void addRow(string code, string product, string cant, string devolver)
        {
            //Creando una array para guardar informacion en el datagridview
            string[] row = { code, product, cant, devolver };
            VistaDevolucion.Rows.Add(row);
        }
        public void ConfigDatagridView()
        {
            VistaDevolucion.ColumnCount = 4;
            VistaDevolucion.Columns[0].Name = "Codigo";
            VistaDevolucion.Columns[1].Name = "Nombre";
            VistaDevolucion.Columns[2].Name = "Cantidad_Prestada";
            VistaDevolucion.Columns[3].Name = "Devolver";
            VistaDevolucion.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VistaDevolucion.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VistaDevolucion.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VistaDevolucion.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VistaDevolucion.Columns[3].ReadOnly = false;
        }

        private void VistaDevolucion_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void VistaDevolucion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            VistaDevolucion.CurrentCell = VistaDevolucion.CurrentRow.Cells["Devolver"];
            VistaDevolucion.BeginEdit(true);
        }
    }
}
