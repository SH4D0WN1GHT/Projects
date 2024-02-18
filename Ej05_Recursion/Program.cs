using System.Reflection.PortableExecutable;

namespace Ej05_Recursion
{
	internal class Program
	{
		static void Main(string[] args){
			Recursion recursion = new Recursion();
			int num = pedirNum();
			mostrarDatos(recursion.MultiplicarDigitos(num));
		}
		static int pedirNum()
		{
			Console.Write("Dame un numero: ");
			return Convert.ToInt32(Console.ReadLine());
		}
		static void mostrarDatos(int datos)
		{
			Console.WriteLine($"El resultado es: {datos}");
		}
	}
}
