using System;

namespace area
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar variaveis 
            int comprimento, altura, area;

            //obter dados
            Console.Write("Comprimento:");
            comprimento = int.Parse(Console.ReadLine());
            Console.Write("Altura:");
            altura = int.Parse(Console.ReadLine());
            //calcular
            area = comprimento * altura;
            //apresenta resultado
            Console.WriteLine("Área: " + area);
            Console.Read();
        }
    }
}
