using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            float peso;
            float altura;
            float resultado;
            
          

            Console.Write("Entre com a sua idade \n");
            Console.ReadLine(); 

            Console.Write("Entre com o seu peso \n");
            peso = float.Parse(Console.ReadLine());
           
            

            Console.Write("Entre com a sua altura \n");
            altura = float.Parse(Console.ReadLine());
            
            

            resultado = (peso /(altura*altura ));
            

            if (resultado<18) 


            Console.Write("Você está abaixo do peso");
            Console.ReadLine();

            if (resultado <= 24)
                Console.Write("Seu peso está normal");
                Console.ReadLine();

            if (resultado <= 29)
                Console.Write("Você está com sobrepeso.");
                Console.ReadLine();

            if (resultado <= 34)
                Console.Write("Você está com obesidade grau I");
                Console.ReadLine(); 
            if (resultado <= 39)
                Console.Write("Você está com obesidade grau II");
                Console.ReadLine();

            if (resultado <= 34)
                Console.Write("Você está com obesidade grau III");
                Console.ReadLine();












        }
    }
}
