using System;

namespace ConsoleAppPablo
{
	public class Program
	{
		public static void Main()
		{
			menu();
			string opcion = Console.ReadLine();

			while (int.Parse(opcion) != 4)
			{
				switch (int.Parse(opcion))
				{
					case 1:
						Console.Write("Ingrese la longuitud del lado: ");
						string ladoCuadrado = Console.ReadLine();
						try
						{
							Cuadrado cuadrado = new Cuadrado(Double.Parse(ladoCuadrado));
							Console.WriteLine("El area del cuadrado es: " + cuadrado.area());
						}
						catch (Exception e)
						{
							Console.WriteLine(e.ToString());
						}
						break;
					case 2:
						Console.Write("Ingrese la longuitud de la base: ");
						string baseRectangulo = Console.ReadLine();
						Console.Write("Ingrese la longuitud de la altura: ");
						string alturaRectangulo = Console.ReadLine();
						try
						{
							Rectangulo rectangulo = new Rectangulo(Double.Parse(baseRectangulo), Double.Parse(alturaRectangulo));
							Console.WriteLine("El area del rectangulo es: " + rectangulo.area());
						}
						catch (Exception e)
						{
							Console.WriteLine(e.ToString());
						}
						break;
					case 3:
						Console.Write("Ingrese la longuitud del radio: ");
						string radioCirculo = Console.ReadLine();
						try
						{
							Circulo circulo = new Circulo(Double.Parse(radioCirculo));
							Console.WriteLine("El area del circulo es: " + circulo.area());
						}
						catch (Exception e)
						{
							Console.WriteLine(e.ToString());
						}
						break;
					default:
						Console.WriteLine("Opcion no valida");
						break;
				}
				menu();
				opcion = Console.ReadLine();
			}

			Console.WriteLine("Programa finalizado");

		}

		public static void menu()
		{
			Console.WriteLine("-----------------------------------------");
			Console.WriteLine("Seleccione la figura a calcular el area:");
			Console.WriteLine("1. Cuadrado");
			Console.WriteLine("2. Rectangulo");
			Console.WriteLine("3. Circulo");
			Console.WriteLine("4. Exit");
			Console.Write("Opcion: ");
		}

	}
}