namespace Practica02
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtBoxPalabra = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lstPalabra = new System.Windows.Forms.ListBox();
            this.btnContar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(74, 384);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(127, 40);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtBoxPalabra
            // 
            this.txtBoxPalabra.Location = new System.Drawing.Point(112, 47);
            this.txtBoxPalabra.Name = "txtBoxPalabra";
            this.txtBoxPalabra.Size = new System.Drawing.Size(337, 20);
            this.txtBoxPalabra.TabIndex = 1;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(46, 47);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(37, 15);
            this.lblTexto.TabIndex = 2;
            this.lblTexto.Text = "Texto";
            this.lblTexto.Click += new System.EventHandler(this.label1_Click);
            // 
            // lstPalabra
            // 
            this.lstPalabra.FormattingEnabled = true;
            this.lstPalabra.Location = new System.Drawing.Point(49, 102);
            this.lstPalabra.Name = "lstPalabra";
            this.lstPalabra.Size = new System.Drawing.Size(400, 251);
            this.lstPalabra.TabIndex = 3;
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(297, 384);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(110, 40);
            this.btnContar.TabIndex = 4;
            this.btnContar.Text = "Contar Especiales";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 472);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.lstPalabra);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.txtBoxPalabra);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practica 02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtBoxPalabra;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.ListBox lstPalabra;
        private System.Windows.Forms.Button btnContar;
    }
}

