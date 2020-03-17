using System;
				
public class Program
{
	public static void Main()
	{
		Menu menu = new Menu();
		menu.show();
		string opcion = Console.ReadLine();
	
		while(int.Parse(opcion) != 4){
			switch (int.Parse(opcion)) 
			{
				case 1:
					Console.WriteLine("Ingrese la longuitud del lado");
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
					Console.WriteLine("Ingrese la longuitud de la base");
					string baseRectangulo = Console.ReadLine();
					Console.WriteLine("Ingrese la longuitud de la altura");
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
					Console.WriteLine("Ingrese la longuitud del radio");
					string radioCirculo = Console.ReadLine();
					try
					{
  						Circulo circulo = new Circulo(Double.Parse(radioCirculo));
						Console.WriteLine("El area del circulo es: "+ circulo.area());
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
			menu.show();
			opcion = Console.ReadLine();
		}
	
		Console.WriteLine("Programa finalizado");

	}
}

public class Menu
{
	public void show(){
		Console.WriteLine("-----------------------------------------");
		Console.WriteLine("Seleccione la figura a calcular el area:");
		Console.WriteLine("1. Cuadrado");
		Console.WriteLine("2. Rectangulo");
		Console.WriteLine("3. Circulo");
		Console.WriteLine("4. Exit");
	}
}

interface Figura
{
	double area();

}

public class Cuadrado : Figura
{
	protected double lado;
	
	public Cuadrado(double _lado){
		if (_lado < 0)
              throw new ArgumentException("El valor del lado deberia ser positivo");
		this.lado = _lado;
	}
	
	public double area(){
		return Math.Pow(lado,2);
	}

}

public class Rectangulo : Figura
{
	protected double baseRectangulo;
	protected double alturaRectangulo;

	public Rectangulo(double _base, double _altura){
		if (_base < 0 || _altura < 0)
              throw new ArgumentException("El valor de la base y de la altura deben ser positivos");
		this.baseRectangulo = _base;
		this.alturaRectangulo = _altura;
	}
	
	public double area(){
		return baseRectangulo*alturaRectangulo;
	}

}

public class Circulo : Figura
{
	protected double radio;

	
	public Circulo(double _radio){
		if (_radio < 0)
              throw new ArgumentException("El valor del radio deberia ser positivo");
		this.radio = _radio;
	}
	
	public double area(){
		return Math.Pow(radio,2)*Math.PI;
	}

}
