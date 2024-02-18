using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej03_IdentificarMayorYMenor{
	internal class Numeros{
		List<int> enteros = new List<int>();
		
		public void insertarElementos(int a){
			enteros.Add(a);
		}
		public int encontrarMayor()
		{
			int m = enteros[0];
			for (int i = 0; i < enteros.Count; i++)
			{
                if (enteros[i] > m)
                {
					m = enteros[i];
                }
            }
			return m;
		}
		public int encontrarMenor()
		{
			int m = enteros[0];
			for (int i = 0; i < enteros.Count; i++)
			{
				if (enteros[i] < m)
				{
					m = enteros[i];
				}
			}
			return m;
		}
	}
}
