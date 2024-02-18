using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej04_DibujarTriangulo
{
	internal class Triangulo{
		public void dibujarTriangulo()
		{
			for (int i = 1; i <= 10; i++)
			{
				for (int j = 10 - i; j > 0; j--)
				{
					Console.Write(" ");
				}
				for (int k = 1; k <= i; k++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
	}
}
