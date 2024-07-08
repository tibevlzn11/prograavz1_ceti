using System;
using static System.Console;
namespace Examen1erP
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arrayNumsDev = new int [1000];//aqui se guardan los numeros devueltos
            int [] arrayNumsPos = new int [501];//guarda todos los numeros positivos de 0 a 500
            int [] arrayNumsNeg = new int [501];//guarda los numeros negativos de -500 a 0
            int aux = 500;
            for (int i = 0; i<=500; i++)
            {
                arrayNumsPos[i]=i;
            }
            for (int i = -500; aux>=0; i++)
            {
                arrayNumsNeg[aux]=i;
                aux--;
            }
            //Termina llenado de arreglos de los numeros elegibles
            int cantDatos;
            do
            { 
              WriteLine("Ingrese un numero cualquiera entre 1 y 1000");
              cantDatos=int.Parse(ReadLine());
            }
            while(cantDatos>1000 || cantDatos<1);//Pide el numero una vez, si este pasa de 1000 o es menor a 1 lo vuelve a pedir
            if(cantDatos%2==0)
            {
                int posiciones = cantDatos/2;
                int cont=0;
                for(int i = 1; i<=posiciones; i++)
                {
                    arrayNumsDev[cont]=arrayNumsNeg[i];
                    cont++;
                }
                int cont1=cont;
                for(int i = 1; i<=posiciones; i++)
                {
                    arrayNumsDev[cont1]=arrayNumsPos[i];
                    cont1++;
                }
            }else{
                int posiciones = cantDatos/2;
                int cont=0;
                for(int i = 1; i<=posiciones; i++)
                {
                    arrayNumsDev[cont]=arrayNumsNeg[i];
                    cont++;
                }
                arrayNumsDev[cont]=0;//aqui estaba el error
                //ingresaba el cero en una posicion mas de las necesarias
                int cont1=cont+1;//aqui sumaba 2 en lugar de uno y tambien se sobrepasaban las posiciones
                for(int i = 1; i<=posiciones; i++)
                {
                    arrayNumsDev[cont1]=arrayNumsPos[i];
                    cont1++;
                }
            }
            for (int i=0; i<cantDatos; i++)
            {
                Write($"{arrayNumsDev[i]},");
            }
        }
    }
}
