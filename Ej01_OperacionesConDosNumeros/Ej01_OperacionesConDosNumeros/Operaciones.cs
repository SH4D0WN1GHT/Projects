using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej01_OperacionesConDosNumeros{ 
	internal class Operaciones{
		public int a { get; set; }
		public int b { get; set; }

		public Operaciones(int a, int b)
		{
			this.a = a;
			this.b = b;
		}
		public int suma(){
			return this.a + this.b;
		}
		public int resta(){
			return this.a - this.b;
		}
		public int multiplicacion(){
			return this.a * this.b;
		}
		public int division(){
			return this.a / this.b;
		}
		public int residuo(){
			return this.a % this.b;
		}
	}
}
