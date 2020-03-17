using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppPablo
{
	public class Circulo : Figura
	{
		protected double radio;


		public Circulo(double _radio)
		{
			if (_radio < 0)
				throw new ArgumentException("El valor del radio deberia ser positivo");
			this.radio = _radio;
		}

		public double area()
		{
			return Math.Pow(radio, 2) * Math.PI;
		}

	}
}
