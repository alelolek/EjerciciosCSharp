namespace EjerciciosCSharp
{
    public class Variables
    {
        public static void Ejecutar()
        {
            //1. Escribir un programa que convierta una temperatura en grados Celsius a grados 
            //    Fahrenheit. (Tema: Conversión de tipos de datos)

            double celsius = 80.7;
            double fahrenheit;

            fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"{celsius}celsius son {fahrenheit}fahrenheit.");



            //2. Escribir un programa que calcule el area de un triangulo, ingresando la 
            //    base y la altura por el usuario. (Tema: Variables y operadores aritméticos)


            double areaTriangulo;
            Console.WriteLine("Ingresa la base del triangulo: ");
            double baseT = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la altura del trinagulo: ");
            double alturaT = Double.Parse(Console.ReadLine());

            areaTriangulo = (baseT * alturaT) / 2;

            Console.WriteLine($"El area de un triangulo con base de {baseT} y una altura de {alturaT} es : {areaTriangulo}");



            //3. Escribir un programa que pida al usuario ingresar dos numeros enteros y luego los
            //    multiplique y muestre el resultado por pantalla.(Tema: Tipos de datos numéricos)

            Console.WriteLine("Ingrese el primer numero a multiplicar : ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero a multiplicar : ");
            int numero2 = int.Parse(Console.ReadLine());

            int multiplicacion = numero1 * numero2;

            Console.WriteLine($"{numero1} multiplicado por {numero2} es {multiplicacion}");



            //4. Escribir un programa que pida al usuario escribir su nombre y edad y luego los
            //    muestre en pantalla en una frase. (Tema: Tipos de datos de texto)

            Console.WriteLine("Ingresa tu nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine($"La edad de {nombre} es {edad}.");


            //5. Escribe un programa que pida al usuario ingresar un numero decimal y luego los redondee 
            //    a dos decimales y lo muestre por pantalla.. (Tema: Tipos de datos numéricos )


            Console.WriteLine("Ingrese un numero decimal: ");
            decimal numero = decimal.Parse(Console.ReadLine());

            var numeroRedondeado = Math.Round(numero, 2);

            Console.WriteLine($"El numero redondeado es {numeroRedondeado}");
        }
    }
}
