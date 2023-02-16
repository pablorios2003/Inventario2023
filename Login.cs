using System;
using System.Windows.Forms;


namespace MVCinventario
{
    public partial class Login : Form
    {
        ConnexionSql BD = new ConnexionSql();
        
         
        public Login()
        {         
            InitializeComponent(); 
        }

        bool vai = false;
        
        private void Login_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }
        private void ver_Click(object sender, EventArgs e)
        {
           ///imagen ocultar la pasamos al frente
            ocultar.BringToFront();
            //mostramos la contraseña
            txtPass.PassWordChar = true; 
        }
        private void ocultar_Click(object sender, EventArgs e)
        {
            //imagen ver la pasamos al frente
            ver.BringToFront();
            //ocultamos la contraseña
            txtPass.PassWordChar = false; 
        }
        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Texts == "CONTRASEÑA")
            {
                txtPass.Texts = "";
                txtPass.PassWordChar = true;
            }
        }
        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Texts == "")
            {
                txtPass.Texts = "CONTRASEÑA";
                txtPass.PassWordChar = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ValidarEntrada();
        }
        public void ValidarEntrada()
        {
            int intExisteCuenta = BD.ValidarCredenciales(txtUsu.Texts, txtPass.Texts);
            if (txtUsu.Texts != "USUARIO")
            {
                if (txtPass.Texts != "CONTRASEÑA")
                {
                    if (intExisteCuenta >= 1)
                    {
                        this.Hide();
                        using (Main view = new Main(txtUsu.Texts))
                            view.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        txtPass.Texts = "CONTRASEÑA";
                        msgError("Usuario y/o contraseña incorrecta.\n Intentelo de nuevo");
                    }
                }
                else msgError("Por favor ingrese la contraseña");
            }
            else msgError("Por favor ingrese el nombre de usuario");
        }
        private void msgError (string msg)
        {
            labelError.Text = " " + msg;
            labelError.Visible = true;
            PictureError.Visible = true;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            using (Recuperar_password view = new Recuperar_password())
            view.ShowDialog();
            this.Close();           
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            vai = true;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (vai == true)
            {
                this.Location = Cursor.Position;
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            vai = false;
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            vai = true;
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (vai == true)
            {
                this.Location = Cursor.Position;
            }
        }
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            vai = false;
        }
        private void txtUsu_Enter(object sender, EventArgs e)
        {
            if(txtUsu.Texts == "USUARIO")
            {
                txtUsu.Texts = "";                
            }
        }
        private void txtUsu_Leave(object sender, EventArgs e)
        {
            if (txtUsu.Texts == "")
            {
                txtUsu.Texts = "USUARIO";                
            }
        }
        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ValidarEntrada();
            }
        }
    }
}


