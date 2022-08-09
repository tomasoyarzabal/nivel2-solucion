using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacion2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.BackColor = Color.Red;
            else
                textBox1.BackColor = System.Drawing.SystemColors.Control;
            if  (textBox2.Text == "")
                textBox2.BackColor = Color.Red;
            else
                textBox2.BackColor = System.Drawing.SystemColors.Control;
            if  (textBox3.Text == "")
                textBox3.BackColor = Color.Red;
            else
                textBox3.BackColor = System.Drawing.SystemColors.Control;
            if (textBox4.Text == "")
                textBox4.BackColor = Color.Red;
            else
                textBox4.BackColor = System.Drawing.SystemColors.Control;

           textBox5.Text =( "apellido y nombre: " + textBox1.Text + textBox2.Text) + (Environment.NewLine + "edad: " + textBox3.Text + " años")+ (Environment.NewLine + "Direccion: " + textBox4.Text);

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
