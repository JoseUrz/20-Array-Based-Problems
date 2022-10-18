using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Statistics;
using MathNet.Numerics.LinearAlgebra;
using System.Numerics;
using MathNet.Numerics;

namespace ArraysEjercicios1.Logica
{
    public class Vectores
    {

        public int[] Numeros { get; set; }


        public Vectores()
        {

        }

        public Vectores(int[] numeros)
        {
            Numeros = numeros;
        }

        public int Maximo(int[] vecto)
        {
            return vecto.Max();
        }


        public int Minimo(int[] vecto)
        {
            return vecto.Min();
        }

        public String Minimo2(int[] vecto)
        {
            Array.Sort(vecto);

            if (vecto.Length >= 2)
            {
                return vecto[1] + "";
            }
            else
            {
                return "Vector solo contiene \n" +
                    "un Elemento, \n" +
                    "No existe 2do Menor";
            }
                        

        }

        public String Minimo3(int[] vecto)
        {
            Array.Sort(vecto);

            if (vecto.Length >= 3)
            {
                return vecto[2] + "";
            }
            else
            {
                return "Vector contiene menos \n" +
                    "de dos Elementos, \n" +
                    "No existe 3ro Menor";
            }

        }

        public String Minimo4(int[] vecto)
        {
            Array.Sort(vecto);

            if (vecto.Length >= 4)
            {
                return vecto[3] + "";
            }
            else
            {
                return "Vector contiene menos\n" +
                    "de tres Elementos, \n" +
                    "No existe 4to Menor";
            }

        }

        public String Maximo2(int[] vecto)
        {
            Array.Sort(vecto);
            Array.Reverse(vecto);

            if (vecto.Length >= 2)
            {
                return vecto[1] + "";
            }
            else
            {
                return "Vector solo contiene \n" +
                    "un Elemento, \n" +
                    "No existe 2do Mayor";
            }
        }

        public String Maximo3(int[] vecto)
        {
            Array.Sort(vecto);
            Array.Reverse(vecto);

            if (vecto.Length >= 3)
            {
                return vecto[2] + "";
            }
            else
            {
                return "Vector contiene menos \n" +
                    "de dos Elementos, \n" +
                    "No existe 3ro Mayor";
            }
        }

        public String Maximo4(int[] vecto)
        {
            Array.Sort(vecto);
            Array.Reverse(vecto);

            if (vecto.Length >= 4)
            {
                return vecto[3] + "";
            }
            else
            {
                return "Vector contiene menos\n" +
                    "de tres Elementos, \n" +
                    "No existe 4to Mayor";
            }
        }

        public string Positivos(int[] vecto)
        {

            string cadena = "";

            for (int i = 0; i < vecto.Length; i++)
            {
                if (vecto[i] >= 0)
                {
                    cadena = cadena + " " + vecto[i]; 
                }                
            }
            return cadena;
        }

        public string Negativos(int[] vecto)
        {

            string cadena = "";

            for (int i = 0; i < vecto.Length; i++)
            {
                if (vecto[i] < 0)
                {
                    cadena = cadena + " " + vecto[i];
                }
            }
            return cadena;
        }

        public string Pares(int[] vecto)
        {

            string cadena = "";

            for (int i = 0; i < vecto.Length; i++)
            {
                if ((vecto[i]%2) == 0)
                {
                    cadena = cadena + " " + vecto[i];
                }
            }
            return cadena;
        }

        public string Impares(int[] vecto)
        {

            string cadena = "";

            for (int i = 0; i < vecto.Length; i++)
            {
                if ((vecto[i]%2) == 1)
                {
                    cadena = cadena + " " + vecto[i];
                }
            }
            return cadena;
        }

        public string Primo(int[] vecto)
        {
            string cadena = "";


            for (int i = 0; i < vecto.Length; i++)
            {
                bool esPrimo = false;

                for (int n = 2; n < vecto[i]/2; n++)
                {
                    if (vecto[i] % n == 0)
                    {
                        esPrimo = true;
                        break;
                    }

                }
                if (esPrimo == false)
                {
                    cadena = cadena + " " + vecto[i];
                }
            }

            return cadena;



        }

        public string CuadradoPerfecto(int[] vecto)
        {
            string cadena = "";
            double j;

            for (int i = 0; i < vecto.Length; i++)
            {
                j = Math.Round(Math.Sqrt(vecto[i]));

                if (j*j == vecto[i])
                {
                    cadena = cadena + " " + vecto[i];
                }

            }

            return cadena;
        }

        public string CubosPerfectos(int[] vecto)
        {
            string cadena = "";
            double j;

            for (int i = 0; i < vecto.Length; i++)
            {
                j = Math.Round(Math.Cbrt(vecto[i]));

                if (j * j * j == vecto[i])
                {
                    cadena = cadena + " " + vecto[i];
                }

            }

            return cadena;
        }

        public int Suma(int[] vecto)
        {
            return vecto.Sum();       
        }

        public double Promedio(int[] vecto)
        {
            return Math.Round(vecto.Average(), 3);
            
        }

        public double Mediana(int[] vecto)
        {
            double[] v = new double[vecto.Length];

            for (int i = 0; i < vecto.Length; i++)
            {
                v[i] = vecto[i];
            }

             return  Statistics.Median(v);           

        }

        public int Moda(int[] vecto)
        {
            int valorMaximo = 0;
            int ContadorMaximo = 0;

            for (int i = 0; i < vecto.Length; ++i)
            {
                int contador = 0;
                for (int j = 0; j < vecto.Length; ++j)
                {
                    if (vecto[j] == vecto[i])
                        ++contador;
                }

                if (contador > ContadorMaximo)
                {
                    ContadorMaximo = contador;
                    valorMaximo = vecto[i];
                }
            }
            return valorMaximo;
        }


        public double MediaCuadratica(int[] vecto)
        {
            double resultado = 0;

            for (int i = 0; i < vecto.Length; i++)
            {
                resultado = resultado + Math.Pow(vecto[i],2);
            }

            return Math.Round(Math.Sqrt(resultado/vecto.Length), 5);           



        }

        public long Producto(int[] vecto)
        {
            long resultado = 1;

            for (int i = 0; i < vecto.Length; i++)
            {
                resultado = resultado * vecto[i];
            }

            return resultado;

        }

        public double ProductoDivididoFactorial(int[] vecto)
        {
            double resultado = 1;

            for (int i = 0; i < vecto.Length; i++)
            {
                resultado = resultado * vecto[i];
            }

            double factorial = 1;
                        
            for (int i = vecto.Length; i > 0; i--)
            {
                factorial = factorial * i;
            }

            return resultado/factorial;
            

        }






    }
}
