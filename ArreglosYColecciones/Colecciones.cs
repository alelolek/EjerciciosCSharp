namespace EjerciciosCSharp
{
    public class Colecciones
    {
        public static void Ejecutar()
        {
            //ARREGLOS Y COLECCIONES


            // Crea un programa que solicite al usuario un número entero n y luego llene un arreglo de tamaño n con
            //    números aleatorios entre 0 y 100. Luego, calcula el promedio de los números en el arreglo y muestra
            //    el resultado al usuario.(Arreglos unidimensionales)


            int suma = 0;

            Console.WriteLine("Ingresa el tamaño del vector: ");
            int tamaño = int.Parse(Console.ReadLine());
            int[] vector = new int[tamaño];

            for (int i = 0; i < tamaño; i++)
            {
                Console.Write("Ingresa un numero: ");
                int numero = int.Parse(Console.ReadLine());
                vector[i] = numero;

            }

            for (int i = 0; i < vector.Length; i++)
            {
                suma += vector[i];

            }
            double promedio = suma / vector.Length;

            Console.WriteLine($"El promedio de los numeros del vector son {promedio}");



            //Crea un programa que solicite al usuario las dimensiones de una matriz (número de filas y columnas) 
            //    y luego llene la matriz con números aleatorios entre 0 y 10. Luego, muestra la matriz en la consola.
            //    (Arreglos bidimensionales)

            Console.WriteLine("Ingresa el tamaño de las  filas: ");
            int fila = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el tamaño de las columnas : ");
            int columna = int.Parse(Console.ReadLine());

            int[,] matriz = new int[fila, columna];

            Random ran = new Random();

            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    matriz[i, j] = ran.Next(0, 11);
                }
            }



            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }




            // Crea un programa que solicite al usuario un número entero n y luego llene una lista de tamaño 
            //    n con números aleatorios entre 0 y 100. Luego, ordena la lista de menor a mayor y muestra el 
            //    resultado al usuario.(Listas)


            Console.Write("Introduce el tamaño de la lista: ");
            int n = int.Parse(Console.ReadLine());

            List<int> numeros = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                numeros.Add(rnd.Next(0, 101));
            }

            // Ordenamos la lista de menor a mayor
            numeros.Sort();


            Console.WriteLine("La lista ordenada es:");
            foreach (int numero in numeros)
            {
                Console.Write(numero + " ");
            }



            // Crea un programa que permita al usuario ingresar el nombre de un país y su capital. 
            //    Luego, guarda la información en un diccionario y permite al usuario buscar la capital de 
            //    un país específico.(Diccionarios)


            Dictionary<string, string> pais = new Dictionary<string, string>();
            string respuesta = "si";

            while (respuesta != "3")
            {
                Console.WriteLine("Ingresa una opcion: 1. Agregar Pais\t2. Buscar Pais\t3. Salir");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el pais: ");
                        string valor = Console.ReadLine();

                        Console.WriteLine("Ingrese la capital: ");
                        string clave = Console.ReadLine();
                        pais.Add(clave, valor);
                        break;
                    case "2":
                        Console.WriteLine("Ingresa el pais a buscar: ");
                        string buscarPais = Console.ReadLine();

                        foreach (KeyValuePair<string, string> p in pais)
                        {
                            //Console.WriteLine("Key: " + p.Key + " - Value: " + p.Value);
                            if (buscarPais == p.Value)
                            {
                                Console.WriteLine($"La capital de {p.Value} es: {p.Key}");

                            }
                            //else Console.WriteLine("Ese pais no se encuentra en el diccionario.");
                        }
                        break;
                    case "3":
                        respuesta = "3";
                        break;
                }
            }



            //Crea un programa que solicite al usuario una cadena de texto y luego guarde cada carácter de 
            //    la cadena en una pila. Luego, muestra los caracteres en orden inverso al usuario.(Pilas)


            Console.Write("Ingresa una cadena de texto: ");
            string cadena = Console.ReadLine();

            Stack<char> pila = new Stack<char>();
            foreach (char c in cadena)
            {
                pila.Push(c);
            }

            Console.Write("La cadena invertida es: ");
            while (pila.Count > 0)
            {
                Console.Write(pila.Pop());
            }
            Console.WriteLine();



            //Ejercicio para crear matrices cuadradas de las vocales y la x



            Console.WriteLine("Ingresa el tamaño de la matriz cuadrada\t(el tamao debe ser mayor a 4)");
            int tamaño = int.Parse(Console.ReadLine());
            bool respuesta = true;
            if (tamaño < 5)
            {
                Console.WriteLine("El tamaño no puede ser menor a 5.");
                Environment.Exit(0);
            }

            while (respuesta)
            {
                string[,] matriz = new string[tamaño, tamaño];

                Console.WriteLine("Ingresa una opcion: \t1. A\t2. E\t3. I\t4. O\t5. U\t6. X\t7. Salir");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        for (int i = 0; i < tamaño; i++)
                        {
                            for (int j = 0; j < tamaño; j++)
                            {
                                if ((j == 0 || j == tamaño - 1) || (i == (tamaño - 1) / 2 || i == 0))
                                {
                                    matriz[i, j] = "*";
                                }
                                else matriz[i, j] = " ";
                            }
                        }
                        break;

                    case "2":
                        for (int i = 0; i < tamaño; i++)
                        {
                            for (int j = 0; j < tamaño; j++)
                            {

                                if (j == tamaño - 1)
                                {
                                    matriz[i, j] = " ";
                                }
                                else if ((j == 0 || j == tamaño - 1) || (i == 0 || i == tamaño - 1 || i == (tamaño - 1) / 2))
                                {
                                    matriz[i, j] = "*";
                                }

                                else matriz[i, j] = " ";
                            }
                        }
                        break;

                    case "3":
                        for (int i = 0; i < tamaño; i++)
                        {
                            for (int j = 0; j < tamaño; j++)
                            {
                                if ((j == (tamaño - 1) / 2) || (i == 0 || i == tamaño - 1))
                                {
                                    matriz[i, j] = "*";
                                }
                                else matriz[i, j] = " ";
                            }
                        }
                        break;

                    case "4":
                        for (int i = 0; i < tamaño; i++)
                        {
                            for (int j = 0; j < tamaño; j++)
                            {
                                if ((i == 0 || i == tamaño - 1) || (j == 0 || j == tamaño - 1))
                                {
                                    matriz[i, j] = "*";
                                }
                                else matriz[i, j] = " ";

                            }
                        }
                        break;

                    case "5":
                        for (int i = 0; i < tamaño; i++)
                        {
                            for (int j = 0; j < tamaño; j++)
                            {
                                if ((j == 0 || j == tamaño - 1) || (i == tamaño - 1))
                                {
                                    matriz[i, j] = "*";
                                }
                                else matriz[i, j] = " ";
                            }
                        }
                        break;
                    case "6":
                        for (int i = 0; i < tamaño; i++)
                        {
                            for (int j = 0; j < tamaño; j++)
                            {
                                if (j == i || i + j == tamaño - 1)
                                {
                                    matriz[i, j] = "*";
                                }
                                else matriz[i, j] = " ";
                            }
                        }
                        break;
                    case "7":
                        respuesta = false;
                        Environment.Exit(0);
                        break;
                }


                // Imprimir la matriz
                for (int i = 0; i < tamaño; i++)
                {
                    for (int j = 0; j < tamaño; j++)
                    {
                        Console.Write(matriz[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
