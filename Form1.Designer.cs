namespace miAppBotones
{
    partial class Form1
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
            this.barraProgreso1 = new BotonesMusica.Botones.BarraProgreso();
            this.botonAnterior1 = new BotonesMusica.Botones.BotonAnterior();
            this.botonArchivos1 = new BotonesMusica.Botones.BotonArchivos();
            this.botonCerrar1 = new bibliotecabutton.botones.BotonCerrar();
            this.botonPlay1 = new BotonesMusica.Botones.BotonPlay();
            this.botonSiguiente1 = new BotonesMusica.Botones.BotonSiguiente();
            this.notaMusical1 = new BotonesMusica.Botones.NotaMusical();
            this.SuspendLayout();
            // 
            // barraProgreso1
            // 
            this.barraProgreso1.DuracionTotalSegundos = 225;
            this.barraProgreso1.Location = new System.Drawing.Point(13, 264);
            this.barraProgreso1.Maximo = 100;
            this.barraProgreso1.Name = "barraProgreso1";
            this.barraProgreso1.Progreso = 0;
            this.barraProgreso1.Size = new System.Drawing.Size(300, 25);
            this.barraProgreso1.TabIndex = 0;
            this.barraProgreso1.Text = "barraProgreso1";
            // 
            // botonAnterior1
            // 
            this.botonAnterior1.BackColor = System.Drawing.Color.Transparent;
            this.botonAnterior1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAnterior1.FlatAppearance.BorderSize = 0;
            this.botonAnterior1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAnterior1.ForeColor = System.Drawing.Color.White;
            this.botonAnterior1.Location = new System.Drawing.Point(52, 325);
            this.botonAnterior1.Name = "botonAnterior1";
            this.botonAnterior1.Size = new System.Drawing.Size(50, 50);
            this.botonAnterior1.TabIndex = 1;
            this.botonAnterior1.Text = "botonAnterior1";
            this.botonAnterior1.UseVisualStyleBackColor = false;
            // 
            // botonArchivos1
            // 
            this.botonArchivos1.BackColor = System.Drawing.Color.Transparent;
            this.botonArchivos1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonArchivos1.FlatAppearance.BorderSize = 0;
            this.botonArchivos1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonArchivos1.ForeColor = System.Drawing.Color.White;
            this.botonArchivos1.Location = new System.Drawing.Point(52, 31);
            this.botonArchivos1.Name = "botonArchivos1";
            this.botonArchivos1.Size = new System.Drawing.Size(50, 49);
            this.botonArchivos1.TabIndex = 2;
            this.botonArchivos1.Text = "botonArchivos1";
            this.botonArchivos1.UseVisualStyleBackColor = false;
            this.botonArchivos1.Click += new System.EventHandler(this.botonArchivos1_Click);
            // 
            // botonCerrar1
            // 
            this.botonCerrar1.BackColor = System.Drawing.Color.Transparent;
            this.botonCerrar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCerrar1.FlatAppearance.BorderSize = 0;
            this.botonCerrar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCerrar1.ForeColor = System.Drawing.Color.White;
            this.botonCerrar1.Location = new System.Drawing.Point(224, 31);
            this.botonCerrar1.Name = "botonCerrar1";
            this.botonCerrar1.Size = new System.Drawing.Size(51, 49);
            this.botonCerrar1.TabIndex = 3;
            this.botonCerrar1.Text = "botonCerrar1";
            this.botonCerrar1.UseVisualStyleBackColor = false;
            this.botonCerrar1.Click += new System.EventHandler(this.botonCerrar1_Click);
            // 
            // botonPlay1
            // 
            this.botonPlay1.BackColor = System.Drawing.Color.Transparent;
            this.botonPlay1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonPlay1.FlatAppearance.BorderSize = 0;
            this.botonPlay1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPlay1.ForeColor = System.Drawing.Color.LimeGreen;
            this.botonPlay1.Location = new System.Drawing.Point(137, 325);
            this.botonPlay1.Name = "botonPlay1";
            this.botonPlay1.Size = new System.Drawing.Size(50, 49);
            this.botonPlay1.TabIndex = 4;
            this.botonPlay1.Text = "botonPlay1";
            this.botonPlay1.UseVisualStyleBackColor = false;
            // 
            // botonSiguiente1
            // 
            this.botonSiguiente1.BackColor = System.Drawing.Color.Transparent;
            this.botonSiguiente1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonSiguiente1.FlatAppearance.BorderSize = 0;
            this.botonSiguiente1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonSiguiente1.ForeColor = System.Drawing.Color.White;
            this.botonSiguiente1.Location = new System.Drawing.Point(224, 324);
            this.botonSiguiente1.Name = "botonSiguiente1";
            this.botonSiguiente1.Size = new System.Drawing.Size(51, 50);
            this.botonSiguiente1.TabIndex = 5;
            this.botonSiguiente1.Text = "botonSiguiente1";
            this.botonSiguiente1.UseVisualStyleBackColor = false;
            // 
            // notaMusical1
            // 
            this.notaMusical1.Location = new System.Drawing.Point(100, 106);
            this.notaMusical1.Name = "notaMusical1";
            this.notaMusical1.Size = new System.Drawing.Size(132, 133);
            this.notaMusical1.TabIndex = 6;
            this.notaMusical1.Text = "notaMusical1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 450);
            this.Controls.Add(this.notaMusical1);
            this.Controls.Add(this.botonSiguiente1);
            this.Controls.Add(this.botonPlay1);
            this.Controls.Add(this.botonCerrar1);
            this.Controls.Add(this.botonArchivos1);
            this.Controls.Add(this.botonAnterior1);
            this.Controls.Add(this.barraProgreso1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private BotonesMusica.Botones.BarraProgreso barraProgreso1;
        private BotonesMusica.Botones.BotonAnterior botonAnterior1;
        private BotonesMusica.Botones.BotonArchivos botonArchivos1;
        private bibliotecabutton.botones.BotonCerrar botonCerrar1;
        private BotonesMusica.Botones.BotonPlay botonPlay1;
        private BotonesMusica.Botones.BotonSiguiente botonSiguiente1;
        private BotonesMusica.Botones.NotaMusical notaMusical1;
    }
}

