//Imprimir numeros del 1 al 100 sin for ni while
using System;

class Imprimir{

	public static int numeros(int num){
		if(num <= 100){
			Console.WriteLine(num);
			num ++;
			return numeros(num);
		}
		else{
			return 0;
		}

	}
	static void Main(){
		int num = 0;

		Imprimir.numeros(num);

		//Console.WriteLine(ultimo);

		Console.ReadKey(true);
	}
}