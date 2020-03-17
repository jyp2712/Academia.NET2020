using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo;
            miCirculo = new Circulo();
            Cuadrado miCuadrado;
            miCuadrado = new Cuadrado();
            Trapecio miTrapecio;
            miTrapecio = new Trapecio();

            int opcion;
            bool control;
            int respuesta=1;
            do
            {
                MenuPrincipal();
                opcion = ValidaMenu();
                Console.WriteLine($"Tu opcion fue: {opcion}");
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"La superficie del CUADRADO es: {miCuadrado.CalSup()}");
                        miCuadrado.Dibujar();
                        break;
                    case 2:
                        Console.WriteLine($"La superficie del CIRCULO es: {miCirculo.CalSup()}");
                        miCirculo.Dibujar();
                        break;
                    case 3:
                        Console.WriteLine($"La superficie del TRAPECIO es: {miTrapecio.CalSup()}");
                        miTrapecio.Dibujar();
                        break;
                }
                Console.WriteLine("\n\n\n---------------------------------------------------");
                Console.WriteLine("1- Salir");
                Console.WriteLine("2- Volver a consultar");
                do
                {
                    control = true;
                    try
                    {
                        respuesta = Convert.ToInt16(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        control = false;
                        Console.Write("\nDebe ingresar 1 o 2. \nReingrese:");
                    }
                    if (respuesta < 1 || respuesta > 2 && control == true)
                    {
                        control = false;
                        Console.Write("\nDebe ingresar 1 o 2. \nReingrese:");
                    }

                } while (control == false);
            } while (respuesta == 2);


            Console.ReadKey();
        }




        static void MenuPrincipal()
        {
            string linea = "************************************************************************";
            Console.WriteLine(linea);
            Console.WriteLine("*                     Calculo de superficies                           *");
            Console.WriteLine(linea);
            Console.WriteLine("*                         1-Cuadrado");
            Console.WriteLine("*                         2-Circulo");
            Console.WriteLine("*                         3-Trapecio");
            Console.WriteLine(linea);
            Console.WriteLine("                        Elija su opcion                                ");
        }

        public static int ValidaMenu()
        {
            int num = 0;
            bool control;
            do
            {
                control = true;
                try
                {
                    num = Convert.ToInt16(Console.ReadLine());

                }
                catch (FormatException)
                {
                    control = false;
                    Console.Write("\nDebe ingresar 1,2 o 3. \nReingrese:");
                }
                if (num < 1 || num > 3 && control == true)
                {
                    control = false;
                    Console.Write("\nDebe ingresar 1,2 o 3. \nReingrese:");
                }

            } while (control == false);
            return num;
        }
        public class Cuadrado
        {
            public double CalSup()
            {
                double b = 0;
                double a = 0;

                bool control;
                Console.WriteLine("Ingrese altura del CUADRADO:");
                do
                {
                    control = true;
                    try
                    {

                        a = Convert.ToInt16(Console.ReadLine());

                    }
                    catch (FormatException)
                    {
                        control = false;
                        Console.Write("\nDebe ser un numero.\nReingrese:");
                    }
                } while (control == false);

                Console.WriteLine("Ingrese base del CUADRADO:");
                do
                {
                    control = true;
                    try
                    {

                        b = Convert.ToInt16(Console.ReadLine());

                    }
                    catch (FormatException)
                    {
                        control = false;
                        Console.Write("\nDebe ser un numero.\nReingrese:");
                    }
                } while (control == false);


                return a * b;

            }
            public void Dibujar()
            {
                Console.WriteLine("     ***************");
                Console.WriteLine("     *             *");
                Console.WriteLine("     *             *");
                Console.WriteLine("     ***************");
            }

        }
        class Circulo
        {
            public double CalSup()
            {
                double pi = 3.1415;
                double r = 0;

                bool control;
                Console.WriteLine("Ingrese RADIO del circulo:");
                do
                {
                    control = true;
                    try
                    {

                        r = Convert.ToInt16(Console.ReadLine());

                    }
                    catch (FormatException)
                    {
                        control = false;
                        Console.Write("\nDebe ser un numero.\nReingrese:");
                    }
                } while (control == false);

                return Math.Pow(pi * r, 2);

            }
            public void Dibujar()
            {
                Console.WriteLine("      ****");
                Console.WriteLine("    *      *");
                Console.WriteLine("   *        *");
                Console.WriteLine("    *      *");
                Console.WriteLine("      ****");
            }

        }

        class Trapecio
        {
            public double CalSup()
            {
                double bMayor = 0;
                double bMenor = 0;
                double a = 0;


                bool control;
                Console.WriteLine("Ingrese BASE MAYOR del trapecio:");
                do
                {
                    control = true;
                    try
                    {

                        bMayor = Convert.ToInt16(Console.ReadLine());

                    }
                    catch (FormatException)
                    {
                        control = false;
                        Console.Write("\nDebe ser un numero.\nReingrese:");
                    }
                } while (control == false);

                Console.WriteLine("Ingrese BASE MENOR del trapecio:");
                do
                {
                    control = true;
                    try
                    {

                        bMenor = Convert.ToInt16(Console.ReadLine());

                    }
                    catch (FormatException)
                    {
                        control = false;
                        Console.Write("\nDebe ser un numero.\nReingrese:");
                    }
                    if (bMayor < bMenor && control == true)
                    {
                        control = false;
                        Console.Write("\nLa BASE MENOR debe ser 'MENOR' que la BASE MAYOR. \nReingrese:");
                    }
                } while (control == false);

                Console.WriteLine("Ingrese ALTURA del trapecio:");
                do
                {
                    control = true;
                    try
                    {

                        a = Convert.ToInt16(Console.ReadLine());

                    }
                    catch (FormatException)
                    {
                        control = false;
                        Console.Write("\nDebe ser un numero.\nReingrese:");
                    }
                } while (control == false);

                return ((bMayor + bMenor) * a) / 2;
            }
            public void Dibujar()
            {
                Console.WriteLine("    ************");
                Console.WriteLine("   *             *");
                Console.WriteLine("  *                 *");
                Console.WriteLine(" *                     *");
                Console.WriteLine(" ************************");
            }

        }
    }
}
