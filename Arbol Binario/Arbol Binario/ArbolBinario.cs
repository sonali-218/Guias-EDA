using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // para MessageBox
using System.Drawing; 
using System.Threading;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace Arbol_Binario
{
    public class ArbolBinario
    {
        public NodoArbol Raiz { get; set; }

        public ArbolBinario(NodoArbol nueva_raiz)
        { 
            Raiz = nueva_raiz;
        }

        public void Insertar(int x)
        {
            if (Raiz == null)
            {
                Raiz = new NodoArbol(x, null, null);
                Raiz.Nivel = 0;
            }
            else
                Raiz = Raiz.Insertar(x, Raiz, Raiz.Nivel);
        }

        public void Eliminar(int x)
        {
            if (Raiz == null)
            {
                MessageBox.Show("El arbol esta vacio. No se puede eliminar.", "Error");
                return;
            }
            Raiz = Raiz.Eliminar(x, Raiz);
        }

        public void BuscarEnArbol(int x, Graphics panelGraphics, Size areaDibujo, FormatoNodo formatoNodo)
        {
            NodoArbol nodo;
            if (Raiz != null)
            {
                nodo = Raiz.Buscar(x, Raiz);
                if (nodo != null) // nodo encontrado
                {
                    nodo.Colorear(panelGraphics, formatoNodo);
                    MessageBox.Show("Nodo " + nodo.Info.ToString() + " fue encontrado",
                        "Busqueda de nodo en Arbol", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("No se encontro al nodo " + x.ToString() +
                        " en el Arbol Binario", "Busqueda de nodo en Arbol",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
        }

        public void DibujarArbol(Graphics panelGraphics, Size areaDibujo, FormatoNodo formatoNodo)
        {
            int x, y; // posicion del nodo raiz
            x = areaDibujo.Width / 4;
            y = 40;
            if (Raiz == null)
                return; // aun no hay arbol que dibujar
            Raiz.PosicionNodo(ref x, y); // obtiene la posicion de cada nodo
            Raiz.DibujarRamas(panelGraphics, formatoNodo); // dibuja los enlaces
            Raiz.DibujarNodo(panelGraphics, formatoNodo); // dibuja los nodos
        }

        public void VisualizarRecorrido(Graphics panelGraphics, FormatoNodo formatoNodo,
            NodoArbol Raiz, TipoRecorridoArbol tipoRecorrido)
        {
            FormatoNodo formatonodo2 = formatoNodo;
            formatonodo2.relleno = Brushes.Red;
            Brush entorno = Brushes.Red;
            switch (tipoRecorrido)
            {
                case TipoRecorridoArbol.inOr:
                    if (Raiz != null)
                    {
                        VisualizarRecorrido(panelGraphics, formatoNodo, Raiz.Izquierdo, tipoRecorrido);
                        Raiz.Colorear(panelGraphics, formatonodo2);
                        Thread.Sleep(1000); // pausar - milisegundos
                        Raiz.Colorear(panelGraphics, formatoNodo);
                        VisualizarRecorrido(panelGraphics, formatoNodo, Raiz.Derecho, tipoRecorrido);
                    }
                    break;
                case TipoRecorridoArbol.preOr:
                    if (Raiz != null)
                    {
                        Raiz.Colorear(panelGraphics, formatonodo2);
                        Thread.Sleep(1000);
                        Raiz.Colorear(panelGraphics, formatoNodo);
                        VisualizarRecorrido(panelGraphics, formatoNodo, Raiz.Izquierdo, tipoRecorrido);
                        VisualizarRecorrido(panelGraphics, formatoNodo, Raiz.Derecho, tipoRecorrido);
                    }
                    break;
                case TipoRecorridoArbol.postOr:
                    if (Raiz != null)
                    {
                        VisualizarRecorrido(panelGraphics, formatoNodo, Raiz.Izquierdo, tipoRecorrido);
                        VisualizarRecorrido(panelGraphics, formatoNodo, Raiz.Derecho, tipoRecorrido);
                        Raiz.Colorear(panelGraphics, formatonodo2);
                        Thread.Sleep(1000);
                        Raiz.Colorear(panelGraphics, formatoNodo);
                    }
                    break;

                    // fin de switch tiporecorrido
            }
        }

        public List<int> ObtenerRecorrido(TipoRecorridoArbol tipo)
        {
            List<int> resultado = new List<int>();
            ObtenerRecorridoRecursivo(Raiz, tipo, resultado);
            return resultado;
        }

        private void ObtenerRecorridoRecursivo(NodoArbol nodo, TipoRecorridoArbol tipo, List<int> lista)
        {
            if (nodo == null) return;

            switch (tipo)
            {
                case TipoRecorridoArbol.inOr:
                    ObtenerRecorridoRecursivo(nodo.Izquierdo, tipo, lista);
                    lista.Add(nodo.Info);
                    ObtenerRecorridoRecursivo(nodo.Derecho, tipo, lista);
                    break;
                case TipoRecorridoArbol.preOr:
                    lista.Add(nodo.Info);
                    ObtenerRecorridoRecursivo(nodo.Izquierdo, tipo, lista);
                    ObtenerRecorridoRecursivo(nodo.Derecho, tipo, lista);
                    break;
                case TipoRecorridoArbol.postOr:
                    ObtenerRecorridoRecursivo(nodo.Izquierdo, tipo, lista);
                    ObtenerRecorridoRecursivo(nodo.Derecho, tipo, lista);
                    lista.Add(nodo.Info);
                    break;
            }
        }

        // para obtener la altura
        public int ObtenerAltura()
        {
            return ObtenerAlturaRecursiva(Raiz);
        }

        private int ObtenerAlturaRecursiva(NodoArbol nodo)
        {
            if (nodo == null)
                return -1;
            return 1 + Math.Max(ObtenerAlturaRecursiva(nodo.Izquierdo), ObtenerAlturaRecursiva(nodo.Derecho));
        }

        // para la suma de elementos (valor de nodos)
        public int SumarElementos()
        {
            return SumarElementosRecursivo(Raiz);
        }

        private int SumarElementosRecursivo(NodoArbol nodo)
        {
            if (nodo == null)
                return 0;
            return nodo.Info + SumarElementosRecursivo(nodo.Izquierdo) + SumarElementosRecursivo(nodo.Derecho);
        }

        // para # de nodos existentes en el arbol
        public int ContarNodos()
        {
            return ContarNodosRecursivo(Raiz);
        }
        private int ContarNodosRecursivo(NodoArbol nodo)
        {
            if (nodo == null)
                return 0;
            return 1 + ContarNodosRecursivo(nodo.Izquierdo) + ContarNodosRecursivo(nodo.Derecho);
        }

        // importar system.IO para guardar en archivo
        public void GuardarEnArchivo(string ruta)
        {
            List<int> valores = ObtenerRecorrido(TipoRecorridoArbol.preOr);
            File.WriteAllText(ruta, string.Join(",", valores));
        }

        public void CargarDesdeArchivo(string ruta)
        {
            if (!File.Exists(ruta))
                return;

            string contenido = File.ReadAllText(ruta);
            string[] partes = contenido.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            // reiniciar arbol
            Raiz = null;

            foreach (string parte in partes)
            {
                if (int.TryParse(parte.Trim(), out int valor))
                {
                    Insertar(valor);
                }
            }
        }
    }
}
