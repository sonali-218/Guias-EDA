//Roberto Polanco 20245367
//Christopher Marroquin 20245332
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorOrdenamiento
{
    public partial class Form1 : Form
    {
        private bool actualizarVista = false;
        private List<int> numeros = new List<int>();
        private List<Button> botones = new List<Button>();
        int factor = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtNumero.Text);
                numeros.Add(num);

                Button btn = new Button
                {
                    Height = 50,
                    Width = 50,
                    BackColor = Color.GreenYellow,
                    Text = num.ToString()
                };

                botones.Add(btn);
            }
            catch
            {
                MessageBox.Show("Solo se admiten números enteros");
            }

            actualizarVista |= true;
            tabPage1.Refresh();
            txtNumero.Clear();
            txtNumero.Focus();
        }
        private void tabPage1_Paint(object sender, PaintEventArgs e)
        {
            if (actualizarVista)
            {
                Point xy = new Point(50, 70);
                DibujarArreglo(botones, xy, tabPage1);
                actualizarVista = false;
            }
        }
        private void DibujarArreglo(List<Button> botones, Point xy, TabPage tabPage)
        {
            foreach (var boton in botones)
            {
                boton.Location = xy;
                tabPage.Controls.Add(boton);
                xy += new Size(50, 0);
            }
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            btnOrdenar.Enabled = false;
            txtNumero.Enabled = false;
            btnAgregar.Enabled = false;

            if(comboOrdenamiento.SelectedIndex == 0)
            {
                BubbleSort();
            }
            else if(comboOrdenamiento.SelectedIndex == 1)
            {
                InsertionSort();
            }
            else
            {
                SelectionSort();
            }

            this.Cursor = Cursors.Default;

            btnOrdenar.Enabled = true;
            txtNumero.Enabled = true;
            btnAgregar.Enabled = true;

            txtNumero.Focus();
        }
        private void BubbleSort()
        {
            for(int i=0; i<numeros.Count-1; i++)
            {
                for(int j=0; j<numeros.Count - i - 1; j++)
                {
                    if (numeros[j]*factor > numeros[j + 1]*factor)
                    {
                        int aux = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j+1] = aux;

                        IntercambiarBotones(j + 1, j);
                    }
                }
            }
            MessageBox.Show("Arreglo ordenado exitosamente");
        }
        private void InsertionSort()
        {
            for (int i = 1; i < numeros.Count; i++)
            {
                int actual = numeros[i];
                int j = i - 1;

                while (j >= 0 && numeros[j] * factor > actual * factor)
                {
                    numeros[j + 1] = numeros[j];
                    IntercambiarBotones(j + 1, j);
                    j--;
                }

                numeros[j + 1] = actual;
            }

            MessageBox.Show("Arreglo ordenado exitosamente");
        }
        private void SelectionSort()
        {
            for (int i = 0; i < numeros.Count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < numeros.Count; j++)
                {
                    if (numeros[j] * factor < numeros[minIndex] * factor)
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    int aux = numeros[i];
                    numeros[i] = numeros[minIndex];
                    numeros[minIndex] = aux;

                    IntercambiarBotones(minIndex, i);
                }
            }

            MessageBox.Show("Arreglo ordenado exitosamente");
        }
        private void IntercambiarBotones(int a, int b)
        {
            string templText = botones[a].Text;
            Point pa = botones[a].Location;
            Point pb = botones[b].Location;

            int diferencia = pa.X - pb.X;
            int x = 10, y = 10, t = 50;
            while (y != 70)
            {
                Thread.Sleep(t);
                botones[a].Location += new Size(0, 10);
                botones[b].Location += new Size(0, -10);
                y += 10;
            }
            while(x!= diferencia + 10)
            {
                Thread.Sleep(t);
                botones[a].Location += new Size(-10, 0);
                botones[b].Location += new Size(10, 0);
                x += 10;
            }
            y = 0;
            while(y != -60)
            {
                Thread.Sleep(t);
                botones[a].Location += new Size(0, -10);
                botones[b].Location += new Size(0, 10);
                y -= 10;
            }

            botones[a].Text = botones[b].Text;
            botones[b].Text = templText;

            botones[b].Location = pb;
            botones[a].Location = pa;

            actualizarVista = true;
            tabPage1.Refresh();
        }

        private void btnDescendiente_CheckedChanged(object sender, EventArgs e)
        {
            factor *= -1;
        }
    }
}
