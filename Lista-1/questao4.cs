using System;
using System.Collections.Generic;

while(true){
    Console.WriteLine("");
    Console.WriteLine("INSIRA UM NÚMERO PARA VERIFICAR SE ELE É PERFEITO");
    Console.WriteLine("");
    
    
    Console.Write("Número: ");
    int numero = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" ");
    
    List<int> divisores = new List<int>();
    
    for(var i = 1; i < numero; i++){
        if(numero % i == 0){
            divisores.Add(i);
        }
    }
    
    Console.WriteLine("Divisores: " + string.Join(", ", divisores));
    
    int resultado = 0;
    foreach(var item in divisores){
        resultado = item + resultado;
    }
    
    if(resultado == numero){
        Console.WriteLine($"O número {numero} é um número PERFEITO!");
    }else{
        Console.WriteLine($"O número {numero} NÃO é um número PERFEITO!");
        
    }
}