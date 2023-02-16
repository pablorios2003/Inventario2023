using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCinventario.Style
{ [DefaultEvent("_TextChanged")]
    public partial class TxtBox : UserControl
    {

        //fields
        private Color borderColor = Color.MediumBlue;
        private int bordersize = 2;
        private bool underLineStyle = false;
        private Color borderFocusColor = Color.Black;
        private bool isFocused = false;
        public TxtBox()
        {
            InitializeComponent();
        }

        //Eventos del Campo

        public event EventHandler _TextChanged;


        //Propiedades
        [Category("Estilo Creado")]
        public  Color BorderColor
        { 
           get
            {
                return borderColor; 
            }

            set
            { 

                borderColor = value;
                this.Invalidate();
            }

        }
        [Category("Estilo Creado")]
        public int Bordersize 
        { 
            get
            { 
               return bordersize;
            }

            set 
            {
                bordersize = value;
                this.Invalidate();
            }
        }
        [Category("Estilo Creado")]
        public bool UnderLineStyle 
        { 
            get
            { 
                return underLineStyle;
            }

            set 
            { 
                underLineStyle = value;
                this.Invalidate();
            }

        }

        [Category("Estilo Creado")]
        public int Maxlenght
        {
            get { return textBox1.MaxLength; }
            set { textBox1.MaxLength = value; }
        }

        [Category("Estilo Creado")]
        public bool PassWordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }
        [Category("Estilo Creado")]
        public bool MultiLine
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }
        [Category("Estilo Creado")]
        public override Color BackColor
        {
            
         get 
            {  
               return base.BackColor;
            }
            set
            {  
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }
        [Category("Estilo Creado")]
        public override Color ForeColor  
        {
             get
             { 
               return base.ForeColor;
             }
             set
             {   
                base.ForeColor = value;
                textBox1.ForeColor = value;
            } 
        }

        [Category("Estilo Creado")]
        public override Font Font 
        {
            get 
            {
               return base.Font;
            }

            set
            { 
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }
        [Category("Estilo Creado")]
        public  string Texts
        { 
            get 
            {
               return textBox1.Text; 
            }
            set
            { 
                textBox1.Text = value; 
            }

        }
        [Category("Estilo Creado")]
        public Color BorderFocusColor 
        { 
            get
            { 
                return borderFocusColor;
            }
            set
            {
                borderFocusColor = value;
            }

        }
        

        //override metodos
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            //draw border
            using (Pen penBorder = new Pen(borderColor, bordersize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (!isFocused) 
                {

                    if (underLineStyle)//line style                   
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);                  
                    else //Normal style
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
                else
                {
                    penBorder.Color = borderFocusColor;

                    if (underLineStyle)//line style                   
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else //Normal style
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(this.DesignMode)
            UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.OnMouseDown(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }
    }


}
