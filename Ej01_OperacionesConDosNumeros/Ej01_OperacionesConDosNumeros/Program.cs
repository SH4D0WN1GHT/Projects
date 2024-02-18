namespace Ej01_OperacionesConDosNumeros
{
	internal class Program{
		int num1 = 0;
		int num2 = 0;
		static void Main(string[] args){
			Program p = new Program();
			p.num1 = pedirDatos('a');
			p.num2 = pedirDatos('b');
			Operaciones op = new Operaciones(p.num1, p.num2);

			Console.WriteLine("Número 1: " + p.num1);
			Console.WriteLine("Número 2: " + p.num2);
			Console.WriteLine($"La suma de {p.num1} más {p.num2} es: {op.suma()}");
			Console.WriteLine($"La resta de {p.num1} menos {p.num2} es: {op.resta()}");
			Console.WriteLine($"La multiplicacion de {p.num1} por {p.num2} es: {op.multiplicacion()}");
			Console.WriteLine($"La division de {p.num1} entre {p.num2} es: {op.division()}");
			Console.WriteLine($"Y el residuo es: {op.residuo()}");
		}
		public static int pedirDatos(char dato) {
			Console.WriteLine("Dame el dato " + dato);
			return Convert.ToInt32(Console.ReadLine());
		}
	}
}
