using System;
using System.Collections.Generic;

List<int> divisores = new List<int>();

while(true) {
	Console.WriteLine("");
	Console.WriteLine("==== Digite um número INTEIRO ====");
	Console.WriteLine("");
	Console.Write("Número: ");
	int numero = Convert.ToInt32(Console.ReadLine());

	for (var i = 1; i < numero; i++)
	{
		if (numero % i == 0)
		{
			divisores.Add(i);
		}
	}

	Console.WriteLine("Divisores: " + string.Join(", ", divisores));
	Console.WriteLine($"Número primo: {(divisores.Count == 1 ? "SIM" : "NÃO")}");
}