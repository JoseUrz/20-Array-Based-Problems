using ArraysEjercicios1.Logica;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraysEjercicios1.GUI
{
    public partial class Vector : Form
    {

        Vectores vectores = new Vectores();



        public Vector()
        {
            InitializeComponent();
            listNumeros.Visible = false;
            txtResultado.Visible = false;
            txtResultado2.Visible = false;

            cmbAcciones.Items.Add("Numero Mayor");
            cmbAcciones.Items.Add("Numero 2do Mayor");
            cmbAcciones.Items.Add("Numero 3ro Mayor");
            cmbAcciones.Items.Add("Numero 4to Mayor");
            cmbAcciones.Items.Add("Numero Menor");
            cmbAcciones.Items.Add("Numero 2do Menor");
            cmbAcciones.Items.Add("Numero 3ro Menor");
            cmbAcciones.Items.Add("Numero 4to Menor");
            cmbAcciones.Items.Add("Numeros Positivos");
            cmbAcciones.Items.Add("Numeros Negativos");
            cmbAcciones.Items.Add("Numeros Pares");
            cmbAcciones.Items.Add("Numeros Impares");
            cmbAcciones.Items.Add("Numeros Primos");
            cmbAcciones.Items.Add("Cuadrados Perfectos");
            cmbAcciones.Items.Add("Cubos Perfectos");
            cmbAcciones.Items.Add("Suma Numeros");
            cmbAcciones.Items.Add("Promedio Numeros");
            cmbAcciones.Items.Add("Mediana Numeros");
            cmbAcciones.Items.Add("Moda Numeros");
            cmbAcciones.Items.Add("Media Cuadratica");
            cmbAcciones.Items.Add("Producto Numeros");
            cmbAcciones.Items.Add("Producto/Factorial de cantidad de #");
            cmbAcciones.Visible = false;
            button1.Visible = false;    






        }

        private void btnCrearVector_Click(object sender, EventArgs e)


        {



            vectores.Numeros = new int[int.Parse(txtTamano.Text)];


            for (int i = 0; i < vectores.Numeros.Length; i++)
            {

                vectores.Numeros[i] = int.Parse(Interaction.InputBox("Ingrese Numero a Anadir "));

                listNumeros.Items.Add(vectores.Numeros[i]);

            }

            listNumeros.Visible = true;

            btnCrearVector.Enabled = false;
            btnCrearVector.BackColor = Color.Silver;
            txtTamano.Enabled = false;
            cmbAcciones.Visible=true;
            button1.Visible = true;


        }


        private void button1_Click(object sender, EventArgs e)
        {
            string opcion = (String)cmbAcciones.SelectedItem;

            switch (opcion)
            {
                case "Numero Mayor":
                    txtResultado2.Text = vectores.Maximo(vectores.Numeros).ToString();
                    txtResultado.Text = "Numero Mayor";
                    txtResultado.Visible = true;
                    txtResultado2.Visible = true;
                    break;
                case "Numero 2do Mayor":
                    txtResultado2.Text = vectores.Maximo2(vectores.Numeros).ToString();
                    txtResultado.Text = "Numero 2do Mayor";
                    txtResultado.Visible = true;
                    txtResultado2.Visible = true;
                    break;
                case "Numero 3ro Mayor":
                    txtResultado2.Text = vectores.Maximo3(vectores.Numeros).ToString();
                    txtResultado.Text = "Numero 3ro Mayor";
                    txtResultado.Visible = true;
                    txtResultado2.Visible = true;
                    break;
                case "Numero 4to Mayor":
                    txtResultado2.Text = vectores.Maximo4(vectores.Numeros).ToString();
                    txtResultado.Text = "Numero 4to Mayor";
                    txtResultado.Visible = true;
                    txtResultado2.Visible = true;
                    break;
                case "Numero Menor":
                    txtResultado2.Text = vectores.Minimo(vectores.Numeros).ToString();
                    txtResultado.Text = "Numero Menor";
                    txtResultado.Visible = true;
                    txtResultado2.Visible = true;
                    break;
                case "Numero 2do Menor":
                    txtResultado2.Text = vectores.Minimo2(vectores.Numeros).ToString();
                    txtResultado.Text = "Numero 2do Menor";
                    txtResultado.Visible = true;
                    txtResultado2.Visible = true;
                    break;
                case "Numero 3ro Menor":
                    txtResultado2.Text = vectores.Minimo3(vectores.Numeros).ToString();
                    txtResultado.Text = "Numero 3ro Menor";
                    txtResultado.Visible = true;
                    txtResultado2.Visible = true;
                    break;
                case "Numero 4to Menor":
                    txtResultado2.Text = vectores.Minimo4(vectores.Numeros).ToString();
                    txtResultado.Text = "Numero 4to Menor";
                    txtResultado.Visible = true;
                    txtResultado2.Visible = true;
                    break;
                case "Numeros Positivos":
                    txtResultado2.Text = vectores.Positivos(vectores.Numeros).ToString();
                    txtResultado.Text = "Numero Positivos";
                    txtResultado.Visible = true;
                    txtResultado2.Visible = true;
                    break;
                case "Numeros Negativos":
                    txtResultado2.Text = vectores.Negativos(vectores.Numeros).ToString();
                    txtResultado.Text = "Numero Negativos";
                    txtResultado.Visible = true;
                    txtResultado2.Visible = true;
                    break;
                case "Numeros Pares":
                    txtResultado2.Text = vectores.Pares(vectores.Numeros).ToString();
                    txtResultado.Text = "Numero Pares";
                    txtResultado.Visible = true;
                    txtResultado2.Visible = true;
                    break;
                case "Numeros Impares":
                    txtResultado2.Text = vectores.Impares(vectores.Numeros).ToString();
                    txtResultado.Text = "Numero Impares";
                    txtResultado.Visible = true;
                    txtResultado2.Visible = true;
                    break;
                case "Numeros Primos":
                    txtResultado2.Text = vectores.Primo(vectores.Numeros).ToString();
                    txtResultado.Text = "Numero Primos";
                    txtResultado.Visible = true;
                    txtResultado2.Visible = true;
                    break;
                case "Cuadrados Perfectos":
                    txtResultado2.Text = vectores.CuadradoPerfecto(vectores.Numeros).ToString();
                    txtResultado.Text = "Cuadrados Perfectos";
                    txtResultado.Visible = true;
                    txtResultado2.Visible = true;
                    break;
                case "Cubos Perfectos":
                    txtResultado2.Text = vectores.CubosPerfectos(vectores.Numeros).ToString();
                    txtResultado.Text = "Cubos Perfectos";
                    txtResultado.Visible = true;
                    txtResultado2.Visible = true;
                    break;
                case "Suma Numeros":
                    txtResultado2.Text = vectores.Suma(vectores.Numeros).ToString();
                    txtResultado.Text = "Suma Numeros";
                    txtResultado.Visible = true;
                    txtResultado2.Visible = true;
                    break;
                case "Promedio Numeros":
                    txtResultado2.Text = vectores.Promedio(vectores.Numeros).ToString();
                    txtResultado.Text = "Promedio Numeros";
                    txtResultado.Visible = true;
                    txtResultado2.Visible = true;
                    break;
                case "Mediana Numeros":
                    txtResultado2.Text = vectores.Mediana(vectores.Numeros).ToString();
                    txtResultado.Text = "Mediana Numeros";
                    txtResultado.Visible = true;
                    txtResultado2.Visible = true;
                    break;
                case "Moda Numeros":
                    txtResultado2.Text = vectores.Moda(vectores.Numeros).ToString();
                    txtResultado.Text = "Moda Numeros";
                    txtResultado.Visible = true;
                    txtResultado2.Visible = true;
                    break;
                case "Media Cuadratica":
                    txtResultado2.Text = vectores.MediaCuadratica(vectores.Numeros).ToString();
                    txtResultado.Text = "Media Cuadratica";
                    txtResultado.Visible = true;
                    txtResultado2.Visible = true;
                    break;
                case "Producto Numeros":
                    txtResultado2.Text = vectores.Producto(vectores.Numeros).ToString();
                    txtResultado.Text = "Producto Numeros";
                    txtResultado.Visible = true;
                    txtResultado2.Visible = true;
                    break;
                case "Producto/Factorial de cantidad de #":
                    txtResultado2.Text = vectores.ProductoDivididoFactorial(vectores.Numeros).ToString();
                    txtResultado.Text = "Producto / Factorial";
                    txtResultado.Visible = true;
                    txtResultado2.Visible = true;
                    break;
            }



        }

        private void txtTamano_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Verificar que solo se escriban NUMEROS.
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtTamano_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
