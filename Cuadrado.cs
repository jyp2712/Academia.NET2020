using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppPablo
{
	public class Cuadrado : Figura
	{
		protected double lado;

		public Cuadrado(double _lado)
		{
			if (_lado < 0)
				throw new ArgumentException("El valor del lado deberia ser positivo");
			this.lado = _lado;
		}

		public double area()
		{
			return Math.Pow(lado, 2);
		}

	}

}
