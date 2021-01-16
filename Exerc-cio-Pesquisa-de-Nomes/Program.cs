using System;

namespace Exercício_Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] nomes = new string [10];

            Console.WriteLine("Pesquisa de nomes");
            Console.WriteLine("----------------");


            for(var contador = 0; contador < 10; contador++){
                Console.WriteLine($"Informe o {contador+1}º nome: ");
                nomes[contador] = Console.ReadLine();
            }

            Console.WriteLine("Pesquisa");
            Console.WriteLine("----------------");

            Console.WriteLine("Informe um nome: ");
            string resposta = Console.ReadLine();
            
            for(var contador = 0; contador < 1 ; contador++)
            {
                 if(nomes[contador] == resposta){
                   Console.WriteLine("ACHEI");
               }else{
                   Console.WriteLine("Não Achei");
               }
               
            }
             
        }
    }
}
