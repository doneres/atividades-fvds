using System;

Random rnd = new Random();
int x = rnd.Next(100);

Console.WriteLine("");
Console.WriteLine("Digite um número de 0 a 99.");
Console.WriteLine("");

while(true) {
	Console.Write("Número: ");
	int numero = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("");

	if(numero == x) {
		Console.WriteLine("Parabéns, vc acertou o número!");
		break;
	} else if(numero > x) {
		Console.WriteLine("Seu número é MAIOR.");
	} else {
		Console.WriteLine("Seu número é MENOR.");
	}

}