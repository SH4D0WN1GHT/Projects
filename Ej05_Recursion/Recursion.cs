using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej05_Recursion
{
	internal class Recursion
	{
		public Recursion() { }
		public int MultiplicarDigitos(int num)
		{

			if (num < 10)
			{
				return num;
			}
			//Recursion
			return (num % 10) * MultiplicarDigitos(num / 10);
		}
	}
}
