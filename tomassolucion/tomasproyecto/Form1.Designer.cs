
namespace tomasproyecto
{
    partial class Ventana
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.boton1 = new System.Windows.Forms.Button();
            this.Etiqueta1 = new System.Windows.Forms.Label();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // boton1
            // 
            this.boton1.BackColor = System.Drawing.Color.LightCoral;
            this.boton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton1.Image = global::tomasproyecto.Properties.Resources.png_transparent_pink_clothes_button_button_t_shirt_clothing_button_purple_tshirt_cloth_thumbnail;
            this.boton1.Location = new System.Drawing.Point(297, 203);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(181, 61);
            this.boton1.TabIndex = 0;
            this.boton1.Text = "boton";
            this.boton1.UseVisualStyleBackColor = false;
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // Etiqueta1
            // 
            this.Etiqueta1.AutoSize = true;
            this.Etiqueta1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Etiqueta1.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta1.ForeColor = System.Drawing.SystemColors.Control;
            this.Etiqueta1.Location = new System.Drawing.Point(348, 121);
            this.Etiqueta1.Name = "Etiqueta1";
            this.Etiqueta1.Size = new System.Drawing.Size(65, 29);
            this.Etiqueta1.TabIndex = 1;
            this.Etiqueta1.Text = "Etiqueta";
            this.Etiqueta1.MouseLeave += new System.EventHandler(this.Etiqueta1_MouseLeave);
            this.Etiqueta1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Etiqueta1_MouseMove);
            // 
            // textbox1
            // 
            this.textbox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textbox1.Location = new System.Drawing.Point(297, 309);
            this.textbox1.MaxLength = 25;
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(191, 20);
            this.textbox1.TabIndex = 2;
            this.textbox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(297, 356);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox2.Size = new System.Drawing.Size(190, 23);
            this.textBox2.TabIndex = 3;
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.Etiqueta1);
            this.Controls.Add(this.boton1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ventana";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ventana_FormClosed);
            this.Load += new System.EventHandler(this.Ventana_Load);
            this.Click += new System.EventHandler(this.boton1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Label Etiqueta1;
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

