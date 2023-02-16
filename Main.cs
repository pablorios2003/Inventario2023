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
    public partial class Main : Form
    {
        public Main(string Saludo)
        {
            InitializeComponent();          
            BtnSaludo.Text = "Bienvenido " + Saludo;
            PersonalizarDiseño();
        }

        private void PersonalizarDiseño ()
        {
            //Ocultar los submenus de cada categoria
            PanelSubUsu.Visible = false;
            panelSubProduct.Visible = false;
            panelSubPrestar.Visible = false;
        }     
        private void HideSubmenu()
        {
            if (PanelSubUsu.Visible == true)
                PanelSubUsu.Visible = false;
            if (panelSubProduct.Visible == true)
                panelSubProduct.Visible = false;
            if (panelSubPrestar.Visible == true)
                panelSubPrestar.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #region     
        private void BtnUser_Click_1(object sender, EventArgs e)
        {
            showSubMenu(PanelSubUsu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Codigo
            OpenHijoForm(new NewUser());
            HideSubmenu();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Codigo
            OpenHijoForm(new UserView());
            HideSubmenu();
        }
#endregion
        #region Producto
        private void BtnProdu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubProduct);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            // Codigo
            OpenHijoForm(new NewProduct());
            HideSubmenu();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            // Codigo
            OpenHijoForm(new Viewproduc());
            HideSubmenu();
        }
        #endregion
        #region Prestamo
        private void BtnPres_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubPrestar);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Codigo
            OpenHijoForm(new RegistroPrestamo());
            HideSubmenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Codigo
            OpenHijoForm(new DevoPresta());
            HideSubmenu();
        }
        #endregion
        private Form activeForm = null;
        private void OpenHijoForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(childForm);
            panelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
