using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5_JuanGiron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ejecutar_button_Click(object sender, EventArgs e)
        {
            if (Filas_textBox.Text == "" || Columnas_textBox.Text == "")
            {
                MessageBox.Show("Ingrese los datos de la Matriz");
            }
            else
            {
                //Entrada de Datos
                int Fila = Convert.ToInt32(Filas_textBox.Text);
                int Colum = Convert.ToInt32(Columnas_textBox.Text);


                int[,] Matriz = new int[Fila, Colum];
                Random aletorio = new Random();

                // LLenando la Matriz
                for (int f = 0; f < Matriz.GetLongLength(0); f++)
                {
                    for (int c = 0; c < Matriz.GetLongLength(1); c++)
                    {
                        Matriz[f, c] = aletorio.Next(0, 100);

                    }
                }

                for (int f = 0; f < Matriz.GetLongLength(0); f++)
                {
                    for (int c = 0; c < Matriz.GetLongLength(1); c++)
                    {

                        MessageBox.Show("Posicion : " + f + "," + c + " = " + Matriz[f, c].ToString());
                    }

                }





            }

        }
    }
}
