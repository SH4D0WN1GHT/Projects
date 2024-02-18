namespace Ej03_IdentificarMayorYMenor{
	internal class Ej03_IdentificarMayorYMenor{
		static void Main(string[] args){
			Numeros numeros = new Numeros();

            for (int i = 0; i < 5; i++)
            {
				Console.WriteLine($"Ingrese el número {i}:");
                numeros.insertarElementos(pedirNumeros());
            }
			imprimirResultados(numeros);
		}

		public static int pedirNumeros(){
			return Convert.ToInt32(Console.ReadLine());
		}
		public static void imprimirResultados(Numeros numeros)
		{
			Console.WriteLine($"El menor de los números es {numeros.encontrarMenor()} y el mayor de los números es {numeros.encontrarMayor()}");
		}
	}
}
