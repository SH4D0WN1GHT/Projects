using System.ComponentModel;

namespace Ej02_TablaDeMultiplicar
{
	internal class Program{
		int tabla = 0;
		static void Main(string[] args){
			Program p = new Program();
			Console.WriteLine("Ingrese un número entre 1 y 10: ");
			p.tabla = pedirTabla();
			mostrarTabla(p.tabla);
		}
		public static int pedirTabla(){
			return Convert.ToInt32(Console.ReadLine());
		}
		public static void mostrarTabla(int t){
			for(int i = 1; i <= 10; i++){
				Console.WriteLine($"{t} x {i} = {t*i}");
			}
		}
	}
}
