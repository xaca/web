using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARACIONES

            short Nro;
            int entero;
            long largo;
            float realf = 0f;
            double reald = 0.0;


            string texto1 = "Medellín";
            String texto2 = "Medellín";

            DateTime fecha = DateTime.Today;
            Console.WriteLine(fecha.ToString("d"));
            Console.WriteLine(fecha.ToString("D"));
            Console.WriteLine(fecha.ToString("g"));
            Console.ReadLine();

            //CONVERSION IMPLICITA 
            entero = 2569252;
            realf = entero;


            //conversión explícita con cast, double a int:
            reald = 1234.7;
            entero = (int)reald;
            System.Console.WriteLine(entero);
            Console.ReadLine();

            //parse: conversión de string a numérico
            int numVal = Int32.Parse("-105");
            Console.WriteLine(numVal);

            //CONDICIONALES

            bool condition = true;

            if (condition)
            {
                Console.WriteLine("The variable is set to true.");
            }
            else
            {
                Console.WriteLine("The variable is set to false.");
            }

            Console.Write("Enter a character: ");
            char ch = (char)Console.Read();

            if (Char.IsUpper(ch))
            {
                Console.WriteLine("The character is an uppercase letter.");
            }
            else if (Char.IsLower(ch))
            {
                Console.WriteLine("The character is a lowercase letter.");
            }
            else if (Char.IsDigit(ch))
            {
                Console.WriteLine("The character is a number.");
            }
            else
            {
                Console.WriteLine("The character is not alphanumeric.");
            }

            //COMPARACION DE TEXTOS
            if (texto1.Equals(texto2))
            {
                Console.WriteLine("Son iguales");
                Console.ReadLine();

            }

            //SWITCH

            char caracter = 'Y';

            switch (caracter)
            {
                case 'Y':
                    Console.WriteLine('Y');
                    break;
                case 'E':
                    Console.WriteLine('E');
                    break;
                case 'S':
                    Console.WriteLine('S');
                    break;
                default:
                    Console.WriteLine("Caracter no válido");
                    break;
            }

            Console.ReadLine();

            //CICLOS
            int n = 0;
            while (n < 5)
            {
                Console.WriteLine(n);
                n++;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            int n = 0;
            do
            {
                Console.WriteLine(n);
                n++;
            } while (n < 5);

            //GENERACION DE ALEATORIOS

            Random rnd = new Random();

            for (int i = 0; i <= 5; i++)
            {
                int month = rnd.Next(1, 13); // creates a number between 1 and 12
                int dice = rnd.Next(1, 7);   // creates a number between 1 and 6
                int card = rnd.Next(-1, 6);     // creates a number between -1 and 5
                Console.WriteLine("El mes es: " + month + "-" + dice + "-" + card);
                Console.ReadLine();
            }


            //ARREGLOS

            // Specify the data source.
            int[] scores = new int[] { 97, 92, 81, 60 };
            string[] stringArray = new string[6];

            string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            int[] array3;
            array3 = new int[] { 1, 3, 5, 7, 9 };

            //se recorre con for

            // se recorre con foreach
            foreach (int i in scores)
            {
                Console.Write(i + " ");
            }

            int[,] array = new int[4, 2];

            int[,,] array1 = new int[4, 2, 3];

            // Two-dimensional array.
            int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            // The same array with dimensions specified.
            int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            // A similar array with string elements.
            string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" },
                                        { "five", "six" } };

            // Three-dimensional array.
            int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                 { { 7, 8, 9 }, { 10, 11, 12 } } };

            //for anidado
            int[][] matriz1 = new int[2][] { new int[3] { 1, 2, 3 }, new int[3] { 4, 5, 6 } };
            for (int j = 0; j < matriz1.Length; j += 1)
            {
                for (int k = 0; k < matriz1[j].Length; k += 1)
                {
                    Console.Write(matriz1[j][k]);
                }
            }


            int[,] matrizedad = new int[5, 5];

            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    Random aleatorio = new Random();
                    matrizedad[i, j] = aleatorio.Next(1, 99);
                    Console.Write(matrizedad[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();

            //for each anidado

            int[][] Matriz = new int[2][] { new int[3] { 1, 2, 3 }, new int[3] { 4, 5, 6 } };
            foreach (int[] subArray in Matriz)
            {
                foreach (int i in subArray)
                {
                    Console.Write(i);
                }
            }

            // The same array with dimensions specified.
            int[,,] array3Da = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                       { { 7, 8, 9 }, { 10, 11, 12 } } };


        
        //TEXTO Y SPLIT

        String linea;
        String[] arregloSplit;

        // Pasar la ruta y el nombre del archivo al contructor StreamReader
        StreamReader leer = new StreamReader("C:\\Users\\EQUIPO\\Documents\\Prueba.txt"); 
        //IMPORTAR using System.IO;

        //Read the first line of text
                linea = leer.ReadLine();

                while (linea != null)
                {
                    //write the lie to console window
                    Console.WriteLine(linea);

                    //Split
                    arregloSplit = linea.Split('|');
                    Console.WriteLine(arregloSplit[0] + " es la capital de: " + arregloSplit[1]);


                    //Read the next line
                    linea = leer.ReadLine();
                }

                //close the file
                leer.Close();
                            Console.ReadLine();



            //Crear lista sencilla

            List<string> lista_juegos = new List<string>();

            //Adicionar elementos a la lista
            lista_juegos.Add("Dragon Ball Z Kakarot");
            lista_juegos.Add("Monster Hunter World: Iceborne");
            lista_juegos.Add("Detroit: Become Human");

            Console.WriteLine("se insertaron elementos a la lista");



            //Recorrer la lista con foreach
            Console.WriteLine("*******LISTA DE JUEGOS*********");

            foreach (string elemento in lista_juegos)
            {
                Console.WriteLine(elemento);
            }


            //Ordenar la lista
            lista_juegos.Sort();

            Console.WriteLine("*******LISTA DE JUEGOS V" + Contversiones++ + " *********");

            foreach (string elemento in lista_juegos)
            {
                Console.WriteLine(elemento);
            }


            //Preguntar si un elemento está en una lista

            Console.WriteLine(lista_juegos.Contains("Dragon Ball Z Kakarot");

            //Insertar un elemento en una posición de la lista
            lista_juegos.Insert(2, "Disco Elysium");

            Console.WriteLine("*******LISTA DE JUEGOS V" + Contversiones++ + " *********");
            foreach (string elemento in lista_juegos)
            {
                Console.WriteLine(elemento);
            }


            //Eliminar elemento de una lista
            lista_juegos.Remove("Monster Hunter World: Iceborne");

            Console.WriteLine("*******LISTA DE JUEGOS V" + Contversiones++ + " *********");

            foreach (string elemento in lista_juegos)
            {
                Console.WriteLine(elemento);
            }

            //Eliminar elemento en una posición de una lista
            lista_juegos.RemoveAt(1);

            Console.WriteLine("*******LISTA DE JUEGOS V" + Contversiones++ + " *********");

            foreach (string elemento in lista_juegos)
            {
                Console.WriteLine(elemento);
            }

            //extraer la posición del elemento en la lista
            Console.WriteLine(lista_juegos.IndexOf("Disco Elysium"));

            //extraer elemento en la posición n de la lista
            Console.WriteLine(lista_juegos.ElementAt(0));


            //Elimina todos los elementos .clear
            //https://docs.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=netframework-4.8
            lista_juegos.Clear();

            //Cargar lista desde archivo plano



            //Crear lista de objetos https://docs.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=netframework-4.8


        }
    }
}
