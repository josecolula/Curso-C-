using System;

class Program {
	static void Main() {
		Console.WriteLine("Tamaño del arreglo");
		int tam = Convert.ToInt32(Console.ReadLine());

		//Definir arreglo
		 int[] numeros = new int[tam];
		 //Leer datos y guardarlos en el arreglo

		 for(int i = 0; i<numeros.Length; i++)
		 {
		 	Console.WriteLine("Indice {0}: ",i);
		 	numeros[i] = Convert.ToInt32(Console.ReadLine());
		 }

		 //Muestra los datos
		 Console.WriteLine("Los datos que ingresaste son: ");
		 MostrarArreglo(numeros);
		 Console.ReadKey();
	}
	static void MostrarArreglo(int[] arreglo)
	{
		foreach(int num in arreglo)
		{
			Console.WriteLine("{0}",num);
		}
		Console.WriteLine();
	}
}