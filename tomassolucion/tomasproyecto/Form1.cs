using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tomasproyecto
{
    public partial class Ventana : Form
    {
        public Ventana()
        {
            InitializeComponent();
        }

        private void Ventana_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a C#");
        }

        private void Ventana_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("chau chau...");
        }

        private void boton1_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("se disparo el evento click, Atencion");
            //this.BackColor = Color.Blue;
            //MouseEventArgs click = (MouseEventArgs)e;
            //if (click.Button == MouseButtons.Left)
            //    MessageBox.Show("Presiono el botón Izquierdo", "Atención");
            //else if (click.Button == MouseButtons.Right)
            //    MessageBox.Show("Presiono el Botón Derecho", "Atención");
            //else
            //if (click.Button == MouseButtons.Middle)
            //    MessageBox.Show("Presiono el botón del Medio", "Atención");

            //código para cambiar el color de fondo del TextBox
            //(Propiedad BackColor) si el TextBox se encuentra vació.
                if (textbox1.Text == "")
                    textbox1.BackColor = Color.Red;
                else
                    textbox1.BackColor = System.Drawing.SystemColors.Control;

            
        }

        

        private void Etiqueta1_MouseMove(object sender, MouseEventArgs e)
        {
         Etiqueta1.BackColor = Color.Blue;
          Etiqueta1.Cursor = Cursors.Hand;
        }

        private void Etiqueta1_MouseLeave(object sender, EventArgs e)
        {
          Etiqueta1.BackColor = System.Drawing.SystemColors.Control;
          Etiqueta1.Cursor = Cursors.Arrow;
        }

        private void textbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 47|| e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + textBox2.Text.Length + " Caracteres");
        }
    }
        
       
           

        
    
}
