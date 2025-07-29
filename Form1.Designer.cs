namespace SimuladorOrdenamiento
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
            this.comboOrdenamiento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAscendente = new System.Windows.Forms.RadioButton();
            this.btnDescendiente = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboOrdenamiento
            // 
            this.comboOrdenamiento.FormattingEnabled = true;
            this.comboOrdenamiento.Items.AddRange(new object[] {
            "Ordenamiento Burbuja",
            "Ordenamiento por Inserción",
            "Ordenamiento por Selección"});
            this.comboOrdenamiento.Location = new System.Drawing.Point(326, 38);
            this.comboOrdenamiento.Name = "comboOrdenamiento";
            this.comboOrdenamiento.Size = new System.Drawing.Size(245, 24);
            this.comboOrdenamiento.TabIndex = 0;
            this.comboOrdenamiento.Text = "Ordenamiento Burbuja";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insertar Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(180, 91);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 22);
            this.txtNumero.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(326, 91);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(457, 91);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 4;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(37, 236);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 239);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(787, 210);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ver Simulación";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPage1_Paint);
            // 
            // btnAscendente
            // 
            this.btnAscendente.AutoSize = true;
            this.btnAscendente.Checked = true;
            this.btnAscendente.Location = new System.Drawing.Point(264, 163);
            this.btnAscendente.Name = "btnAscendente";
            this.btnAscendente.Size = new System.Drawing.Size(140, 20);
            this.btnAscendente.TabIndex = 6;
            this.btnAscendente.TabStop = true;
            this.btnAscendente.Text = "Orden Ascendente";
            this.btnAscendente.UseVisualStyleBackColor = true;
            // 
            // btnDescendiente
            // 
            this.btnDescendiente.AutoSize = true;
            this.btnDescendiente.Location = new System.Drawing.Point(431, 163);
            this.btnDescendiente.Name = "btnDescendiente";
            this.btnDescendiente.Size = new System.Drawing.Size(152, 20);
            this.btnDescendiente.TabIndex = 7;
            this.btnDescendiente.Text = "Orden Descendiente";
            this.btnDescendiente.UseVisualStyleBackColor = true;
            this.btnDescendiente.CheckedChanged += new System.EventHandler(this.btnDescendiente_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 498);
            this.Controls.Add(this.btnDescendiente);
            this.Controls.Add(this.btnAscendente);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboOrdenamiento);
            this.Name = "Form1";
            this.Text = "Simulacion de Ordenamiento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboOrdenamiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton btnAscendente;
        private System.Windows.Forms.RadioButton btnDescendiente;
    }
}

