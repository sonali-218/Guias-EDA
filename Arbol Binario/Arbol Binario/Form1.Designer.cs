namespace Arbol_Binario
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
            this.Titulo = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.cmbTipoRecorrido = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnAltura = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnContar = new System.Windows.Forms.Button();
            this.txtAltura = new System.Windows.Forms.Label();
            this.txtSumar = new System.Windows.Forms.Label();
            this.txtContar = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Location = new System.Drawing.Point(671, 39);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(462, 25);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Simulador de Arbol Binario de Busqueda (ABB)";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(39, 139);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(165, 46);
            this.btnInsertar.TabIndex = 1;
            this.btnInsertar.Text = "Insertar Nodo";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(39, 238);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(165, 46);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar Nodo";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(39, 347);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(165, 46);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar Nodo";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(229, 147);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(123, 31);
            this.txtDato.TabIndex = 4;
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(229, 246);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(123, 31);
            this.txtEliminar.TabIndex = 5;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(229, 355);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(123, 31);
            this.txtBuscar.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(421, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1422, 953);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(39, 460);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(165, 46);
            this.btnRecorrer.TabIndex = 8;
            this.btnRecorrer.Text = "Recorrido";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // cmbTipoRecorrido
            // 
            this.cmbTipoRecorrido.FormattingEnabled = true;
            this.cmbTipoRecorrido.Items.AddRange(new object[] {
            "In-orden",
            "Pre-orden",
            "Post-orden"});
            this.cmbTipoRecorrido.Location = new System.Drawing.Point(229, 468);
            this.cmbTipoRecorrido.Name = "cmbTipoRecorrido";
            this.cmbTipoRecorrido.Size = new System.Drawing.Size(137, 33);
            this.cmbTipoRecorrido.TabIndex = 9;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(34, 556);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 25);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // btnAltura
            // 
            this.btnAltura.Location = new System.Drawing.Point(115, 648);
            this.btnAltura.Name = "btnAltura";
            this.btnAltura.Size = new System.Drawing.Size(165, 46);
            this.btnAltura.TabIndex = 11;
            this.btnAltura.Text = "Altura";
            this.btnAltura.UseVisualStyleBackColor = true;
            this.btnAltura.Click += new System.EventHandler(this.btnAltura_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(115, 715);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(165, 46);
            this.btnSuma.TabIndex = 12;
            this.btnSuma.Text = "Sumar";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(115, 779);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(165, 46);
            this.btnContar.TabIndex = 13;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // txtAltura
            // 
            this.txtAltura.AutoSize = true;
            this.txtAltura.Location = new System.Drawing.Point(224, 659);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(0, 25);
            this.txtAltura.TabIndex = 14;
            // 
            // txtSumar
            // 
            this.txtSumar.AutoSize = true;
            this.txtSumar.Location = new System.Drawing.Point(238, 764);
            this.txtSumar.Name = "txtSumar";
            this.txtSumar.Size = new System.Drawing.Size(0, 25);
            this.txtSumar.TabIndex = 15;
            // 
            // txtContar
            // 
            this.txtContar.AutoSize = true;
            this.txtContar.Location = new System.Drawing.Point(224, 873);
            this.txtContar.Name = "txtContar";
            this.txtContar.Size = new System.Drawing.Size(0, 25);
            this.txtContar.TabIndex = 16;
            this.txtContar.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(115, 891);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(165, 46);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(115, 957);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(165, 46);
            this.btnCargar.TabIndex = 18;
            this.btnCargar.Text = "Subir";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1855, 1069);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtContar);
            this.Controls.Add(this.txtSumar);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnAltura);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cmbTipoRecorrido);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.Titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.ComboBox cmbTipoRecorrido;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnAltura;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Label txtAltura;
        private System.Windows.Forms.Label txtSumar;
        private System.Windows.Forms.Label txtContar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCargar;
    }
}

