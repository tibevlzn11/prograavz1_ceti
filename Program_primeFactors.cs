using System;
using static System.Console;
using PrimeFactors;

namespace PrimeFactorsApp
{
    class Program
    {
        static void Main(string[] args)
        {
           var factores = new Functions();
           int numeroIng;
           WriteLine("Calcular los factores primos de un numero");
          do
          { 
              WriteLine("Ingrese un numero cualquiera entre 1 y 1000");
              numeroIng=int.Parse(ReadLine());
          }
          while(numeroIng>1000);//Pide el numero una vez, si este pasa de 1000 lo vuelve a pedir
            string facts= factores.SacarFactores(numeroIng);
            WriteLine($"Los factores primos de: {numeroIng} son: "+facts);
        }
    }
}
