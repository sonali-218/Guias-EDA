using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; // para dibujar figuras
using System.Threading; // accede a clases para manejo de hilos
using System.Windows.Forms; // utiliza clases para generar objetos de ventanas

namespace Arbol_Binario
{
    // tipos de recorridos a realizar
    public enum TipoRecorridoArbol
    {
        postOr,
        inOr,
        preOr
    }

    // colores a usar en la grafica
    public struct FormatoNodo
    {
        public Font fuente;
        public Brush relleno;
        public Brush rellenofuente;
        public Pen lapiz;
        public Brush encuentro;
    }
    public class NodoArbol
    {
        // propiedades autoimplementadas
        public int Info { get; set; }
        public NodoArbol Izquierdo { get; set; }
        public NodoArbol Derecho { get; set; }
        public int Altura { get; set; }
        public int Nivel { get; set; }
        public int CoordenadaX { get; set; }
        public int CoordenadaY { get; set; }

        // constantes privadas
        private const int Radio = 30;
        private const int DistanciaH = 80;
        private const int DistanciaV = 10;

        // ===== Metodos ======

        // Constructor con parametros
        public NodoArbol(int nueva_info, NodoArbol izquierdo, NodoArbol derecho)
        {
            this.Info = nueva_info;
            this.Izquierdo = izquierdo;
            this.Derecho = derecho;
            this.Altura = 0;
        }
        static private int getAltura(NodoArbol t)
        {
            return t == null ? -1 : t.Altura;
        }

        public NodoArbol Insertar(int x, NodoArbol t, int nivel)
        {
            if (t == null)
            {
                t = new NodoArbol(x, null, null);
                t.Nivel = nivel;
            }
            else if (x < t.Info) 
            {
                // insertar en el subarbol izquierdo
                nivel++;
                t.Izquierdo = Insertar(x, t.Izquierdo, nivel);
            }
            else if (x > t.Info) 
            {
                // insertar en el subarbol derecho
                nivel++;
                t.Derecho = Insertar(x, t.Derecho, nivel);
            }
            else
            {
                // el valor ya existe y no se permiten duplicados
                MessageBox.Show("Dato ya existe en el árbol", "Error de Ingreso");
            }

            // Actualizar altura al volver de la recursion
            t.Altura = 1 + Math.Max(getAltura(t.Izquierdo), getAltura(t.Derecho));
            return t;
        }

        public NodoArbol Eliminar(int x, NodoArbol t) 
        {
            if (t == null) 
            {
                MessageBox.Show("Nodo NO existente en el árbol", "Error de eliminacion");
                return null;
            }

            if (x < t.Info)
            {
                // buscar en el subarbol izq y actualizar la referencia
                t.Izquierdo = Eliminar(x, t.Izquierdo);
            }
            else if (x > t.Info)
            {
                // buscar en el subarbol der y actualizar la referencia
                t.Derecho = Eliminar(x, t.Derecho);
            }

            else
            {
                // nodo encontrado
                // caso 1: nodo sin hijo der, se reemplaza por hijo izq
                if (t.Derecho == null)
                {
                    return t.Izquierdo;
                }
                // caso 2: nodo sin hijo izq, se reemplaza por hijo der
                else if (t.Izquierdo == null)
                {
                    return t.Derecho;
                }
                else
                {
                    // caso 3: nodo con dos hijos
                    // elegimos el sucesor o predecesor segun la altura de los arboles
                    if (getAltura(t.Izquierdo) > getAltura(t.Derecho))
                    {
                        // buscar el nodo mayor (predecesor)
                        NodoArbol padreAux = null;
                        NodoArbol aux = t.Izquierdo;
                        while (aux.Derecho != null)
                        {
                            padreAux = aux;
                            aux = aux.Derecho;
                        }
                        // reemplazar valor del nodo a eliminar con predecesor
                        t.Info = aux.Info;

                        // eliminar el predecesor y actualizar su padre
                        if (padreAux != null)
                            padreAux.Derecho = aux.Izquierdo;
                        else
                            t.Izquierdo = aux.Izquierdo;
                    }
                    else
                    {
                        // buscar nodo minimo en el subarbol derecho (sucesor)
                        NodoArbol padreAux = null;
                        NodoArbol aux = t.Derecho;
                        while (aux.Izquierdo != null)
                        {
                            padreAux = aux;
                            aux = aux.Izquierdo;
                        }
                        // reemplazar valor
                        t.Info = aux.Info;

                        // eliminar el nodo sucesor y actualizar su padre
                        if (padreAux != null)
                            padreAux.Izquierdo = aux.Derecho;
                        else
                            t.Derecho = aux.Derecho;
                    }
                }
            }

            // actualizar altura luego de las modificaciones
            t.Altura = 1 + Math.Max(getAltura(t.Izquierdo), getAltura(t.Derecho));
            // retornar el nodo modificado para reasignar en el padre
            return t;

        }

        public void PosicionNodo(ref int x, int y)
        {
            const int distanciaHorizontal = 40; // entre nodos hermanos
            const int distanciaVertical = 50; // espacio entre niveles

            // primero los nodos del subarbol izq (recorrido inorden)
            if (Izquierdo != null)
            {
                Izquierdo.PosicionNodo(ref x, y + distanciaVertical);
                // se aumenta la profundidad y 
            }

            // asignar coordenadas al nodo actual
            this.CoordenadaX = x;
            this.CoordenadaY = y;

            // luego, avanzar horizontalmente
            x += distanciaHorizontal;

            // para terminar, los nodos del subarbol der
            if (Derecho != null)
            {
                Derecho.PosicionNodo(ref x, y + distanciaVertical);
            }
        }

        public void DibujarRamas(Graphics grafo, FormatoNodo formatoNodo)
        {
            if (Izquierdo != null)
            {
                // linea desde borde inferior del nodo padre
                // al borde superior del hijo izquierdo
                grafo.DrawLine(formatoNodo.lapiz,
                    CoordenadaX, CoordenadaY,
                    Izquierdo.CoordenadaX, Izquierdo.CoordenadaY);
                Izquierdo.DibujarRamas(grafo, formatoNodo);
            }
            if (Derecho != null)
            {
                // lo mismo pero para la derecha
                grafo.DrawLine(formatoNodo.lapiz,
                    CoordenadaX, CoordenadaY,
                    Derecho.CoordenadaX, Derecho.CoordenadaY);
                Derecho.DibujarRamas(grafo, formatoNodo);
            }
        }

        public void DibujarNodo(Graphics grafo, FormatoNodo formatoNodo)
        {
            // rectangle que enmarca el nodo circular (elipse)
            // sintaxis: rectangle(int x, int y, int width, int height)
            Rectangle rect = new Rectangle(
                (int)(CoordenadaX - Radio/2),
                (int)(CoordenadaY - Radio/2),
                Radio, Radio);

            // rellenar con color de fondo
            grafo.FillEllipse(formatoNodo.relleno, rect);
            // dibujar borde del nodo
            grafo.DrawEllipse(formatoNodo.lapiz, rect);
            // preparar formato para texto centrado
            StringFormat formato = new StringFormat 
            { 
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center,
            };

            // dibujar texto con el contenido del nodo centrado
            grafo.DrawString(Info.ToString(), formatoNodo.fuente,
                formatoNodo.rellenofuente, CoordenadaX, CoordenadaY, formato);
            // dibujar nodos hijos (recursivo)
            if (Izquierdo != null)
                Izquierdo.DibujarNodo(grafo, formatoNodo);

            if (Derecho != null)
                Derecho.DibujarNodo(grafo, formatoNodo);
        }

        public void Colorear(Graphics grafo, FormatoNodo formatoNodo)
        {
            Rectangle rect = new Rectangle(
                (int)(CoordenadaX - Radio / 2),
                (int)(CoordenadaY - Radio / 2),
                Radio, Radio);

            // rellenar con color para resaltar (ej. al seleccionar)
            grafo.FillEllipse(formatoNodo.relleno, rect);
            // dibujar borde
            grafo.DrawEllipse(formatoNodo.lapiz, rect);
            // formato texto centrado
            StringFormat formato = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center,
            };

            // dibujar texto centrado
            grafo.DrawString(Info.ToString(), formatoNodo.fuente,
                formatoNodo.rellenofuente, CoordenadaX, CoordenadaY, formato);
        }

        public NodoArbol Buscar(int x, NodoArbol t)
        {
            if (t == null)
                return null;

            if (x == t.Info)
                return t;

            else if (x < t.Info)
                return Buscar(x, t.Izquierdo);
            else // x > t.Info
                return Buscar(x, t.Derecho);
        }
    }
}
