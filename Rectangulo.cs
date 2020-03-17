using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppPablo
{
	public class Rectangulo : Figura
	{
		protected double baseRectangulo;
		protected double alturaRectangulo;

		public Rectangulo(double _base, double _altura)
		{
			if (_base < 0 || _altura < 0)
				throw new ArgumentException("El valor de la base y de la altura deben ser positivos");
			this.baseRectangulo = _base;
			this.alturaRectangulo = _altura;
		}

		public double area()
		{
			return baseRectangulo * alturaRectangulo;
		}

	}
}
