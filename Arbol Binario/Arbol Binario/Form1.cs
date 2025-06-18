using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol_Binario
{
    public partial class Form1 : Form
    {
        int dato = 0;
        ArbolBinario miArbol;
        FormatoNodo formatoNodo;
        Graphics g;
        public Form1()
        {
            InitializeComponent();

            miArbol = new ArbolBinario(null); // creacion del objeto

            // definir colores a usar
            formatoNodo.fuente = this.Font;
            formatoNodo.relleno = Brushes.Blue;
            formatoNodo.rellenofuente = Brushes.White;
            formatoNodo.lapiz = Pens.Black;
            formatoNodo.encuentro = Brushes.White;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g = e.Graphics;
            miArbol.DibujarArbol(g, panel1.Size, formatoNodo);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtDato.Text == "")
                MessageBox.Show("Debe ingresar un valor");
            else
            {
                dato = int.Parse(txtDato.Text);
                if (dato <= 0 || dato >= 100)
                    MessageBox.Show("Solo recibe valores desde 1 hasta 99", "Error de Ingreso");
                else
                {
                    miArbol.Insertar(dato);
                    txtDato.Clear();
                    txtDato.Focus();
                    panel1.Refresh(); // actualiza el contenido
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtEliminar.Text == "")
                MessageBox.Show("Debe ingresar el valor a eliminar");
            else
            {
                dato = Convert.ToInt32(txtEliminar.Text);
                if (dato <= 0 || dato >= 100)
                    MessageBox.Show("Solo se admiten valores entre 1 y 99", "Error de Ingreso");
                else
                {
                    miArbol.Eliminar(dato);
                    txtEliminar.Clear();
                    txtEliminar.Focus();
                    panel1.Refresh();
                }
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
                MessageBox.Show("Debe ingresar el valor a buscar");
            else
            {
                dato = Convert.ToInt32(txtBuscar.Text);
                if (dato <= 0 || dato >= 100)
                    MessageBox.Show("Solo se admiten valores entre 1 y 99", "Error de Ingreso");
                else
                {
                    FormatoNodo formatoNodoEncontrado;
                    formatoNodoEncontrado = formatoNodo;
                    formatoNodoEncontrado.relleno = Brushes.Red;
                    miArbol.BuscarEnArbol(dato, panel1.CreateGraphics(),
                        panel1.Size, formatoNodoEncontrado);
                    txtBuscar.Clear();
                    txtBuscar.Focus();
                    panel1.Refresh();
                }
            }
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            if (miArbol.Raiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }
            TipoRecorridoArbol tipo;

            switch (cmbTipoRecorrido.SelectedIndex)
            {
                case 0:
                    tipo = TipoRecorridoArbol.inOr;
                    break;
                case 1:
                    tipo = TipoRecorridoArbol.preOr;
                    break;
                case 2:
                    tipo = TipoRecorridoArbol.postOr;
                    break;
                default:
                    MessageBox.Show("Recorrido no valido.");
                    return;
            }

            miArbol.VisualizarRecorrido(panel1.CreateGraphics(), formatoNodo, miArbol.Raiz, tipo);

            List<int> recorrido = miArbol.ObtenerRecorrido(tipo);
            lblResultado.Text = string.Join(", ", recorrido);
        }

        // para calcular altura
        private void btnAltura_Click(object sender, EventArgs e)
        {
            int altura = miArbol.ObtenerAltura();
            MessageBox.Show("La altura es: " + altura, "Altura del arbol");
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int suma = miArbol.SumarElementos();
            MessageBox.Show("La suma de todos los nodos es: " + suma, "Suma de elementos");
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            int cantidad = miArbol.ContarNodos();
            MessageBox.Show("Numero total de nodos: " + cantidad, "Cantidad de nodos");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarDialog = new SaveFileDialog();
            guardarDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            guardarDialog.Title = "Guardar Arbol";

            if (guardarDialog.ShowDialog() == DialogResult.OK)
            {
                miArbol.GuardarEnArchivo(guardarDialog.FileName);
                MessageBox.Show("Arbol guardado exitosamente.", "Guardar");
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirDialog = new OpenFileDialog();
            abrirDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            abrirDialog.Title = "Cargar Arbol";

            if (abrirDialog.ShowDialog() == DialogResult.OK)
            {
                miArbol.CargarDesdeArchivo(abrirDialog.FileName);
                panel1.Refresh(); // redibujar el arbol
                MessageBox.Show("Arbol cargado correctamente.", "Cargar");
            }
        }

        // les di click por accidente
        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
