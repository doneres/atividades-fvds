using System;

while(true){
    Console.WriteLine("");
    Console.WriteLine("Digite um número para verificar sua tabuada.");
    Console.WriteLine("");
    
    Console.Write("Número: ");
    int numero = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");
    
    for(var i = 1; i <= 10; i++){
        Console.WriteLine($"{numero} X {i} = {numero*i}");
    }
}